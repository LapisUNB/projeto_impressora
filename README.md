# Impressora Braille Completa em C# com Integração Arduino

Este projeto implementa uma solução completa para uma impressora Braille, abrangendo desde a tradução de texto para Braille até a interface gráfica no Windows e a lógica de controle do hardware via Arduino.

## Visão Geral

O sistema é composto por duas partes principais:

1.  **Aplicação Windows em C#:** Responsável pela interface do usuário, tradução de texto para o formato Braille e comunicação serial com o Arduino. Desenvolvido para o ambiente Windows utilizando o Visual Studio.
2.  **Código Arduino (.ino):** Executado no microcontrolador Arduino, recebe os comandos da aplicação Windows via comunicação serial e controla os solenoides ou mecanismos responsáveis pela impressão dos pontos Braille.

## Funcionalidades Principais

* **Tradução de Texto para Braille:** Implementa algoritmos para converter texto comum em português para o sistema de escrita Braille.
* **Interface Gráfica Windows:** Oferece uma interface intuitiva para o usuário inserir o texto a ser impresso e controlar o processo de impressão.
* **Visualização Braille:** Permite visualizar o texto traduzido para Braille antes da impressão.
* **Comunicação Serial:** Estabelece a comunicação entre a aplicação Windows e o Arduino através da porta serial.
* **Controle de Hardware:** O código no Arduino interpreta os comandos recebidos e aciona os mecanismos de impressão Braille.
* **Compatibilidade Windows:** Projetado especificamente para rodar em sistemas operacionais Windows, utilizando as ferramentas e bibliotecas disponíveis neste ambiente.
* **Integração com Arduino IDE:** O código do Arduino é desenvolvido e pode ser carregado utilizando o Arduino IDE.

## Pré-requisitos

Para executar e desenvolver este projeto, você precisará ter os seguintes softwares instalados no seu sistema Windows:

* **Visual Studio:** (Versão 2019 ou superior recomendado) Necessário para compilar e executar a aplicação Windows em C#.
* **.NET Framework ou .NET:** (A versão utilizada no projeto) Essencial para o funcionamento da aplicação C#.
* **Arduino IDE:** Necessário para compilar e carregar o código `.ino` para a placa Arduino.
* **Driver da Placa Arduino:** Certifique-se de que o driver da sua placa Arduino esteja instalado corretamente no Windows para a comunicação serial.

## Como Utilizar

1.  **Clonar o Repositório (se aplicável):**
    ```bash
    git clone (https://github.com/LapisUNB/projeto_impressora.git)
    cd projeto_impressora
    ```

2.  **Abrir a Aplicação C#:**
    * Navegue até a pasta `CSharpApp` e abra o arquivo de solução (`.sln`) no Visual Studio.
    * Compile e execute o projeto para iniciar a interface gráfica.

3.  **Carregar o Código no Arduino:**
    * Abra o arquivo `PRINT_PRONTA.ino` que está na pasta `ArduinoCode` utilizando o Arduino IDE.
    * Conecte sua placa Arduino ao computador via USB.
    * Selecione a placa e a porta serial correta no menu "Ferramentas" do Arduino IDE.
    * Faça o upload do código para a placa Arduino.

4.  **Configurar a Comunicação Serial:**
    * Na aplicação Windows, localize as configurações de comunicação serial (geralmente em um menu ou tela de configurações).
    * Selecione a porta serial correspondente à sua placa Arduino (você pode verificar essa informação no Gerenciador de Dispositivos do Windows ou no Arduino IDE).
    * Configure a taxa de transmissão (baud rate) para corresponder à taxa definida no código do Arduino (geralmente 9600).

5.  **Imprimir em Braille:**
    * Na interface da aplicação Windows, digite ou cole o texto que deseja imprimir.
    * Visualize a tradução para Braille (se a funcionalidade estiver implementada).
    * Clique no botão de "Imprimir" ou similar para enviar os comandos para o Arduino e iniciar a impressão.

## Detalhes Técnicos

### Aplicação C#

* **Linguagem:** C#
* **Framework:** .NET Framework ou .NET
* **Interface Gráfica:** Windows Forms ou WPF (dependendo da implementação)
* **Comunicação Serial:** Utiliza as classes do namespace `System.IO.Ports` para estabelecer e gerenciar a comunicação com o Arduino.
* **Tradução Braille:** A lógica de tradução implementa as regras do sistema Braille para o português, convertendo cada caractere do texto para sua representação em pontos Braille.

### Código Arduino (.ino)

* **Linguagem:** C++ (a linguagem do Arduino)
* **Biblioteca Serial:** Utiliza a biblioteca `Serial` padrão do Arduino para receber os dados da aplicação Windows.
* **Controle dos Mecanismos de Impressão:** O código interpreta os bytes ou comandos recebidos pela serial e aciona os pinos digitais conectados aos solenoides ou motores que formam os pontos Braille no papel.
* **Lógica de Movimentação:** Implementa a lógica para avançar o papel e posicionar a cabeça de impressão corretamente para cada caractere Braille.

## Contribuição

Se você deseja contribuir para este projeto, sinta-se à vontade para:

* Reportar problemas (bugs) ou sugestões de melhorias através das Issues.
* Enviar Pull Requests com novas funcionalidades, correções ou otimizações.
* Compartilhar suas ideias e experiências relacionadas ao projeto.

## Licença

UNB

