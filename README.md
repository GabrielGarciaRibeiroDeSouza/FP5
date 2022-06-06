# FP5 - Murango

<h1 align = "Center"> Sumário </h1>

1. <a href = "https://github.com/GabrielGarciaRibeiroDeSouza/FP5-Murango/blob/master/README.md#-high-concenpt-"> High Concenpt </a>

<p> 2. <a href = "https://github.com/GabrielGarciaRibeiroDeSouza/FP5-Murango/blob/master/README.md#gdd"> Game Design Document(GDD) </a> </p>
<p> 2.1.<a href = "https://github.com/GabrielGarciaRibeiroDeSouza/FP5-Murango/blob/master/README.md#scientific-colonization"> introdução </a></p>
<p> 2.2. <a href = "https://github.com/GabrielGarciaRibeiroDeSouza/FP5-Murango#hist%C3%B3ria" > História </a></p>
<p> 2.3. <a href = "https://github.com/GabrielGarciaRibeiroDeSouza/FP5-Murango#jogo" > Jogo </a></p>
<p> 2.4. <a href = "https://github.com/GabrielGarciaRibeiroDeSouza/FP5-Murango#controles" > Controles </a></p>
<p> 2.5. <a href = "https://github.com/GabrielGarciaRibeiroDeSouza/FP5-Murango#mundo-do-jogo" > Mundo do Jogo </a></p>
<p> 2.6. <a href = "https://github.com/GabrielGarciaRibeiroDeSouza/FP5-Murango#experi%C3%AAncia-de-jogo" > Experinêcia do jogo </a></p>
<p> 2.7. <a href = "https://github.com/GabrielGarciaRibeiroDeSouza/FP5-Murango#interfaces" > Interfaces </a></p>
<p> 2.8. <a href = "https://github.com/GabrielGarciaRibeiroDeSouza/FP5-Murango#mec%C3%A2nicas" > Mecânicas </a></p>
<p> 2.9. <a href = "https://github.com/GabrielGarciaRibeiroDeSouza/FP5-Murango#inimigos" > Inimigos </a></p>
<p> 2.10. <a href = "https://github.com/GabrielGarciaRibeiroDeSouza/FP5-Murango#intelig%C3%AAncia-artificial" > Inteligência Artificial </a></p>
<p> 2.11. <a href = "https://github.com/GabrielGarciaRibeiroDeSouza/FP5-Murango#cenas-de-cortes--material-b%C3%B4nus" > Cenas de Cortes e Material Bônus </a></p>

3. <a href = "" > Ficha técnica de classificação indicativa </a>
4. <a href = "" > </a>

<h1> High concenpt: </h1>

Nome do Jogo: Scientific Colonization.

Descrição: Defesa de torres ambientado em um planeta árido e com criaturas hostis querendo destruir a sua colônia.

Gênero: 3D, casual, defesa de torres e estratégia.

Mecânicas: Hordas de inimigos, barra de vida, ia das armas e inimigos.

História: A ciência alcançou a exploração espacial e agora é comum colonizar outros planetas, porém a maioria dos planetas colonizados tem vida hostil presente e a meta dos exploradores é neutralizar essa ameaça para alcançar o objetivo de colonização.

Diferencial: A inteligência artificial é livre, em outras palavras a I.A. não vai seguir um “caminho” pré definido como é o padrão de outros jogos do mesmo gênero.

sistema operacional: Windows.

Publicado em: Gamejolt e futuramente na Steam.

Público alvo: Fãs de jogos casuais e defesa de torre.

classificação indicativa: 14+

Equipe: Gabriel Garcia R. de Souza - Geral

Prévia de orçamento: R$ 8.368,00 - <a href = "[https://github.com/GabrielGarciaRibeiroDeSouza/FP5-Murango#-sum%C3%A1rio-](https://docs.google.com/spreadsheets/d/1Q9NGdTU_foMU_Tej16hM8t5JTHK7GBIpvedO_lfSRgk/edit#gid=0)"> Verificar a planilha com o orçamento </a>

Desenvolvimento: 4 meses.

Monetização: Jogo pago com valor de R$10.

<p><a href = "https://github.com/GabrielGarciaRibeiroDeSouza/FP5-Murango#-sum%C3%A1rio-"> Voltar para o Sumário </a></p>

<div align="center">
  <h1>GDD</h1>
    
  <h2>Scientific colonization</h2>
  <p>Plataforma pretendida: windows</p>
  <p>Público pretendido: fãs de defesa de torre e jogos casuais</p>
  <p>Classificação pretendida: 14+</p>
  <p>Data de Publicação: 25/05/2022 (Pré-Alpha)</p>
  <p>Documento versão: 2.3</p>

  <p><a href = "https://github.com/GabrielGarciaRibeiroDeSouza/FP5-Murango#-sum%C3%A1rio-"> Voltar para o Sumário </a></p>
  
</div>

<div >
  <h2 align="center">História</h2>
  A ciência alcançou a exploração espacial e agora é comum colonizar outros planetas, porém a maioria dos planetas colonizados tem vida hostil presente e a meta dos exploradores é neutralizar essa ameaça para alcançar o objetivo de colonização.
  <p><a href = "https://github.com/GabrielGarciaRibeiroDeSouza/FP5-Murango#-sum%C3%A1rio-"> Voltar para o Sumário </a></p>
    
  <h2 align="center">Jogo</h2>
   Após estabelecer uma colônia em um planeta os monstros irão a atacar sem medo, inicialmente uma horda de monstros fracos vai atacar, mas não os subestime pois seus números irão aumentar e não só em quantidade mas também em vida, força e velocidade.
  
   <p style="text-align:justify">A progressão da dificuldade vai ser baseado em criaturas com mais vida, força, velocidade e quantidade de monstros, chegando a um limite para não ficar impossível de vencer. Para o jogador superar essa dificuldade ele vai precisar comprar melhorias para as armas em campo de batalha ou comprar mais; a aquisição de novas habilidades e armas precisa de moedas que é nomeada como Syncoin.
     
   <p>As Syncoin são derrubadas em pequena quantidade de todos os monstros quando morre e ganha uma quantidade um pouco maior ao passar a onda.
   <p>Cada onda tem 1 horda de monstros, não muda o mapa, mas muda a direção em que eles iniciam o ataque.
   <p><a href = "https://github.com/GabrielGarciaRibeiroDeSouza/FP5-Murango#-sum%C3%A1rio-"> Voltar para o Sumário </a></p>

   <h2 align="center">Controles</h2>
   <p>Interagir com os elementos no game - botão esquerdo do mouse.</p>
   <p>cancelar ação - botão direito do mouse.</p>
   <p>pausa - esc.</p>
   <p><a href = "https://github.com/GabrielGarciaRibeiroDeSouza/FP5-Murango#-sum%C3%A1rio-"> Voltar para o Sumário </a></p>
  
   <h2 align="center">Mundo do jogo</h2>
   O jogador se envolve em um game de defesa de torres 3D com uma inteligência artificial livre, em outras palavras a I.A. não vai seguir um “caminho” pré definido como é o padrão de outros jogos do mesmo gênero. O clima do planeta é árido com rochas negras. A sequência do jogo é embasada em ondas de monstros, ao finalizar as ondas, o jogador tem a opção de chamar a próxima onda clicando em um botão “Pronto”.
   <p>Gênero: 3D, casual, defesa de torres, estratégia</p>
  <p><a href = "https://github.com/GabrielGarciaRibeiroDeSouza/FP5-Murango#-sum%C3%A1rio-"> Voltar para o Sumário </a></p>

   <h2 align="center">Experiência de jogo</h2>
   <p style="text-align:justify">A experiência do jogador é divida em 2 etapas, Planejar a defesa e iniciar o ataque, vale a pena ressaltar que as ondas não vem automaticamente, pois é mais conveniente que ela comece quando o jogador desejar. O mapa é pequeno para ter uma gameplay mais rápida.</p>
   <p></p>
   <p><a href = "https://github.com/GabrielGarciaRibeiroDeSouza/FP5-Murango#-sum%C3%A1rio-"> Voltar para o Sumário </a></p>
  
  <h2 align="center">Interfaces</h2>
  O clima nas interfaces é de sci-fi e futurista, a música estilo ambiente de espaço, sci-fi e instrumental. 
  <p><img src="https://github.com/GabrielGarciaRibeiroDeSouza/FP5-Murango/blob/master/Imagens-do-Projeto/fluxo%20de%20telas.png" style="width:600px;height:500px;"></p>
  <p><a href = "https://github.com/GabrielGarciaRibeiroDeSouza/FP5-Murango#-sum%C3%A1rio-"> Voltar para o Sumário </a></p>

  <h2 align="center">Mecânicas</h2>
  <li> barra de vida: os monstros/ Armas/ Colônia vão ter a barra de vida em cima da cabeça.</li>
  <li> instanciar inimigos:  os inimigos aparece na borda do mapa</li>
  <li> Armas: Comprar, posicionar e vender.</li>
  <li> coletáveis: terá apenas uma moeda que se chama “Syncoin”, essa moeda é usada para compra de armas e melhorias.</li>
  <p><a href = "https://github.com/GabrielGarciaRibeiroDeSouza/FP5-Murango#-sum%C3%A1rio-"> Voltar para o Sumário </a></p>
  
  <h2 align="center">Inimigos</h2>
  <p>Os inimigos fazem ataques em grupos sempre buscando o alvo mais próximo</p>
  <p>Minion Alien: Um inimigo pequeno e com pouco vida inicialmente, ele vai ganhando vida ao passar as hordas e o ataque é físico.</p>
  <p><a href = "https://github.com/GabrielGarciaRibeiroDeSouza/FP5-Murango#-sum%C3%A1rio-"> Voltar para o Sumário </a></p>

  <h2 align="center">Inteligência Artificial</h2>
  A inteligência artificial usada é a máquina de estado:
  <p></p>
  <img src="https://github.com/GabrielGarciaRibeiroDeSouza/FP5-Murango/blob/master/Imagens-do-Projeto/maquinaDeEstadoArma.png" style="width:600px;height:500px;">
  <img src="https://github.com/GabrielGarciaRibeiroDeSouza/FP5-Murango/blob/master/Imagens-do-Projeto/maquina%20de%20estado%20inimigo.png" style="width:600px;height:500px;">
  <p></p>
  <p><a href = "https://github.com/GabrielGarciaRibeiroDeSouza/FP5-Murango#-sum%C3%A1rio-"> Voltar para o Sumário </a></p>
  
  <h2 align="center">Cenas de cortes & Material bônus</h2>
  <p>será usado cenas do jogo para cenas de corte.</p>
  O período de suporte para o jogo vai ser de 5 meses, prevendo melhorias nas mecânicas, correção de bugs e adição de mecânicas para aumentar a qualidade geral e o alcance do público.
  <p><a href = "https://github.com/GabrielGarciaRibeiroDeSouza/FP5-Murango#-sum%C3%A1rio-"> Voltar para o Sumário </a></p>
</div>
