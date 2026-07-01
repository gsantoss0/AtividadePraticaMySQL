# Atividades Práticas - Windows Forms & MySQL

[cite_start]Este repositório contém os projetos desenvolvidos para as atividades práticas de programação de aplicativos[cite: 193, 194, 195].

##  Sistemas Desenvolvidos

### 1. Sistema de Cadastro de Clientes com Login (Atividade Prática 01)
* [cite_start]**Objetivo:** Controlar o acesso e o cadastro de clientes de uma pequena empresa[cite: 219].
* [cite_start]**Fluxo:** O funcionário realiza um cadastro inicial de conta no sistema [cite: 220][cite_start], faz o login com suas credenciais [cite: 220] [cite_start]e, após a validação bem-sucedida, ganha acesso à tela principal para gerenciar e cadastrar novos clientes (nome, telefone, e-mail, endereço e observações)[cite: 221, 240].

### 2. Sistema de Registro de Chamados de TI (Atividade Prática 02)
* [cite_start]**Objetivo:** Simular um sistema de suporte técnico corporativo para o controle básico de manutenção de equipamentos[cite: 288, 290].
* [cite_start]**Fluxo:** Permite o cadastro e login de usuários[cite: 289]. [cite_start]Após autenticado, o atendente pode registrar novos chamados de TI informando o solicitante, o equipamento com defeito, a descrição do problema e o nível de prioridade (Baixa, Média, Alta ou Urgente)[cite: 289, 304, 309].

---

##  Pré-requisitos

Para que os aplicativos consigam se conectar com o banco de dados e funcionar corretamente, é necessário configurar o ambiente local:

1. **Ativar o XAMPP:**
   * [cite_start]Abra o painel de controle do **XAMPP**.
   * [cite_start]Inicie o serviço do **MySQL** antes de executar o programa.

2. **Configuração de Porta:**
   * **Importante:** É necessário que o Apache/XAMPP esteja configurado e rodando na **porta 8080**.

3. **Banco de Dados:**
   * [cite_start]Certifique-se de importar e executar os scripts SQL inclusos (`script_sistema_clientes.sql` e `script_sistema_chamados.sql`) no seu MySQL Workbench para criar os schemas e tabelas antes de testar a aplicação[cite: 245, 246, 315, 316].

---

##  Tecnologias Utilizadas
* [cite_start]C# (.NET Framework 4.8) [cite: 211, 262]
* [cite_start]Windows Forms (SharpDevelop) [cite: 211, 222]
* [cite_start]Banco de Dados MySQL (via XAMPP) [cite: 208, 222]
* [cite_start]Driver de Conexão `MySql.Data.dll` [cite: 212]
