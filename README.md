# 🏨 Sistema de Hospedagem Hoteleira

Um sistema completo para gerenciamento de reservas hoteleiras desenvolvido em C# como parte da Trilha .NET da DIO.

## 📋 Sobre o Projeto

Este projeto implementa um sistema de hospedagem que permite realizar reservas em um hotel, calculando valores automaticamente e aplicando descontos conforme as regras de negócio estabelecidas.

## 🛠️ Tecnologias Utilizadas

- **C# 12**
- **.NET 9.0**
- **Console Application**
- **Programação Orientada a Objetos (POO)**

## 🎯 Funcionalidades

### ✅ Sistema de Reservas
- Cadastro de hóspedes com validação
- Criação de suítes com capacidade definida
- Reservas com cálculo automático de valores
- Interface de menu interativa

### ✅ Regras de Negócio
- **Validação de Capacidade**: Impede reservas que excedam a capacidade da suíte
- **Cálculo Automático**: Valor total = Dias × Valor da diária
- **Desconto Progressivo**: 10% de desconto para reservas ≥ 10 dias
- **Tratamento de Exceções**: Validação de entradas

## 🏗️ Arquitetura do Sistema

```
📦 DesafioProjetoHospedagem
 ┣ 📂 Models
 ┃ ┣ 📄 Pessoa.cs      # Classe representando hóspedes
 ┃ ┣ 📄 Suite.cs       # Classe representando suítes do hotel
 ┃ ┗ 📄 Reserva.cs     # Classe para gerenciar reservas
 ┗ 📄 Program.cs       # Interface do usuário e menu principal
```

### 🔧 Classes Principais

![Diagrama de classe estacionamento](diagrama_classe_hotel.png)

## 🚀 Como Executar

### Pré-requisitos
- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)

### Execução
1. Clone o repositório:
```bash
git clone https://github.com/lehrissio/trilha-net-explorando-desafio
cd trilha-net-explorando-desafio
```

2. Execute o projeto:
```bash
dotnet run
```

## 💻 Como Usar

### Menu Principal
```
═══════════════════════════════════════
     SISTEMA DE HOSPEDAGEM HOTELEIRA    
═══════════════════════════════════════

1 - Criar Reserva
0 - Sair

Escolha uma opção:
```

### Criando uma Reserva
1. Informe a quantidade de hóspedes
2. Digite o nome de cada hóspede
3. Informe a quantidade de dias
4. O sistema calculará automaticamente o valor total

### Exemplo de Uso
```
Quantos hóspedes? 2
Nome do hóspede 1: João
Sobrenome do hóspede 1: Silva
Nome do hóspede 2: Maria
Sobrenome do hóspede 2: Santos
Quantos dias de hospedagem? 15

═══ RESERVA CRIADA COM SUCESSO ═══
Hóspedes: 2

Lista de hóspedes:
• João Silva
• Maria Santos

Dias: 15
Valor total: R$ 405,00
* Desconto de 10% aplicado!
```

## 📊 Regras de Negócio

### 🔒 Validações Implementadas
- **Capacidade da Suíte**: Máximo 2 hóspedes por padrão
- **Nomes Obrigatórios**: Todos os hóspedes devem ter nome
- **Dias Válidos**: Quantidade de dias deve ser > 0
- **Entrada Numérica**: Validação de tipos de dados

### 💰 Cálculo de Valores
```
Valor Base = Dias × Valor da Diária (R$ 30,00)
Desconto = 10% (se dias ≥ 10)
Valor Final = Valor Base - Desconto
```

## 👨‍💻 Desenvolvedor

Desenvolvido como parte do desafio da **Trilha .NET** da [DIO](https://www.dio.me).

---

## 📄 Licença

Este projeto está sob a licença MIT.

---

⭐ **Gostou do projeto? Deixe uma estrela!** ⭐
