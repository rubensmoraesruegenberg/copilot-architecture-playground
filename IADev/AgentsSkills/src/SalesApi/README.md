# Copilot Architecture Playground

Projeto de estudo focado em especialização do GitHub Copilot utilizando Agents, Skills e Context Engineering dentro do Visual Studio Code.

## Objetivo

Explorar como o GitHub Copilot pode ser contextualizado para atuar como um especialista técnico em:

- Clean Architecture
- SOLID
- Design Patterns
- Code Review
- Boas práticas de desenvolvimento .NET

O projeto demonstra como instruções, agents e skills podem influenciar o comportamento da IA durante geração, revisão e refatoração de código.

---

# Estrutura do Projeto

```txt
.github/copilot/
│
├── instructions.md
│
├── agents/
│   ├── architecture-agent.md
│   ├── solid-agent.md
│   └── review-agent.md
│
└── skills/
    ├── clean-architecture-skill.md
    ├── solid-skill.md
    └── design-patterns-skill.md
```

---

# Conceitos Explorados

## Agents vs Skills vs Instructions

| Conceito | Propósito | Escopo | Uso |
|----------|-----------|--------|-----|
| **Instructions** | Regras gerais que guiam o comportamento do Copilot em toda a workspace | Global | Define como o Copilot deve se comportar em geral |
| **Agents** | Personas especializadas para tarefas específicas | Contextual | Invoke quando precisa de expertise em um domínio |
| **Skills** | Conhecimentos reutilizáveis que agents usam | Modular | Aplicam validações e boas práticas específicas |

**Em resumo:**
- `instructions.md`: "Como você deve se comportar sempre"
- `agents/*.md`: "Você é um especialista em X, faça isso"
- `skills/*.md`: "Use essa validação/conhecimento específico"

---

## Agents

Os agents representam personas especializadas responsáveis por orientar o comportamento do Copilot.

### Exemplos

- Architecture Agent
- SOLID Agent
- Review Agent

### Responsabilidades

- revisar arquitetura
- validar separação de camadas
- detectar acoplamento
- sugerir melhorias
- revisar handlers e controllers

---

## Skills

As skills representam conhecimentos especializados reutilizáveis utilizados pelos agents.

### Exemplos

- Clean Architecture Skill
- SOLID Skill
- Design Patterns Skill

### Responsabilidades

- validar princípios arquiteturais
- identificar code smells
- sugerir padrões de projeto
- validar boas práticas
- detectar violações arquiteturais

---

# Cenário do Estudo

Foi criada propositalmente uma API contendo violações arquiteturais para validar o comportamento dos agents e skills configurados no GitHub Copilot.

O objetivo foi analisar como o Copilot reage quando contextualizado com regras arquiteturais específicas.

Durante o estudo o Copilot foi utilizado para:

- revisar código
- identificar violações arquiteturais
- sugerir refatorações
- reorganizar responsabilidades
- aplicar boas práticas
- melhorar separação de camadas

---

# Exemplo de Violação Arquitetural

O projeto contém exemplos propositalmente criados com violações de:

- SOLID
- Clean Architecture
- separação de responsabilidades
- baixo acoplamento
- Dependency Injection

## Exemplo Inicial

```csharp
public class ProductController : ControllerBase
{
    [HttpPost]
    public IActionResult Create(Product product)
    {
        var connection = new SqlConnection();

        if(product.Price > 100)
        {
            Console.WriteLine("Preço alto");
        }

        return Ok();
    }
}
```

---

# Problemas Detectados

Os agents e skills identificaram:

- regra de negócio dentro do controller
- acesso direto à infraestrutura
- violação de SRP
- alto acoplamento
- ausência de abstrações
- violação de Clean Architecture
- ausência de Dependency Injection

---

# Resultado Esperado Após Refatoração

Após utilização dos agents e skills:

- separação de responsabilidades
- uso de services
- uso de interfaces
- inversão de dependência
- controller fino
- regras movidas para domínio/aplicação
- melhoria de manutenibilidade
- redução de acoplamento

---

# Exemplos de Uso no Copilot Chat

## Revisão arquitetural

```txt
@workspace revise esse controller usando o architecture-agent
```

## Revisão SOLID

```txt
Analise esse código usando o solid-agent
```

## Aplicando skills

```txt
Use clean-architecture-skill para revisar esse código
```

## Revisão completa

```txt
Revise esse código considerando:
- Clean Architecture
- SOLID
- Design Patterns
```

---

# Tecnologias

- .NET
- ASP.NET Core
- Visual Studio Code
- GitHub Copilot
- Markdown
- Context Engineering

---

# Objetivos de Aprendizado

- Agent Engineering
- Prompt Engineering
- Context Engineering
- Especialização de IA
- Revisão arquitetural assistida por IA
- Engenharia de prompts para desenvolvimento
- Organização de conhecimento para IA

---

# Próximos Passos

- Adicionar MCP Tools
- Integrar análise automática
- Criar revisão automatizada em Pull Requests
- Adicionar validações arquiteturais automatizadas
- Integrar CI/CD com IA
- Criar agents especializados por domínio

---

# Observações

Este projeto possui objetivo educacional e experimental, focado no estudo de especialização de IA aplicada à engenharia de software utilizando GitHub Copilot.