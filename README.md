# Oficina de Manutenção de Veículos - Sistema de Gestão

Este repositório contém o código-fonte de um sistema básico desenvolvido para automatizar e digitalizar alguns processos de uma oficina de manutenção de veículos. O sistema foi criado como parte de um desafio técnico durante um processo seletivo e inclui funcionalidades para gerenciar orçamentos, peças e movimentação de estoque.

## Tecnologia Utilizada:

- **Entity Framework:** Utilizado como ORM (Object-Relational Mapping) para facilitar a interação com o banco de dados PostgreSQL.
- **PostgreSQL:** Banco de dados utilizado para armazenar informações sobre orçamentos, peças e movimentação de estoque.
- **Metodologia Code-First:** Utilizada para definir o modelo de banco de dados por meio do código, facilitando a manutenção e a evolução do sistema.
- **Injeção de Dependência:** Prática adotada para aumentar a modularidade e a testabilidade do código.
- **ASP.NET Core 8.0:** Utilizado para desenvolver a API backend do sistema.

## Desafios e Aprendizados:
  
- **Modelagem de Dados:** Um dos desafios foi projetar e implementar corretamente a estrutura do banco de dados para atender aos requisitos do sistema. Aprendi a importância de uma modelagem de dados eficaz para garantir a integridade e a eficiência do sistema, além de facilitar futuras expansões e manutenções.

- **Injeção de Dependências:** A prática de injeção de dependências foi fundamental para promover a modularidade e a testabilidade do código. Aprendi a organizar melhor minhas classes e a facilitar a substituição de implementações em diferentes ambientes, como em testes unitários.

## Diagrama de Relacionamento de Entidade:

![DRE](https://github.com/GBResende/ultraCarApi/assets/93008823/9e616f47-d913-487b-8f15-dd9c0339251e)


Este projeto me proporcionou uma valiosa oportunidade de aplicar meus conhecimentos em um cenário real, enfrentando desafios e aprendendo novas técnicas e práticas de desenvolvimento de software. Estou comprometido em continuar aprimorando este sistema e buscando constantemente formas de melhorar sua eficiência e usabilidade. Qualquer feedback ou contribuição será muito bem-vinda!
