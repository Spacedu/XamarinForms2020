using AppShopping.Models;
using System;
using System.Collections.Generic;
using System.Text;
using AppShopping.Libraries.Enums;

namespace AppShopping.Services
{
    public class EstablishmentService
    {
        public List<Establishment> GetEstablishments()
        {
            var establishments = new List<Establishment>()
            {
                new Establishment()
                {
                    Id = 1,
                    Type = EstablishmentType.Store,
                    Logo = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/122012/renner_0.png?itok=VvGKSsDe",
                    Name = "Renner",
                    Description = "A Lojas Renner S.A. é uma rede de lojas de departamento brasileira.",
                    Address = "2 Andar - Loja 10/11/12/13/14 - Entrada Norte",
                    Phone = "(61) 3333-3333",
                },
                new Establishment()
                {
                    Id = 2,
                    Type = EstablishmentType.Store,
                    Logo = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/052012/samsung.png?itok=Mq0egkoi",
                    Name = "Samsung",
                    Description = "Agora, você tem mais uma opção para experimentar e conhecer os produtos Samsung, antes de tomar a sua decisão de compra. Isso porque, nas Lojas Samsung, você pode manusear celulares, tablets, câmeras, smartphones e notebooks livremente, e ainda conta com consultoria e atendimento de vendedores especializados. A experiência de compra de equipamentos tecnológicos deixa de ser impessoal e ganha um caráter mais assertivo e direcionado ao seu verdadeiro desejo.",
                    Address = "2 Andar - Loja 01/02 - Entrada Norte",
                    Phone = "(61) 3475-2650",
                },
                new Establishment()
                {
                    Id = 3,
                    Type = EstablishmentType.Store,
                    Logo = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/052016/logo_chilli_beans_1c.png?itok=w_B1Ywks",
                    Name = "Chilli Beans",
                    Description = "A maior rede brasileira de óculos escuros e acessórios”. Essa definição resume a Chilli Beans: provocativa, ardente e envolvente. É a marca da pimenta. Uma marca que, toda semana, lança novos óculos, novos relógios e novas possibilidades. Ou seja, novas formas de compor seu visual. Com mais de 580 pontos de venda exclusivos no Brasil, Estados Unidos, Portugal, Peru, Colômbia e Kuwait, a Chilli Beans é uma marca diversificada, com uma linha de produtos que inclui, além dos óculos escuros e relógios, armações de óculos de grau e lentes em pontos de vendas exclusivos. Além disso, a marca está por trás de um mundo de ações de patrocínio de festas, shows, esportes e ações sociais",
                    Address = "2 Andar - Loja 03 - Entrada Norte",
                    Phone = "(61) 3475-2744",
                },
                new Establishment()
                {
                    Id = 4,
                    Type = EstablishmentType.Store,
                    Logo = "https://th.bing.com/th/id/OIP.Iyszwlgme5PIaZiSCzshiwAAAA?pid=Api&rs=1",
                    Name = "POLYÉLLE",
                    Description = "Em 1984, iniciou-se a trajetória da Polyelle no segmento de calçados. Depois de um tempo, esse segmento foi ampliado também para bolsas, cintos, carteiras e artigos esportivos e hoje, conta com mais de duzentos fornecedores de marcas nacionais e internacionais. A empresa foi estruturada para inovar por meio de pesquisas de consumidores e concorrentes, sempre preocupada em oferecer a melhor seleção das tendências mundiais a preços acessíveis.",
                    Address = "2 Andar - Loja 04/05/06 - Entrada Norte",
                    Phone = "(61) 3313-7843",
                },
                new Establishment()
                {
                    Id = 5,
                    Type = EstablishmentType.Store,
                    Logo = "https://static.pelando.com.br/live/merchants/avatar_web_square_94_2x/avatar/275_3.jpg",
                    Name = "LOJAS AMERICANAS",
                    Description = "Aqui você encontra de tudo um pouco: De eletrodomésticos a artigos de vestuário feminino, masculino e infantil.",
                    Address = "2 Andar - Loja 07/08/09 - Entrada Norte",
                    Phone = "-",
                },
                new Establishment()
                {
                    Id = 6,
                    Type = EstablishmentType.Store,
                    Logo = "https://mundodasdicas.com.br/wp-content/uploads/2021/06/hering-loja-virtual.jpg",
                    Name = "HERING STORE",
                    Description = "A Hering Store é uma loja de roupas femininas e masculinas que atende ao público adulto.",
                    Address = "2 Andar - Loja 10/11 - Entrada Norte",
                    Phone = "(61) 3973-3352",
                },
                new Establishment()
                {
                    Id = 7,
                    Type = EstablishmentType.Store,
                    Logo = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/032013/boticario_0.jpg?itok=bEHTxK_c",
                    Name = "O BOTICÁRIO",
                    Description = "O Boticário é uma loja de cosméticos em geral que oferece produtos para pele, cabelo, esmaltes, maquiagem e perfumaria.",
                    Address = "1 Andar - Loja 20/21 - Entrada Sul",
                    Phone = "(61) 3475-2646",
                },
                new Establishment()
                {
                    Id = 8,
                    Type = EstablishmentType.Store,
                    Logo = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/0004/0708/brand.gif?itok=prfpF4FG",
                    Name = "C&A",
                    Description = "Compre Roupas Femininas, Masculinas e Infantis, Eletrônicos, Cosméticos e Perfumaria na Loja Online da C&A. Entrega Rápida, Troca Fácil e muito + Vem ver! C&A Loja Online - Moda, Roupas, Celulares e …",
                    Address = "1 Andar - Loja 22/23 - Entrada Sul",
                    Phone = "(61) 2191-8845",
                },
                new Establishment()
                {
                    Id = 9,
                    Type = EstablishmentType.Store,
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Logo_OI.svg/100px-Logo_OI.svg.png",
                    Name = "OI",
                    Description = "A Oi é uma loja que representa a operadora de telefonia de mesmo nome. A Loja Oi presta assistência, auxilia o consumidor a respeito de novos planos e vende celulares/smartphones.",
                    Address = "1 Andar - Loja 22/23 - Entrada Sul",
                    Phone = "(61) 3475-2689",
                },
                new Establishment()
                {
                    Id = 10,
                    Type = EstablishmentType.Store,
                    Logo = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/092011/claro_2_1.jpg?itok=EYXF3uUg",
                    Name = "CLARO",
                    Description = "A Claro é uma loja de telefonia que vende aparelhos e presta assistência a clientes da operadora de mesmo nome.",
                    Address = "1 Andar - Loja 24/25 - Entrada Sul",
                    Phone = "**",
                },
                new Establishment()
                {
                    Id = 11,
                    Type = EstablishmentType.Store,
                    Logo = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/032017/untitled-2_42.png?itok=a0FktvOz",
                    Name = "CVC VIAGENS",
                    Description = "Compre suas passagens aéreas com pacotes completos na CVC do JK Shopping.  Sempre com os melhores preços e promoções para você viajar o mundo todo.",
                    Address = "1 Andar - Loja 26/27 - Entrada Sul",
                    Phone = "**",
                },
                new Establishment()
                {
                    Id = 12,
                    Type = EstablishmentType.Store,
                    Logo = "https://botw-pd.s3.amazonaws.com/styles/logo-thumbnail/s3/0022/2333/brand.gif?itok=m1Wcro5R",
                    Name = "POLISHOP",
                    Description = "Na Polishop você encontra Soluções Inteligentes para sua Casa, Saúde e Beleza. Produtos exclusivos e novidades que facilitam sua vida.",
                    Address = "1 Andar - Loja 28/29 - Entrada Sul",
                    Phone = "**",
                },
                new Establishment()
                {
                    Id = 13,
                    Type = EstablishmentType.Store,
                    Logo = "https://vagasabertas.org/wp-content/uploads/2012/03/Vagas-de-Emprego-na-empresa-Fujioka.jpg",
                    Name = "FUJIOKA",
                    Description = "O Fujioka é uma loja de eletrônicos e informática que oferece, ainda, produtos de áudio, vídeo, telefonia e serviços fotográficos.",
                    Address = "1 Andar - Loja 30/31 - Entrada Sul",
                    Phone = "(61) 3471-8600",
                },
                new Establishment()
                {
                    Id = 14,
                    Type = EstablishmentType.Store,
                    Logo = "https://th.bing.com/th/id/OIP._7UmPQ-CwGjuohFLU4qm6AAAAA?pid=Api&rs=1",
                    Name = "QUEM DISSE, BERENICE?",
                    Description = "A Quem disse, Berenice? é uma loja de maquiagens e cosméticos que tem uma proposta jovial e alegre que veio para quebrar padrões.",
                    Address = "1 Andar - Loja 34 - Entrada Sul",
                    Phone = "(61) 3475-2419",
                },
                new Establishment()
                {
                    Id = 15,
                    Type = EstablishmentType.Store,
                    Logo = "https://scontent.fbsb16-1.fna.fbcdn.net/v/t1.0-1/cp0/p40x40/32530741_1756089587820698_2942969221090377728_o.png?_nc_cat=103&ccb=2&_nc_sid=dbb9e7&_nc_ohc=-6Rj2o-DEEYAX8klDV3&_nc_ht=scontent.fbsb16-1.fna&_nc_tp=30&oh=8e62d997241361eca89cd00ee4cff32d&oe=6008EA19",
                    Name = "PARIS JÓIAS",
                    Description = "A Paris Jóias é uma loja de jóias e semi jóias que atrai pelo glamour e design das peças.",
                    Address = "1 Andar - Loja 35 - Entrada Sul",
                    Phone = "**",
                },
                new Establishment()
                {
                    Id = 16,
                    Type = EstablishmentType.Store,
                    Logo = "https://scontent.fbsb16-1.fna.fbcdn.net/v/t1.0-9/73057735_2792663367412106_2803336995324035072_n.png?_nc_cat=109&ccb=2&_nc_sid=09cbfe&_nc_ohc=eWlalGifPSUAX-fNdXh&_nc_ht=scontent.fbsb16-1.fna&oh=6bb8b45e83b5d8b4c4ac866e4f4461b1&oe=6008A509",
                    Name = "COOL CAT",
                    Description = "A Cool Cat é uma loja de roupas casuais para homens e mulheres, com foco na moda surfware e streetware.",
                    Address = "1 Andar - Loja 36 - Entrada Sul",
                    Phone = "61 3491-2407",
                },
                new Establishment()
                {
                    Id = 17,
                    Type = EstablishmentType.Store,
                    Logo = "https://bazarpop.files.wordpress.com/2008/06/logo_tng.gif",
                    Name = "TNG",
                    Description = "Com DNA jovem a TNG lança tendências com estilo e autenticidade. Conheça as coleções masculinas e femininas. Aproveite o melhor da moda. Confira!",
                    Address = "1 Andar - Loja 37 - Entrada Sul",
                    Phone = "(11) 4689-7375",
                },
                new Establishment()
                {
                    Id = 18,
                    Type = EstablishmentType.Store,
                    Logo = "https://th.bing.com/th/id/OIP.8Apu8unhr4A8enO5vgxF6gHaHa?pid=Api&rs=1",
                    Name = "PITICAS",
                    Description = "Piticas: Ano de Fundação: 2010: Inicio do Franchising: 2011: Unidades Franqueadas: 340: Comunicado Franchise Store: Os dados e conteúdos informados foram fornecidos exclusivamente pela Franqueadora. ",
                    Address = "1 Andar - Loja 38 - Entrada Sul",
                    Phone = "(61) 3053-8009",
                },
                new Establishment()
                {
                    Id = 19,
                    Type = EstablishmentType.Store,
                    Logo = "https://www.lojabiomundo.com.br/FILES/_ARQUIVOS/LOGO/logo.png",
                    Name = "BIO MUNDO",
                    Description = "Bio Mundo é a loja de produtos naturais que vem promovendo saúde e bem estar à vida das pessoas desde 2015, quando suas portas foram abertas pela primeira vez, em Brasília.",
                    Address = "1 Andar - Loja 39 - Entrada Sul",
                    Phone = "(61) 3475-2789",
                },
                new Establishment()
                {
                    Id = 20,
                    Type = EstablishmentType.Store,
                    Logo = "https://www.cupomvalido.com.br/logo/www.zinzane.com.br.png.pagespeed.ce.cTfK8gTDeL.png",
                    Name = "ZINZANE",
                    Description = "Zinzane é uma marca de moda feminina que nasceu em 2002, no Rio de Janeiro, na charmosa Babilônia Feira Hype. Atualmente, possuímos 113 lojas físicas próprias e estamos presentes em 19 estados brasileiros, além da forte atuação no canal digital, através da nossa loja online, com o objetivo de levar as últimas tendências para todo o Brasil. Lançamos semanalmente novos produtos exclusivos e nossa missão é encantar o cliente, ofertando o melhor produto, com o melhor custo benefício. Nossas estampas exclusivas são o carro-chefe da marca, vistas em produtos de variados estilos e modelagens. Aqui, você encontra o look perfeito para estar no seu guarda-roupa.",
                    Address = "1 Andar - Loja 39 - Entrada Sul",
                    Phone = "(61) 3475-2789",
                },

                new Establishment()
                {
                    Id = 21,
                    Type = EstablishmentType.Restaurant,
                    Logo = "https://botw-pd.s3.amazonaws.com/styles/logo-thumbnail/s3/102014/logo_outback.png?itok=dKkkYi4q",
                    Name = "OUTBACK",
                    Description = "Outback Steakhouse",
                    Address = "3 Andar - Loja 01/02/03/04 - Entrada Sul",
                    Phone = "(61) 3550-1874",
                },
                new Establishment()
                {
                    Id = 22,
                    Type = EstablishmentType.Restaurant,
                    Logo = "https://th.bing.com/th/id/OIP.rkuaDq-syjT-EZdhuQ6GfgHaGU?pid=Api&rs=1",
                    Name = "GIRAFFAS",
                    Description = "O Giraffas é uma rede de restaurantes de culinária brasileira que serve seus pratos de forma saborosa e criativa.",
                    Address = "3 Andar - Loja 05/06/07 - Entrada Sul",
                    Phone = "(61) 3550-1874",
                },
                new Establishment()
                {
                    Id = 23,
                    Type = EstablishmentType.Restaurant,
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/50/McDonald%27s_SVG_logo.svg/120px-McDonald%27s_SVG_logo.svg.png",
                    Name = "MC DONALD’S",
                    Description = "Quiosque de sorvetes e milk shakes do Mc Donald’s.",
                    Address = "3 Andar - Loja 08/09/10/11 - Entrada Sul",
                    Phone = "(61) 3550-1874",
                },
                new Establishment()
                {
                    Id = 24,
                    Type = EstablishmentType.Restaurant,
                    Logo = "https://cdn4.bobsfa.com.br/bobs/images/logo_bobs.png",
                    Name = "BOB’S",
                    Description = "O Bob’s é uma rede de restaurantes fast-food que busca atender às expectativas do consumidor através de um produto de qualidade e uma equipe sempre motivada.",
                    Address = "3 Andar - Loja 13/14 - Entrada Sul",
                    Phone = "(61) 3491-1031",
                },
                new Establishment()
                {
                    Id = 25,
                    Type = EstablishmentType.Restaurant,
                    Logo = "https://farm5.staticflickr.com/4045/4704236172_e6e6eebf39_q_d.jpg",
                    Name = "BURGER KING",
                    Description = "O BURGER KING® é a segunda maior rede de hambúrgueres do mundo. Lar original do WHOPPER®, um dos mais pedidos da franquia.",
                    Address = "3 Andar - Loja 15/16 - Entrada Sul",
                    Phone = "**",
                },
                new Establishment()
                {
                    Id = 26,
                    Type = EstablishmentType.Restaurant,
                    Logo = "https://3.bp.blogspot.com/-sXotIRuVUp4/T2tI3C89l8I/AAAAAAAAAHE/qcowULZfBWs/s950/Logo%2Bblog.jpg",
                    Name = "CHOCOLATES BRASIL CACAU",
                    Description = "A Brasil Cacau é uma bomboniére que oferece produtos diversificados para agradar a todos os tipos de amantes do chocolate.",
                    Address = "3 Andar - Loja 17/18 - Entrada Sul",
                    Phone = "(61) 3491-2255",
                },
                new Establishment()
                {
                    Id = 27,
                    Type = EstablishmentType.Restaurant,
                    Logo = "https://th.bing.com/th/id/OIP.bu6ExCsGqSc1mE3-76gLWAAAAA?pid=Api&rs=1",
                    Name = "CACAU SHOW",
                    Description = "A Cacau Show é uma loja de chocolates conhecida nacionalmente que oferece produtos variados da área de bomboniére.",
                    Address = "3 Andar - Loja 19 - Entrada Sul",
                    Phone = "(61) 3475-2779",
                },
                new Establishment()
                {
                    Id = 28,
                    Type = EstablishmentType.Restaurant,
                    Logo = "https://th.bing.com/th/id/OIP.CovkvJKc9p-mUagzdJjYVgAAAA?pid=Api&rs=1",
                    Name = "DIVINO FOGÃO",
                    Description = "O Divino Fogão é um restaurante que oferece comida típica da fazenda num cardápio saboroso e variado.",
                    Address = "3 Andar - Loja 20 - Entrada Sul",
                    Phone = "(61) 3491-1124",
                },
                new Establishment()
                {
                    Id = 29,
                    Type = EstablishmentType.Restaurant,
                    Logo = "https://www.feiradefranquias.com.br/wp-content/uploads/2017/02/Frango-no-Pote.png",
                    Name = "FRANGO NO POTE",
                    Description = "O Frango no Pote é uma rede que não para de crescer. Oferece porções de frango, refrigerantes e lanches.",
                    Address = "3 Andar - Loja 21 - Entrada Sul",
                    Phone = "(61) 3475-2786",
                },
                new Establishment()
                {
                    Id = 30,
                    Type = EstablishmentType.Restaurant,
                    Logo = "https://upload.wikimedia.org/wikipedia/pt/thumb/8/80/Spoleto_logo.png/120px-Spoleto_logo.png",
                    Name = "SPOLETO",
                    Description = "O Spoleto é um restaurante italiano que visa valorizar as relações, manter a qualidade nos produtos e serviços e aprimorar e inovar cada vez mais com foco nas pessoas e respeito à concorrência.",
                    Address = "3 Andar - Loja 22 - Entrada Sul",
                    Phone = "(61) 3491-1031",
                },
            };

            return establishments;
        }
    }
}
