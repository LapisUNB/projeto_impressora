// Definição das portas do motor do eixo X
#define x_paso 2
#define x_dire 5
#define x_habi 8

// Definição das portas do motor do eixo Y
#define y_paso 3
#define y_dire 6
#define y_habi 8

// Pino do Rele
#define rele 12

// Fim de cursos
#define fim_curso_pin_x A2
#define fim_curso_pin_y A0

// Valor pode ser alterado de acordo com o necessário
int retardo = 550; // "Velocidade dos motores" - enquanto menor o valor, mais rápido os motores giram

// Recomendo não mudar esses valores
int cont = 0; // Contador para determinar o padrão de movimentação
int posicao_x = 0; // Posição atual no eixo X
int passos_4_5mm = 20.25 * 4.5; // Passos para andar 4.5 mm
int passos_2_7mm = 20.25 * 2.7; // Passos para andar 2.7 mm

// Definições de passos por centímetro (ajustar conforme sua configuração)
#define PASSOS_POR_CM_X 202.5 // Passos por centímetro para o eixo X
#define PASSOS_POR_CM_Y 202.5 // Passos por centímetro para o eixo Y

// Calcula o número de passos para as distâncias desejadas
int passos_cm_x = 20 * PASSOS_POR_CM_X; // Ajustado para 18 cm
int passos_cm_y = 2.7 * PASSOS_POR_CM_Y;

// Calcula o número de passos para 5 mm
int passos_5_mm_x = 1 * PASSOS_POR_CM_X; // 5 mm em passos para X
int passos_5_mm_y = 1 * PASSOS_POR_CM_Y; // 5 mm em passos para Y

bool movidoParaBaixo = false; // Variável para controle do movimento para baixo

void setup() {
  pinMode(x_paso, OUTPUT);
  pinMode(x_dire, OUTPUT);
  pinMode(x_habi, OUTPUT);
  pinMode(y_paso, OUTPUT);
  pinMode(y_dire, OUTPUT);
  pinMode(y_habi, OUTPUT);
  pinMode(rele, OUTPUT);
  pinMode(fim_curso_pin_x, INPUT_PULLUP); // Usando resistor pull-up interno
  pinMode(fim_curso_pin_y, INPUT_PULLUP); // Usando resistor pull-up interno

  Serial.begin(115200);
  pinMode(rele, HIGH);

  // Movimenta o eixo X e Y até o fim de curso e recua 5 mm
  move_to_fim_curso(x_paso, x_dire, x_habi, fim_curso_pin_x, passos_5_mm_x);
  move_to_fim_curso(y_paso, y_dire, y_habi, fim_curso_pin_y, passos_5_mm_y);

  // Movimenta o eixo X 18 cm
  zeramento(x_paso, x_dire, x_habi, passos_cm_x);

  // Movimenta o eixo Y 2.7 cm
  zeramento(y_paso, y_dire, y_habi, passos_cm_y);
}

void loop() {
  if (Serial.available() > 0) {
    char c = Serial.read();
    Serial.println(c);

    if (c == '1' || c == '0') {
      int passos = (cont % 2 == 0) ? passos_4_5mm : passos_2_7mm;

      // Move o eixo X para o próximo caractere
      movimento(x_paso, x_dire, x_habi, passos, LOW); // Avança no eixo X
      posicao_x += passos; // Atualiza a posição no eixo X

      // Alterna o contador para o próximo movimento
      cont++;

      if (c == '1') {
        digitalWrite(rele, HIGH);
        delay(50); // Delay reduzido após rele HIGH
        digitalWrite(rele, LOW);
        delay(500); // Delay reduzido
      }

      movidoParaBaixo = false; // Reseta a variável de controle ao ler '1' ou '0'

      Serial.println("OK"); // Envia "OK" após processar '1' ou '0'
      Serial.flush();

    } else if (c == '\n') {
      // Move o eixo X de volta para a posição inicial (no caso de uma nova linha)
      movimento(x_paso, x_dire, x_habi, -posicao_x, HIGH);
      posicao_x = 0; // Reseta a posição no eixo X

      // Movimenta o eixo Y para a próxima linha (apenas se necessário para o Braille)
      if (!movidoParaBaixo) {
        movimento(y_paso, y_dire, y_habi, passos_4_5mm, HIGH);
        movidoParaBaixo = true;
      }

      // Reseta o contador para o próximo caractere
      cont = 0;

      Serial.println("OK"); // Envia "OK" após processar '\n'
      Serial.flush();

    } else if (c == '\r') {
      // Move o eixo X de volta para a posição inicial
      movimento(x_paso, x_dire, x_habi, -posicao_x, HIGH);
      posicao_x = 0; // Reseta a posição no eixo X

      // Movimenta o eixo Y para a próxima linha do documento Braille
      movimento(y_paso, y_dire, y_habi, passos_4_5mm, HIGH);

      // Reseta a variável de controle
      movidoParaBaixo = false;

      Serial.println("OK"); // Envia "OK" após processar '\r'
      Serial.flush();
    }
  }
  // Removido o delay(100); no loop principal
}

// Função para movimentar o motor até o fim de curso e recuar 5 mm na direção oposta
void move_to_fim_curso(int paso_, int dire_, int habi_, int fim_curso_pin, int passos_recuo) {
  digitalWrite(habi_, LOW); // Habilita o Driver
  digitalWrite(dire_, HIGH); // Direção para encontrar o fim de curso
  while (digitalRead(fim_curso_pin) != HIGH) { // Enquanto não acionar o fim de curso
    digitalWrite(paso_, HIGH);
    delayMicroseconds(retardo);
    digitalWrite(paso_, LOW);
    delayMicroseconds(retardo);
  }
  digitalWrite(paso_, LOW); // Garante que o motor pare assim que o fim de curso for acionado
  digitalWrite(habi_, HIGH); // Desabilita o Driver

  delay(500); // Delay reduzido

  // Gira o motor para o lado oposto
  digitalWrite(habi_, LOW); // Habilita o Driver
  digitalWrite(dire_, LOW); // Direção oposta
  for (int i = 0; i < passos_recuo; i++) {
    digitalWrite(paso_, HIGH);
    delayMicroseconds(retardo);
    digitalWrite(paso_, LOW);
    delayMicroseconds(retardo);
  }
  digitalWrite(paso_, LOW); // Garante que o motor pare após recuar
  digitalWrite(habi_, HIGH); // Desabilita o Driver
}

// A função zeramento faz o motor andar a distância desejada em uma direção
void zeramento(int paso_, int dire_, int habi_, int passos) {
  digitalWrite(habi_, LOW); // Habilita o Driver
  digitalWrite(dire_, LOW); // Direção de zeramento
  for (int i = 0; i < passos; i++) { // Dá passos conforme o número especificado
    digitalWrite(paso_, HIGH);
    delayMicroseconds(retardo);
    digitalWrite(paso_, LOW);
    delayMicroseconds(retardo);
  }
  digitalWrite(habi_, HIGH); // Desabilita o Driver
}

// A função movimento faz o motor andar a distância desejada na direção oposta
void movimento(int paso_, int dire_, int habi_, int passos, int dir) {
  digitalWrite(habi_, LOW); // Habilita o Driver
  digitalWrite(dire_, dir == HIGH ? LOW : HIGH); // Inverte a direção
  for (int i = 0; i < abs(passos); i++) { // Dá passos por um tempo
    digitalWrite(paso_, HIGH);
    delayMicroseconds(retardo);
    digitalWrite(paso_, LOW);
    delayMicroseconds(retardo);
  }
  digitalWrite(habi_, HIGH); // Desabilita o Driver
}