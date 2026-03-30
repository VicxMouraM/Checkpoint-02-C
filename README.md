# 🎴 CardGame - Biblioteca de Jogo de Cartas

## 👥 Integrante

* Victoria Moura

---

## 📌 Descrição do Projeto

Este projeto consiste na criação de uma **biblioteca de classes genérica para jogos de cartas**, desenvolvida em C#, com o objetivo de modelar estruturas reutilizáveis para diferentes tipos de jogos.

A solução foi organizada em dois projetos principais:

* **CardGame:** Biblioteca responsável pela lógica e modelagem do jogo
* **CardGameConsole:** Aplicação console utilizada para simular e testar o funcionamento do jogo

---

## 🧱 Estrutura do Projeto

### 📁 CardGame (Biblioteca de Classes)

Contém toda a modelagem do domínio do jogo:

#### 🔹 Models

* **Card:** Representa uma carta (naipe + valor)
* **Deck:** Representa o baralho com embaralhamento e compra de cartas
* **Hand:** Representa a mão de um jogador
* **Player:** Representa um jogador da partida
* **Round:** Representa uma rodada do jogo
* **Match:** Representa a partida completa e mantém o histórico

#### 🔹 Enums

* **Suit:** Naipe das cartas (Hearts, Diamonds, Clubs, Spades)
* **CardRank:** Valores das cartas (Ace até King)
* **RoundResult:** Resultado da rodada (Vitória jogador 1, jogador 2 ou empate)

---

## ⚙️ Funcionalidades Implementadas

* ✔ Criação de baralho completo (52 cartas)
* ✔ Embaralhamento aleatório
* ✔ Distribuição de cartas entre jogadores
* ✔ Execução de rodadas
* ✔ Comparação de cartas
* ✔ Controle de pontuação
* ✔ Histórico de rodadas

---

## 🧠 Estruturas de Dados Utilizadas

* `List<Card>` → armazenamento de cartas
* `List<Player>` → jogadores da partida
* `List<Round>` → histórico de rodadas

---

## ▶️ Execução do Projeto

1. Definir o projeto **CardGameConsole** como inicialização
2. Compilar a solução
3. Executar o projeto

O console exibirá:

* Rodadas do jogo
* Cartas jogadas
* Resultado de cada rodada
* Placar final

---

## 🎯 Objetivo

Criar uma base reutilizável e escalável para jogos de cartas, permitindo futuras expansões como:

* Interface gráfica
* Novas regras de jogo
* Multiplayer

---

## 🛠️ Tecnologias Utilizadas

* C#
* .NET 8
* Visual Studio

---

## 📅 Prazo

18/03/2026 23h59

---

## ✅ Conclusão

O projeto demonstra a aplicação de conceitos de orientação a objetos, separação de responsabilidades e organização em camadas, criando uma estrutura sólida para desenvolvimento de jogos de cartas.
