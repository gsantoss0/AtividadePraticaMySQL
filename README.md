# Atividades Práticas - Windows Forms & MySQL

Este repositório contém os projetos desenvolvidos para as atividades práticas de programação de aplicativos.

##  Sistemas Desenvolvidos

### 1. Sistema de Cadastro de Clientes com Login (Atividade Prática 01)
* **Objetivo:** Controlar o acesso e o cadastro de clientes de uma empresa.
* **Fluxo:** O funcionário realiza um cadastro inicial de conta no sistema, faz o login com suas credenciais e, após a validação bem-sucedida, ganha acesso à tela principal para gerenciar e cadastrar novos clientes (nome, telefone, e-mail, endereço e observações).

### 2. Sistema de Registro de Chamados de TI (Atividade Prática 02)
* **Objetivo:** Simular um sistema de suporte técnico corporativo para o controle básico de manutenção de equipamentos.
* **Fluxo:** Permite o cadastro e login de usuários. Após autenticado, o atendente pode registrar novos chamados de TI informando o solicitante, o equipamento com defeito, a descrição do problema e o nível de prioridade (Baixa, Média, Alta ou Urgente).

---

##  Pré-requisitos

Para que os aplicativos consigam se conectar com o banco de dados e funcionar corretamente, é necessário configurar o ambiente local:

1. **Ativar o XAMPP:**
   * Abra o painel de controle do **XAMPP**.
   * Inicie o serviço do **MySQL** antes de executar o programa.

2. **Configuração de Porta:**
   * **Importante:** É necessário que o Apache/XAMPP esteja configurado e rodando na **porta 8080**.

3. **Banco de Dados:**
   * Certifique-se de importar e executar os scripts SQL inclusos (`script_sistema_clientes.sql` e `script_sistema_chamados.sql`) no seu MySQL Workbench para criar os schemas e tabelas antes de testar a aplicação.

---

##  Tecnologias Utilizadas
* C# (.NET Framework 4.8)
* Windows Forms (SharpDevelop)
* Banco de Dados MySQL (via XAMPP)
* Driver de Conexão `MySql.Data.dll`
