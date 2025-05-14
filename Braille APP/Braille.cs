using System;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using System.Collections.Generic;
using static Braille_APP.Braille;
using System.Drawing;

namespace Braille_APP
{
    public partial class Braille : Form
    {
        private const int Columns = 25;
        private const int Rows = 54;

        string[] brailleABNT = {
            "100000", // a
            "101000", // b
            "110000", // c
            "110100", // d
            "100100", // e
            "111000", // f
            "111100", // g
            "101100", // h
            "011000", // i
            "011100", // j
            "100010", // k
            "101010", // l
            "110010", // m
            "110110", // n
            "100110", // o
            "111010", // p
            "111110", // q
            "101110", // r
            "011010", // s
            "011110", // t
            "100011", // u
            "101011", // v
            "011111", // w
            "110011", // x
            "110111", // y
            "100111", // z
            "001000", // ,
            "001010", // ;
            "001100", // :
            "000010", // .
            "001001", // ?
            "001110", // !
            "010001"  // maiúscula
        };

        string[] brailleNum = {
            "011100", // 0
            "100000", // 1
            "101000", // 2
            "110000", // 3
            "110100", // 4
            "100100", // 5
            "111000", // 6
            "111100", // 7
            "101100", // 8
            "011000"  // 9
        };
        //tem que concluir a parte das letras em maiusculo
        public class BrailleCharacter
        {
            public string line1 { get; set; }
            public string line2 { get; set; }
            public string line3 { get; set; }
        }

        public class BrailleRow
        {
            public List<BrailleCharacter> characterList = new List<BrailleCharacter>();
        }

        public class BraillePaper
        {
            public List<BrailleRow> linesList = new List<BrailleRow>();
        }

        public Braille()
        {
            InitializeComponent();
        }

        private void Braille_Load(object sender, EventArgs e)
        {

            txtValue.ScrollBars = ScrollBars.Vertical;
            txtValue.TextChanged += new EventHandler(txtValue_TextChanged);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Arquivo de Texto | *.txt";
            sf.ShowDialog();


            if (string.IsNullOrEmpty(sf.FileName) == false)
            {

                try
                {
                    using (StreamWriter writer = new StreamWriter(sf.FileName, false, Encoding.UTF8))
                    {
                        writer.Write(txtValue.Text);
                        writer.Flush();
                    }
                }
                catch
                {
                    MessageBox.Show("Não foi possivel salvar o seu arquivo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Arquivo de texto | *.txt";
            of.ShowDialog();
            if (string.IsNullOrEmpty(of.FileName) == false)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(of.FileName, Encoding.GetEncoding(CultureInfo.GetCultureInfo("pt-BR").TextInfo.ANSICodePage)))
                    {
                        txtValue.Text = reader.ReadToEnd();
                    }
                }

                catch
                {
                    MessageBox.Show("Não foi possivel abrir o seu arquivo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btn_Traduzir_Click(object sender, EventArgs e)
        {
            string frase = txtValue.Text;
            string[,] brailleMatrix = new string[Rows * 3, Columns * 2];
            BraillePaper braillePaper = new BraillePaper();
            List<BrailleRow> brailleRowList = new List<BrailleRow>();
            List<BrailleCharacter> brailleCharList = new List<BrailleCharacter>();

            // Inicializar matriz de Braille
            for (int r = 0; r < Rows * 3; r++)
            {
                for (int c = 0; c < Columns * 2; c++)
                {
                    brailleMatrix[r, c] = " ";
                }
            }

            // Traduzir frase para Braille e preencher a matriz
            FillBrailleMatrix(frase, brailleMatrix, braillePaper, brailleRowList, brailleCharList);

            // Converter as linhas de Braille para string formatada
            StringBuilder formattedBrailleText = ConvertBrailleToFormattedString(braillePaper, Columns);


            Tradução_Braille newForm = new Tradução_Braille();
            newForm.SetText(formattedBrailleText); // Converter a matriz antes de passar
            newForm.ShowDialog();
        }

        private void FillBrailleMatrix(string frase, string[,] brailleMatrix, BraillePaper braillePaper, List<BrailleRow> brailleRowList, List<BrailleCharacter> brailleCharList)
        {
            frase = frase.Replace("\r\n", "");
            int currentRow = 0;
            int currentCol = 0;

            for (int i = 0; i < frase.Length; i++)
            {
                char letra = frase[i];
                bool isUpper = char.IsUpper(letra);
                bool isDigit = char.IsDigit(letra);
                letra = char.ToLower(letra);
                BrailleCharacter brailleChar = new BrailleCharacter();

                if (letra == ' ')
                {
                    AddBrailleChar(brailleMatrix, currentRow, currentCol, "00", "00", "00", brailleChar);
                }
                else if ((letra >= 'a' && letra <= 'z') || letra == ',' || letra == '?' || letra == '!' || letra == '.' || letra == ';' || letra == ':')
                {
                    int index = GetBrailleIndex(letra);
                    if (index != -1)
                    {
                        if (isUpper)
                        {
                            // Prefixo para letras maiúsculas
                            AddBrailleChar(brailleMatrix, currentRow, currentCol, "00", "01", "00", brailleChar);
                            currentCol += 2;
                            if (currentCol >= Columns * 2)
                            {
                                currentCol = 0;
                                currentRow += 3;
                                if (currentRow >= Rows * 3) break;
                            }
                        }
                        string codigo = brailleABNT[index];
                        AddBrailleChar(brailleMatrix, currentRow, currentCol,
                            codigo.Substring(0, 2),
                            codigo.Substring(2, 2),
                            codigo.Substring(4, 2),
                            brailleChar);
                    }
                }
                else if (isDigit)
                {
                    // Prefixo para números
                    AddBrailleChar(brailleMatrix, currentRow, currentCol, "00", "01", "11", brailleChar);
                    currentCol += 2;
                    if (currentCol >= Columns * 2)
                    {
                        currentCol = 0;
                        currentRow += 3;
                        if (currentRow >= Rows * 3) break;
                    }

                    string codigo = brailleNum[letra - '0'];
                    AddBrailleChar(brailleMatrix, currentRow, currentCol,
                        codigo.Substring(0, 2),
                        codigo.Substring(2, 2),
                        codigo.Substring(4, 2),
                        brailleChar);
                }

                brailleCharList.Add(brailleChar);

                // Atualizar posição na matriz
                currentCol += 2;
                if (currentCol >= Columns * 2)
                {
                    currentCol = 0;
                    currentRow += 3;
                    if (currentRow >= Rows * 3)
                    {
                        break; // Parar se atingir o fim da matriz
                    }
                }
            }
            brailleCharList.Add(new BrailleCharacter());
            int numberRows = (brailleCharList.Count / Columns) + 1;
            for (int i = 0; i < numberRows; i++)
            {
                BrailleRow row = new BrailleRow();
                for (int j = 0; j < Columns; j++)
                {
                    int index = i * Columns + j;
                    if (index < brailleCharList.Count)
                    {
                        row.characterList.Add(brailleCharList[index]);
                    }
                    else
                    {
                        break;
                    }
                }
                brailleRowList.Add(row);
            };
            braillePaper.linesList = brailleRowList;
        }

        private void AddBrailleChar(string[,] brailleMatrix, int row, int col, string line1, string line2, string line3, BrailleCharacter brailleChar)
        {
            brailleMatrix[row, col] = line1;
            brailleChar.line1 = line1;

            brailleMatrix[row + 1, col] = line2;
            brailleChar.line2 = line2;

            brailleMatrix[row + 2, col] = line3;
            brailleChar.line3 = line3;
        }

        private StringBuilder ConvertBrailleToFormattedString(BraillePaper braillePaper, int columns)
        {
            StringBuilder formattedString = new StringBuilder();

            foreach (var row in braillePaper.linesList)
            {
                StringBuilder line1 = new StringBuilder();
                StringBuilder line2 = new StringBuilder();
                StringBuilder line3 = new StringBuilder();

                foreach (var brailleChar in row.characterList)
                {
                    line1.Append(brailleChar.line1 + " ");
                    line2.Append(brailleChar.line2 + " ");
                    line3.Append(brailleChar.line3 + " ");
                }

                formattedString.AppendLine(line1.ToString().TrimEnd());
                formattedString.AppendLine(line2.ToString().TrimEnd());
                formattedString.AppendLine(line3.ToString().TrimEnd());
            }

            return formattedString;
        }

        private int GetBrailleIndex(char letra)
        {
            if (letra >= 'a' && letra <= 'z') return letra - 'a';
            if (letra == ',') return 26;
            if (letra == ';') return 27;
            if (letra == ':') return 28;
            if (letra == '.') return 29;
            if (letra == '?') return 30;
            if (letra == '!') return 31;
            return -1;
        }


        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox tb = sender as System.Windows.Forms.TextBox;
            if (tb != null)
            {

                string[] lines = tb.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Length > 25)
                    {
                        string currentLine = lines[i];
                        lines[i] = currentLine.Substring(0, 25);
                        string remainingText = currentLine.Substring(25);

                        if (i + 1 < lines.Length)
                        {
                            lines[i + 1] = remainingText + lines[i + 1];
                        }
                        else
                        {
                            Array.Resize(ref lines, lines.Length + 1);
                            lines[i + 1] = remainingText;
                        }
                    }
                }

                tb.TextChanged -= txtValue_TextChanged;
                tb.Text = string.Join(Environment.NewLine, lines);
                tb.SelectionStart = tb.Text.Length;
                tb.SelectionLength = 0;
                tb.TextChanged += txtValue_TextChanged;

            }
        }


        private void MenuItem_MouseEnter(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            item.ForeColor = Color.White;
            item.BackColor = Color.LightBlue;
            item.Font = new Font(item.Font, FontStyle.Bold);
        }

        private void MenuItem_MouseLeave(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            item.ForeColor = Color.Black;
            item.BackColor = Color.Transparent;
            item.Font = new Font(item.Font, FontStyle.Regular);
        }

        private void menuStrip1_RendererChanged(object sender, EventArgs e)
        {
        }

        private void menuStrip1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                ToolStripMenuItem item = this.menuStrip1.Items[e.Index] as ToolStripMenuItem;
                if (item != null)
                {
                    e.Graphics.FillRectangle(new SolidBrush(item.Selected ? Color.LightBlue : Color.Transparent), e.Bounds);
                    e.Graphics.DrawString(item.Text, e.Font, new SolidBrush(item.ForeColor), e.Bounds.X + 2, e.Bounds.Y + 2);
                }
            }


        }

        private System.Windows.Forms.Label label1;

    }
}