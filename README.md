# Estrutura do Projeto <br>
   
   #Application# <br>
      É a camada responsável por receber o pedido do controller e realizar tratativas em cima dos dados passados.<br>
      *CQRS<br>
        -> Pasta responsável por simular o conceito de separação lógica entre commandos e consultas, onde ficarão os handlers para realizar o calculo.<br>
      *DTO<br>
        -> Pasta onde foram criados os objetos de transferência de dados.<br>
      *IoC<br>
       -> Pasta onde foi configurado a inversão de controle referente a camada de application.<br>
  
  #Presentation#<br>
    É a camada onde estão os controllers que receberão as requisições e serão responsáveis por delegar para a camada de application realizar os próximos passos.<br>
      *Controllers <br>
       -> Pasta onde fica os controllers que delegarão as requisições para os handlers que estão na camada de application.
      
  Obs.: Foi utilizado a biblioteca MediatR para simular o conceito do Design Pattern Mediator entre o controller e os handlers da camada de application
       
#Rodando o projeto - Passo a Passo# <br>
  Após baixar o projeto abrir a aba Gerenciador de Soluções, expandir a pasta Presentation e clicar com o botão direito em cima do projeto Dividers.Presentation.WebAPI
  e clicar na opção Definir como projeto de Inicialização, após ter feito isso pode apertar o botão F5 e o projeto será iniciado.
  Para testar: caso não seja iniciado no Swagger favor acessar a URL https://localhost:44393/swagger, após iniciar logo será visto a aba Dividers clicando na Subaba /api/Dividers
  que é referente ao verbo HTTP post, aparecerá o botão "try it out" que habilitará os botões para acrescentar o valor no json e assim executar e logo abaixo aparecerá o resultado do calculo.
  
 Caso queira utilizar o frontend para testar, baixe o projeto frontend no link e siga os passos do README para rodar o mesmo.
 https://github.com/viniciusjsantanna/Dividers-frontend
