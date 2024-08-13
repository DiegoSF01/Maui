using MauiAppShowDoMilhao.Models;

namespace MauiAppShowdoMilhao
{
    public partial class App : Application
    {

        List<Pergunta> Perguntas_faceis = new()
        {
            new Pergunta
            {
                Id = 1,
                Enunciado = "Em que estado brasileiro nasceu a apresentadora Xuxa?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "RIO DE JANEIRO"},
                    new Alternativa {Correta = true, Descricao = "RIO GRANDE DO SUL"},
                    new Alternativa {Correta = false, Descricao = "SANTA CATARINA"},
                    new Alternativa {Correta = false, Descricao = "GOIÁS"},
                }
            },
            new Pergunta
            {
                Id = 2,
                Enunciado = "Qual é o nome dado ao estado da água em forma de gelo?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "LÍQUIDO"},
                    new Alternativa {Correta = true, Descricao = "SÓLIDO"},
                    new Alternativa {Correta = false, Descricao = "GASOSO"},
                    new Alternativa {Correta = false, Descricao = "VAPOROSO"},
                }
            },
            new Pergunta
            {
                Id = 3,
                Enunciado = "Qual era o apelido da cantora Elis Regina?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "GAUCHINHA"},
                    new Alternativa {Correta = false, Descricao = "PAULISTINHA"},
                    new Alternativa {Correta = true, Descricao = "PIMENTINHA"},
                    new Alternativa {Correta = false, Descricao = "ANDORINHA"},
                }
            },
            new Pergunta
            {
                Id = 4,
                Enunciado = "Quem é a namorada do Mickey?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "MARGARIDA"},
                    new Alternativa {Correta = true, Descricao = "MINNIE"},
                    new Alternativa {Correta = false, Descricao = "A PEQUENA SEREIA"},
                    new Alternativa {Correta = false, Descricao = "OLÍVIA PALITO"},
                }
            },
            new Pergunta
            {
                Id = 5,
                Enunciado = "Qual é o personagem do folclore brasileiro que tem uma perna só?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "CUCA"},
                    new Alternativa {Correta = false, Descricao = "NEGRINHO DO PASTOREIO"},
                    new Alternativa {Correta = false, Descricao = "BOITATÁ"},
                    new Alternativa {Correta = true, Descricao = "SACI-PERERÊ"},
                }
            },
            new Pergunta
            {
                Id = 6,
                Enunciado = "Fidel Castro nasceu em que país?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "JAMAICA"},
                    new Alternativa {Correta = true, Descricao = "CUBA"},
                    new Alternativa {Correta = false, Descricao = "EL SALVADOR"},
                    new Alternativa {Correta = false, Descricao = "MÉXICO"},
                }
            },
            new Pergunta
            {
                Id = 7,
                Enunciado = "Quem proclamou a república no Brasil em 1889?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "DUQUE DE CAXIAS"},
                    new Alternativa {Correta = false, Descricao = "MARECHAL RONDON"},
                    new Alternativa {Correta = false, Descricao = "DOM PEDRO II"},
                    new Alternativa {Correta = true, Descricao = "MARECHAL DEODORO"},
                }
            },
            new Pergunta
            {
                Id = 8,
                Enunciado = "Quem é o patrono do exército brasileiro?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "DUQUE DE CAXIAS"},
                    new Alternativa {Correta = false, Descricao = "MARECHAL DEODORO"},
                    new Alternativa {Correta = false, Descricao = "BARÃO DE MAUÁ"},
                    new Alternativa {Correta = false, Descricao = "MARQUÊS DE POMBAL"},
                }
            },
            new Pergunta
            {
                Id = 9,
                Enunciado = "Quem era o apresentador que reprovava os calouros tocando uma buzina?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "RAUL GIL"},
                    new Alternativa {Correta = false, Descricao = "BOLINHA"},
                    new Alternativa {Correta = false, Descricao = "FLÁVIO CAVALCANTI"},
                    new Alternativa {Correta = true, Descricao = "CHACRINHA"},
                }
            },
            new Pergunta
            {
                Id = 10,
                Enunciado = "O que era Frankenstein, de Mary Shelley?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "MONSTRO"},
                    new Alternativa {Correta = false, Descricao = "GORILA"},
                    new Alternativa {Correta = false, Descricao = "PRÍNCIPE"},
                    new Alternativa {Correta = false, Descricao = "SAPO"},
                }
            },
            new Pergunta
            {
                Id = 11,
                Enunciado = "Qual é o signo do zodíaco de quem nasce no dia do ano-novo?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "VIRGEM"},
                    new Alternativa {Correta = false, Descricao = "AQUÁRIO"},
                    new Alternativa {Correta = true, Descricao = "CAPRICÓRNIO"},
                    new Alternativa {Correta = false, Descricao = "ÁRIES"},
                }
            },
            new Pergunta
            {
                Id = 12,
                Enunciado = "Quem fundou a fábrica de automóveis Ford?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "HARRISON FORD"},
                    new Alternativa {Correta = false, Descricao = "GERALD FORD"},
                    new Alternativa {Correta = true, Descricao = "HENRY FORD"},
                    new Alternativa {Correta = false, Descricao = "ANNA FORD"},
                }
            },
            new Pergunta
            {
                Id = 13,
                Enunciado = "Qual é a cor que se associa com os grupos ecológicos?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "PRETA"},
                    new Alternativa {Correta = false, Descricao = "VERMELHA"},
                    new Alternativa {Correta = false, Descricao = "AZUL"},
                    new Alternativa {Correta = true, Descricao = "VERDE"},
                }
            },
            new Pergunta
            {
                Id = 14,
                Enunciado = "A água ferve a quantos graus centígrados?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "200"},
                    new Alternativa {Correta = true, Descricao = "100"},
                    new Alternativa {Correta = false, Descricao = "170"},
                    new Alternativa {Correta = false, Descricao = "220"},
                }
            },
            new Pergunta
            {
                Id = 15,
                Enunciado = "Quando é comemorado o dia da independência do Brasil?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "21 DE ABRIL"},
                    new Alternativa {Correta = false, Descricao = "12 DE OUTUBRO"},
                    new Alternativa {Correta = true, Descricao = "7 DE SETEMBRO"},
                    new Alternativa {Correta = false, Descricao = "25 DE DEZEMBRO"},
                }
            },
            new Pergunta
            {
                Id = 16,
                Enunciado = "Qual lugar é também chamado de Santa Sé?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "VENEZA"},
                    new Alternativa {Correta = false, Descricao = "VITÓRIA"},
                    new Alternativa {Correta = false, Descricao = "VANCOUVER"},
                    new Alternativa {Correta = true, Descricao = "VATICANO"},
                }
            },
            new Pergunta
            {
                Id = 17,
                Enunciado = "Quem tem por lema a frase: “Sempre alerta”?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "MÉDICOS"},
                    new Alternativa {Correta = true, Descricao = "ESCOTEIROS"},
                    new Alternativa {Correta = false, Descricao = "BOMBEIROS"},
                    new Alternativa {Correta = false, Descricao = "POLICIAIS"},
                }
            },
            new Pergunta
            {
                Id = 18,
                Enunciado = "Qual é a nacionalidade de Che Guevara?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "CUBANA"},
                    new Alternativa {Correta = true, Descricao = "ARGENTINA"},
                    new Alternativa {Correta = false, Descricao = "MEXICANA"},
                    new Alternativa {Correta = false, Descricao = "VENEZUELANA"},
                }
            },
            new Pergunta
            {
                Id = 19,
                Enunciado = "Quem fundou a Microsoft?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "STEVEN SPIELBERG"},
                    new Alternativa {Correta = false, Descricao = "BILL CLINTON"},
                    new Alternativa {Correta = true, Descricao = "BILL GATES"},
                    new Alternativa {Correta = false, Descricao = "STEVEN JOBS"},
                }
            },
            new Pergunta
            {
                Id = 20,
                Enunciado = "Onde vivia o Sultão Harun Al Rachid?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "DAMASCO"},
                    new Alternativa {Correta = true, Descricao = "BAGDÁ"},
                    new Alternativa {Correta = false, Descricao = "ISTAMBUL"},
                    new Alternativa {Correta = false, Descricao = "JERUSALÉM"},
                }
            },
        };

        List<Pergunta> Perguntas_medias = new()
        {
            new Pergunta
            {
                Id = 21,
                Enunciado = "Qual é o profissional que conduz o elevador?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "CONDUTOR"},
                    new Alternativa {Correta = false, Descricao = "OPERADOR"},
                    new Alternativa {Correta = true, Descricao = "ASCENSORISTA"},
                    new Alternativa {Correta = false, Descricao = "RECEPCIONISTA"},
                }
            },
            new Pergunta
            {
                Id = 22,
                Enunciado = "Segundo a Bíblia, quantos apóstolos tinha Jesus Cristo?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "DEZ"},
                    new Alternativa {Correta = false, Descricao = "ONZE"},
                    new Alternativa {Correta = true, Descricao = "DOZE"},
                    new Alternativa {Correta = false, Descricao = "TREZE"},
                }
            },
            new Pergunta
            {
                Id = 23,
                Enunciado = "Em qual país surgiu a máfia?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "ESTADOS UNIDOS"},
                    new Alternativa {Correta = false, Descricao = "INGLATERRA"},
                    new Alternativa {Correta = true, Descricao = "ITÁLIA"},
                    new Alternativa {Correta = false, Descricao = "ESPANHA"},
                }
            },
            new Pergunta
            {
                Id = 24,
                Enunciado = "Qual é o profissional que usa o estetoscópio?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "ENGENHEIRO"},
                    new Alternativa {Correta = false, Descricao = "MECÂNICO"},
                    new Alternativa {Correta = true, Descricao = "MÉDICO"},
                    new Alternativa {Correta = false, Descricao = "AVIADOR"},
                }
            },
            new Pergunta
            {
                Id = 25,
                Enunciado = "Fernando Henrique Cardoso é formado em que área?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "ADMINISTRAÇÃO"},
                    new Alternativa {Correta = true, Descricao = "SOCIOLOGIA"},
                    new Alternativa {Correta = false, Descricao = "DIREITO"},
                    new Alternativa {Correta = false, Descricao = "ECONOMIA"},
                }
            },
            new Pergunta
            {
                Id = 26,
                Enunciado = "Qual destes é considerado o mês das noivas?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "SETEMBRO"},
                    new Alternativa {Correta = true, Descricao = "MAIO"},
                    new Alternativa {Correta = false, Descricao = "OUTUBRO"},
                    new Alternativa {Correta = false, Descricao = "JUNHO"},
                }
            },
            new Pergunta
            {
                Id = 27,
                Enunciado = "Quem inventou o telefone?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "GRAHAM BELL"},
                    new Alternativa {Correta = false, Descricao = "GEORGE WASHINGTON"},
                    new Alternativa {Correta = false, Descricao = "THOMAS EDISON"},
                    new Alternativa {Correta = false, Descricao = "MARCONI"},
                }
            },
            new Pergunta
            {
                Id = 28,
                Enunciado = "Qual é o esporte praticado com pequenos aviões de controle remoto?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "AUTOMOBILISMO"},
                    new Alternativa {Correta = false, Descricao = "IATISMO"},
                    new Alternativa {Correta = true, Descricao = "AEROMODELISMO"},
                    new Alternativa {Correta = false, Descricao = "ATLETISMO"},
                }
            },
            new Pergunta
            {
                Id = 29,
                Enunciado = "Qual é o significado da frase inglesa “I love you”?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "BOM-DIA"},
                    new Alternativa {Correta = false, Descricao = "ATÉ LOGO"},
                    new Alternativa {Correta = true, Descricao = "EU AMO VOCÊ"},
                    new Alternativa {Correta = false, Descricao = "ESTOU COM FOME"},
                }
            },
            new Pergunta
            {
                Id = 30,
                Enunciado = "Qual personagem lidera o bando da floresta de Sherwood?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "ROBIN COOK"},
                    new Alternativa {Correta = false, Descricao = "ROBIN BANKS"},
                    new Alternativa {Correta = true, Descricao = "ROBIN HOOD"},
                    new Alternativa {Correta = false, Descricao = "ROBIN DAYS"},
                }
            },
            new Pergunta
            {
                Id = 31,
                Enunciado = "Qual é a cor da pedra rubi?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "AZUL"},
                    new Alternativa {Correta = false, Descricao = "VERDE"},
                    new Alternativa {Correta = false, Descricao = "AMARELA"},
                    new Alternativa {Correta = true, Descricao = "VERMELHA"},
                }
            },
            new Pergunta
            {
                Id = 32,
                Enunciado = "Qual é a planta que fortalece o marinheiro Popeye?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "ALFACE"},
                    new Alternativa {Correta = true, Descricao = "ESPINAFRE"},
                    new Alternativa {Correta = false, Descricao = "CENOURA"},
                    new Alternativa {Correta = false, Descricao = "REPOLHO"},
                }
            },
            new Pergunta
            {
                Id = 33,
                Enunciado = "Quando é comemorado o dia de Santo Antônio?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "12 DE AGOSTO"},
                    new Alternativa {Correta = false, Descricao = "11 DE JANEIRO"},
                    new Alternativa {Correta = true, Descricao = "13 DE JUNHO"},
                    new Alternativa {Correta = false, Descricao = "7 DE SETEMBRO"},
                }
            },
            new Pergunta
            {
                Id = 34,
                Enunciado = "Qual era a profissão exercida por Lula, antes de ele ser presidente do PT?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "ENGRAXATE"},
                    new Alternativa {Correta = false, Descricao = "PEDREIRO"},
                    new Alternativa {Correta = false, Descricao = "FEIRANTE"},
                    new Alternativa {Correta = true, Descricao = "METALÚRGICO"},
                }
            },
            new Pergunta
            {
                Id = 35,
                Enunciado = "Quem foi o amor do imperador Marco Antônio?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "SHERAZADE"},
                    new Alternativa {Correta = false, Descricao = "LADY GODIVA"},
                    new Alternativa {Correta = true, Descricao = "CLEÓPATRA"},
                    new Alternativa {Correta = false, Descricao = "JULIETA"},
                }
            },
            new Pergunta
            {
                Id = 36,
                Enunciado = "Qual estação do ano fica entre o verão e o inverno?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "VERÃO"},
                    new Alternativa {Correta = true, Descricao = "OUTONO"},
                    new Alternativa {Correta = false, Descricao = "INVERNO"},
                    new Alternativa {Correta = false, Descricao = "PRIMAVERA"},
                }
            },
            new Pergunta
            {
                Id = 37,
                Enunciado = "Como Joana d'Arc foi morta?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "ENFORCADA"},
                    new Alternativa {Correta = false, Descricao = "AFOGADA"},
                    new Alternativa {Correta = true, Descricao = "QUEIMADA"},
                    new Alternativa {Correta = false, Descricao = "ASFIXIADA"},
                }
            },
            new Pergunta
            {
                Id = 38,
                Enunciado = "Quantos jogadores um time de futebol tem em campo?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "10"},
                    new Alternativa {Correta = true, Descricao = "11"},
                    new Alternativa {Correta = false, Descricao = "12"},
                    new Alternativa {Correta = false, Descricao = "9"},
                }
            },
            new Pergunta
            {
                Id = 39,
                Enunciado = "Qual o nome da capital do Brasil?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "BRASÍLIA"},
                    new Alternativa {Correta = false, Descricao = "RIO DE JANEIRO"},
                    new Alternativa {Correta = false, Descricao = "SÃO PAULO"},
                    new Alternativa {Correta = false, Descricao = "SALVADOR"},
                }
            },
            new Pergunta
            {
                Id = 40,
                Enunciado = "Qual é a moeda oficial dos Estados Unidos?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "DÓLAR"},
                    new Alternativa {Correta = false, Descricao = "EURO"},
                    new Alternativa {Correta = false, Descricao = "LIBRA"},
                    new Alternativa {Correta = false, Descricao = "PESO"},
                }
            }
        };

        List<Pergunta> Perguntas_dificeis = new()
        {
            new Pergunta
            {
                Id = 41,
                Enunciado = "Quem escreveu a obra 'A Divina Comédia'?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "DANTE ALIGHIERI"},
                    new Alternativa {Correta = false, Descricao = "VIRGÍLIO"},
                    new Alternativa {Correta = false, Descricao = "HOMERO"},
                    new Alternativa {Correta = false, Descricao = "SHAKESPEARE"},
                }
            },
            new Pergunta
            {
                Id = 42,
                Enunciado = "Qual é o maior planeta do sistema solar?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "JÚPITER"},
                    new Alternativa {Correta = false, Descricao = "SATURNO"},
                    new Alternativa {Correta = false, Descricao = "URANO"},
                    new Alternativa {Correta = false, Descricao = "NETUNO"},
                }
            },
            new Pergunta
            {
                Id = 43,
                Enunciado = "Quem pintou 'A Última Ceia'?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "LEONARDO DA VINCI"},
                    new Alternativa {Correta = false, Descricao = "MICHELANGELO"},
                    new Alternativa {Correta = false, Descricao = "RAFAEL"},
                    new Alternativa {Correta = false, Descricao = "DONATELLO"},
                }
            },
            new Pergunta
            {
                Id = 44,
                Enunciado = "Em que ano ocorreu a Revolução Francesa?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "1789"},
                    new Alternativa {Correta = false, Descricao = "1776"},
                    new Alternativa {Correta = false, Descricao = "1815"},
                    new Alternativa {Correta = false, Descricao = "1848"},
                }
            },
            new Pergunta
            {
                Id = 45,
                Enunciado = "Qual é o elemento químico de símbolo Au?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "OURO"},
                    new Alternativa {Correta = false, Descricao = "PRATA"},
                    new Alternativa {Correta = false, Descricao = "MERCÚRIO"},
                    new Alternativa {Correta = false, Descricao = "COBRE"},
                }
            },
            new Pergunta
            {
                Id = 46,
                Enunciado = "Quem foi o primeiro homem a pisar na Lua?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "NEIL ARMSTRONG"},
                    new Alternativa {Correta = false, Descricao = "BUZZ ALDRIN"},
                    new Alternativa {Correta = false, Descricao = "YURI GAGARIN"},
                    new Alternativa {Correta = false, Descricao = "MICHAEL COLLINS"},
                }
            },
            new Pergunta
            {
                Id = 47,
                Enunciado = "Qual país é conhecido como a 'terra do sol nascente'?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "JAPÃO"},
                    new Alternativa {Correta = false, Descricao = "CHINA"},
                    new Alternativa {Correta = false, Descricao = "COREIA DO SUL"},
                    new Alternativa {Correta = false, Descricao = "TAILÂNDIA"},
                }
            },
            new Pergunta
            {
                Id = 48,
                Enunciado = "Quem descobriu a penicilina?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "ALEXANDER FLEMING"},
                    new Alternativa {Correta = false, Descricao = "LOUIS PASTEUR"},
                    new Alternativa {Correta = false, Descricao = "MARIE CURIE"},
                    new Alternativa {Correta = false, Descricao = "ROBERT KOCH"},
                }
            },
            new Pergunta
            {
                Id = 49,
                Enunciado = "Qual foi o primeiro presidente dos Estados Unidos?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "GEORGE WASHINGTON"},
                    new Alternativa {Correta = false, Descricao = "THOMAS JEFFERSON"},
                    new Alternativa {Correta = false, Descricao = "ABRAHAM LINCOLN"},
                    new Alternativa {Correta = false, Descricao = "JOHN ADAMS"},
                }
            },
            new Pergunta
            {
                Id = 50,
                Enunciado = "Em que país as pirâmides de Gizé estão localizadas?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "EGITO"},
                    new Alternativa {Correta = false, Descricao = "MÉXICO"},
                    new Alternativa {Correta = false, Descricao = "PERU"},
                    new Alternativa {Correta = false, Descricao = "ÍNDIA"},
                }
            },
            new Pergunta
            {
                Id = 51,
                Enunciado = "Qual é a capital da Austrália?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "CANBERRA"},
                    new Alternativa {Correta = false, Descricao = "SIDNEY"},
                    new Alternativa {Correta = false, Descricao = "MELBOURNE"},
                    new Alternativa {Correta = false, Descricao = "BRISBANE"},
                }
            },
            new Pergunta
            {
                Id = 52,
                Enunciado = "Quem pintou a obra 'Guernica'?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "PABLO PICASSO"},
                    new Alternativa {Correta = false, Descricao = "SALVADOR DALÍ"},
                    new Alternativa {Correta = false, Descricao = "VINCENT VAN GOGH"},
                    new Alternativa {Correta = false, Descricao = "HENRI MATISSE"},
                }
            },
            new Pergunta
            {
                Id = 53,
                Enunciado = "Qual é a montanha mais alta do mundo?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "EVEREST"},
                    new Alternativa {Correta = false, Descricao = "K2"},
                    new Alternativa {Correta = false, Descricao = "KANGCHENJUNGA"},
                    new Alternativa {Correta = false, Descricao = "LHOTSE"},
                }
            },
            new Pergunta
            {
                Id = 54,
                Enunciado = "Em que ano terminou a Segunda Guerra Mundial?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "1945"},
                    new Alternativa {Correta = false, Descricao = "1944"},
                    new Alternativa {Correta = false, Descricao = "1946"},
                    new Alternativa {Correta = false, Descricao = "1947"},
                }
            },
            new Pergunta
            {
                Id = 55,
                Enunciado = "Qual é o rio mais longo do mundo?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "RIO NILO"},
                    new Alternativa {Correta = false, Descricao = "RIO AMAZONAS"},
                    new Alternativa {Correta = false, Descricao = "RIO MISSISSIPI"},
                    new Alternativa {Correta = false, Descricao = "RIO YANGTZE"},
                }
            },
            new Pergunta
            {
                Id = 56,
                Enunciado = "Qual é o nome do hino nacional da França?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "LA MARSEILLAISE"},
                    new Alternativa {Correta = false, Descricao = "GOD SAVE THE QUEEN"},
                    new Alternativa {Correta = false, Descricao = "THE STAR-SPANGLED BANNER"},
                    new Alternativa {Correta = false, Descricao = "DEUTSCHLANDLIED"},
                }
            },
            new Pergunta
            {
                Id = 57,
                Enunciado = "Qual foi o primeiro homem a conquistar o Monte Everest?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "EDMUND HILLARY"},
                    new Alternativa {Correta = false, Descricao = "GEORGE MALLORY"},
                    new Alternativa {Correta = false, Descricao = "TENZING NORGAY"},
                    new Alternativa {Correta = false, Descricao = "REINHOLD MESSNER"},
                }
            },
            new Pergunta
            {
                Id = 58,
                Enunciado = "Qual país é famoso pelo tradicional relógio cuco?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "SUÍÇA"},
                    new Alternativa {Correta = false, Descricao = "ALEMANHA"},
                    new Alternativa {Correta = false, Descricao = "ITÁLIA"},
                    new Alternativa {Correta = false, Descricao = "FRANÇA"},
                }
            },
            new Pergunta
            {
                Id = 59,
                Enunciado = "Em que ano foi derrubado o Muro de Berlim?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "1989"},
                    new Alternativa {Correta = false, Descricao = "1990"},
                    new Alternativa {Correta = false, Descricao = "1988"},
                    new Alternativa {Correta = false, Descricao = "1991"},
                }
            },
            new Pergunta
            {
                Id = 60,
                Enunciado = "Quem desenvolveu a teoria da relatividade?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "ALBERT EINSTEIN"},
                    new Alternativa {Correta = false, Descricao = "ISAAC NEWTON"},
                    new Alternativa {Correta = false, Descricao = "GALILEU GALILEI"},
                    new Alternativa {Correta = false, Descricao = "NICOLAU COPÉRNICO"},
                }
            },

        };


        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
