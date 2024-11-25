using DECO_Pets.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;

namespace DECO_Pets.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Species> Species { get; set; }

        public DbSet<Race> Races { get; set; }

        public DbSet<Weight> Weights { get; set; }

        public DbSet<Age> Ages { get; set; }

        public DbSet<Seguradora> Seguradoras { get; set; }

        public DbSet<Dados> Dados { get; set; }

        public DbSet<Premios> Premios { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Species>().HasData(
                new Species { ID = 1, NameSpecies = "Cão"},
                new Species { ID = 2, NameSpecies = "Gato" }
                );

            builder.Entity<Race>().HasData(
                new Race { ID = 1, Descricao = "Sem raça definida", EspeciesID = 1 },
                new Race { ID = 2, Descricao = "Beagle", EspeciesID = 1 },
                new Race { ID = 3, Descricao = "Bichon Maltês", EspeciesID = 1 },
                new Race { ID = 4, Descricao = "Border Collie", EspeciesID = 1 },
                new Race { ID = 5, Descricao = "Bouledogue Francês", EspeciesID = 1 },
                new Race { ID = 6, Descricao = "Boxer", EspeciesID = 1 },
                new Race { ID = 7, Descricao = "Poodle", EspeciesID = 1 },
                new Race { ID = 8, Descricao = "Cão da Serra da Estrela", EspeciesID = 1 },
                new Race { ID = 9, Descricao = "Cão de Água Português", EspeciesID = 1 },
                new Race { ID = 10, Descricao = "Pastor Alemão", EspeciesID = 1 },
                new Race { ID = 11, Descricao = "Chihuahua", EspeciesID = 1 },
                new Race { ID = 12, Descricao = "Chow-Chow", EspeciesID = 1 },
                new Race { ID = 13, Descricao = "Cocker Spaniel Inglês", EspeciesID = 1 },
                new Race { ID = 14, Descricao = "Golden Retriever", EspeciesID = 1 },
                new Race { ID = 15, Descricao = "Jack Russel Terrier", EspeciesID = 1 },
                new Race { ID = 16, Descricao = "Labrador Retriever", EspeciesID = 1 },
                new Race { ID = 17, Descricao = "Pinscher Miniatura", EspeciesID = 1 },
                new Race { ID = 18, Descricao = "Podengo Português", EspeciesID = 1 },
                new Race { ID = 19, Descricao = "Spitz Alemão", EspeciesID = 1 },
                new Race { ID = 20, Descricao = "Yorkshire Terrier", EspeciesID = 1 },
                new Race { ID = 21, Descricao = "Europeu comum/Sem raça definida", EspeciesID = 2 },
                new Race { ID = 22, Descricao = "Britânico Pêlo Longo", EspeciesID = 2 },
                new Race { ID = 23, Descricao = "Gato Bosques da Noruega", EspeciesID = 2 },
                new Race { ID = 24, Descricao = "Maine Coon", EspeciesID = 2 },
                new Race { ID = 25, Descricao = "Persa", EspeciesID = 2 },
                new Race { ID = 26, Descricao = "Siamês", EspeciesID = 2 },
                new Race { ID = 27, Descricao = "Sphynx", EspeciesID = 2 }
                );

            builder.Entity<Weight>().HasData(
                new Weight { ID = 1, WeightDescription = "Até 5Kg"},
                new Weight { ID = 2, WeightDescription = "Entre 5Kg e 10Kg"},
                new Weight { ID = 3, WeightDescription = "Entre 11Kg e 20Kg" },
                new Weight { ID = 4, WeightDescription = "Entre 21Kg e 45Kg" },
                new Weight { ID = 5, WeightDescription = "Mais de 45Kg"},
                new Weight { ID = 6, WeightDescription = ""}
                );

            builder.Entity<Age>().HasData(
                new Age { ID = 1, AgeDescription = "Entre 0 e 6 Meses"},
                new Age { ID = 2, AgeDescription = "Entre 6 Meses e 1,5 Anos"},
                new Age { ID = 3, AgeDescription = "Entre 1,5 Anos e 2 Anos"},
                new Age { ID = 4, AgeDescription = "Entre 2 e 4 Anos" },
                new Age { ID = 5, AgeDescription = "Entre 4 e 6 Anos"},
                new Age { ID = 6, AgeDescription = "Entre 6 e 7 Anos" },
                new Age { ID = 7, AgeDescription = "Entre 7 e 8 Anos" }
                );

            builder.Entity<Seguradora>().HasData(
                new Seguradora
                {
                    ID = 1,
                    Nome = "Mapfre",
                    Designacao = "Netanimais Domésticos @Maxi",
                    Qualidade = 78,
                    QualidadeDesc = "Boa Qualidade",
                    Coberturas = "Responsabilidade Civil, Acesso à rede veterinária, Despesas médicas por acidente, Cirurgia, Eutanásia, Desaparecimento e Guarda do animal",
                    Destaque = "O prémio apresentado pressupõe um animal de companhia do género masculino, não esterilizado, sem histórico de doenças ou cirurgias e que não representa risco para a segurança por comportamento agressivo. Se o seu animal não corresponde a estas características, o prémio poderá variar.",
                    Observacoes = "Considerado cão de companhia, sem doenças ou cirurgias preexistentes, sem histórico de ofensas à integridade física de uma pessoa ou de outro animal, não esterilizado.",
                    DateEdicao = DateTime.Now,
                    ImagemSeguradora = "",
                    Responsabilidade_Civil_LimiteAnual = "100.000 €",
                    Responsabilidade_Civil_Franquia = "50 €",
                    Despesas_Veterinarias_LimiteAnual = "Por doença: acesso à rede. Por acidente: 500 €",
                    Despesas_Veterinarias_Franquia = "",
                    Vacinas_LimiteAnual = "Cobertura opcional",
                    Vacinas_Franquia = "",
                    Cirurgia_LimiteAnual = "Por doença: 500 €. Por acidente: 500 €",
                    Cirurgia_Franquia = "10% rede, 30% fora rede",
                    Eutanasia_Funeral_LimiteAnual = "200 €",
                    Eutanasia_Funeral_Franquia = "Sem franquia",
                    Desaparecimento_LimiteAnual = "100 €",
                    Desaparecimento_Franquia = "Sem franquia",
                    Guarda_LimiteAnual = "300 €",
                    Guarda_Franquia = "Sem franquia"
                    },
                new Seguradora
                {
                    ID = 2,
                    Nome = "Seguros Continente",
                    Designacao = "Cães e Gatos Pleno",
                    Qualidade = 78,
                    QualidadeDesc = "Boa Qualidade",
                    Coberturas = "Responsabilidade Civil, Acesso à rede veterinária, Cirurgia, Funeral, Desaparecimento e Guarda do Animal",
                    Destaque = "O prémio apresentado pressupõe um animal de companhia do género masculino, não esterilizado, sem histórico de doenças ou cirurgias e que não representa risco para a segurança por comportamento agressivo. Se o seu animal não corresponde a estas características, o prémio poderá variar.",
                    Observacoes = "Considerado cão de companhia, sem doenças ou cirurgias preexistentes, sem histórico de ofensas à integridade física de uma pessoa ou de outro animal, não esterilizado.",
                    DateEdicao = DateTime.Now,
                    ImagemSeguradora = "",
                    Responsabilidade_Civil_LimiteAnual = "100.000 €",
                    Responsabilidade_Civil_Franquia = "50 €",
                    Despesas_Veterinarias_LimiteAnual = "Acesso à rede",
                    Despesas_Veterinarias_Franquia = "",
                    Vacinas_LimiteAnual = "Oferta vacina anual",
                    Vacinas_Franquia = "",
                    Cirurgia_LimiteAnual = "Por doença: 500 €. Por acidente: 500 €",
                    Cirurgia_Franquia = "10% rede, 30% fora rede",
                    Eutanasia_Funeral_LimiteAnual = "300 €",
                    Eutanasia_Funeral_Franquia = "Sem franquia",
                    Desaparecimento_LimiteAnual = "100 €",
                    Desaparecimento_Franquia = "Sem franquia",
                    Guarda_LimiteAnual = "300 €",
                    Guarda_Franquia = "Sem franquia"
                    },
                new Seguradora
                {
                    ID = 3,
                    Nome = "Europ Assistance",
                    Designacao = "Petki Platinum",
                    Qualidade = 77,
                    QualidadeDesc = "Boa Qualidade",
                    Coberturas = "Responsabilidade Civil, Despesas médicas, Cirurgia, Despesas de internamento, Eutanásia, Desaparecimento e Guarda do Animal",
                    Destaque = "O prémio apresentado pressupõe um animal de companhia do género masculino, não esterilizado, sem histórico de doenças ou cirurgias e que não representa risco para a segurança por comportamento agressivo. Se o seu animal não corresponde a estas características, o prémio poderá variar.",
                    Observacoes = "Considerado cão de companhia, sem doenças ou cirurgias preexistentes, sem histórico de ofensas à integridade física de uma pessoa ou de outro animal, não esterilizado.",
                    DateEdicao = DateTime.Now,
                    ImagemSeguradora = "",
                    Responsabilidade_Civil_LimiteAnual = "50.000 €",
                    Responsabilidade_Civil_Franquia = "",
                    Despesas_Veterinarias_LimiteAnual = "Por doença ou acidente: 500 €",
                    Despesas_Veterinarias_Franquia = "Franquia variável com o tipo de consulta ou exame",
                    Vacinas_LimiteAnual = "Acesso à rede",
                    Vacinas_Franquia = "",
                    Cirurgia_LimiteAnual = "6.500 € por sinistro e 20.000 € por anuidade; Limites máximos por tipo de cirurgia",
                    Cirurgia_Franquia = "10 ou 30%, consoante o tipo de cirurgia",
                    Eutanasia_Funeral_LimiteAnual = "200 €",
                    Eutanasia_Funeral_Franquia = "Sem franquia",
                    Desaparecimento_LimiteAnual = "500 €; Máx. 30 dias",
                    Desaparecimento_Franquia = "Sem franquia",
                    Guarda_LimiteAnual = "500 €",
                    Guarda_Franquia = "Sem franquia"
                    },
                new Seguradora
                {
                    ID = 4,
                    Nome = "Fidelidade",
                    Designacao = "Pet 3 - Exclusivo subscritores",
                    Qualidade = 76,
                    QualidadeDesc = "Boa Qualidade",
                    Coberturas = "Responsabilidade Civil, Despesas veterinárias e Cirurgia",
                    Destaque = "Os subscritores da DECO PROTESTE beneficiam de um desconto de 10% no prémio ao longo de todo o contrato. O prémio apresentado pressupõe um animal do género masculino e não esterilizado. Se o seu animal não corresponde a estas características, o prémio poderá variar.",
                    Observacoes = "Considerado cão de companhia, sem doenças ou cirurgias preexistentes, sem histórico de ofensas à integridade física de uma pessoa ou de outro animal, não esterilizado.",
                    DateEdicao = DateTime.Now,
                    ImagemSeguradora = "",
                    Responsabilidade_Civil_LimiteAnual = "75.000 €",
                    Responsabilidade_Civil_Franquia = "10% danos, mín. 50 €",
                    Despesas_Veterinarias_LimiteAnual = "250 €",
                    Despesas_Veterinarias_Franquia = "30%",
                    Vacinas_LimiteAnual = "Cobertura opcional",
                    Vacinas_Franquia = "",
                    Cirurgia_LimiteAnual = "1.000 €",
                    Cirurgia_Franquia = "30%",
                    Eutanasia_Funeral_LimiteAnual = "Eutanásia incluída nas despesas médicas; Funeral excluído.",
                    Eutanasia_Funeral_Franquia = "",
                    Desaparecimento_LimiteAnual = "Cobertura não disponível",
                    Desaparecimento_Franquia = "",
                    Guarda_LimiteAnual = "Cobertura não disponível",
                    Guarda_Franquia = ""
                    },
                new Seguradora
                {
                    ID = 5,
                    Nome = "Fidelidade",
                    Designacao = "Pet 3",
                    Qualidade = 76,
                    QualidadeDesc = "Boa Qualidade",
                    Coberturas = "Responsabilidade Civil, Despesas veterinárias e Cirurgia",
                    Destaque = "O prémio apresentado pressupõe um animal de companhia do género masculino, não esterilizado, sem histórico de doenças ou cirurgias e que não representa risco para a segurança por comportamento agressivo. Se o seu animal não corresponde a estas características, o prémio poderá variar.",
                    Observacoes = "Considerado cão de companhia, sem doenças ou cirurgias preexistentes, sem histórico de ofensas à integridade física de uma pessoa ou de outro animal, não esterilizado.",
                    DateEdicao = DateTime.Now,
                    ImagemSeguradora = "",
                    Responsabilidade_Civil_LimiteAnual = "75.000 €",
                    Responsabilidade_Civil_Franquia = "10% danos, mín. 50 €",
                    Despesas_Veterinarias_LimiteAnual = "250 €",
                    Despesas_Veterinarias_Franquia = "30%",
                    Vacinas_LimiteAnual = "Cobertura opcional",
                    Vacinas_Franquia = "",
                    Cirurgia_LimiteAnual = "1.000 €",
                    Cirurgia_Franquia = "30%",
                    Eutanasia_Funeral_LimiteAnual = "Eutanásia incluída nas despesas médicas; Funeral excluído.",
                    Eutanasia_Funeral_Franquia = "",
                    Desaparecimento_LimiteAnual = "Cobertura não disponível",
                    Desaparecimento_Franquia = "",
                    Guarda_LimiteAnual = "Cobertura não disponível",
                    Guarda_Franquia = ""
                    },
                new Seguradora
                {
                    ID = 6,
                    Nome = "NSeguros",
                    Designacao = "NPET TOP DECO - Exclusivo subscritores",
                    Qualidade = 76,
                    QualidadeDesc = "Boa Qualidade",
                    Coberturas = "Responsabilidade Civil, Acesso à rede veterinária, Cirurgia, Eutanásia, Desaparecimento e Guarda do Animal",
                    Destaque = "Produto exclusivo para subscritores da DECO PROTESTE. O prémio apresentado pressupõe um animal de companhia do género masculino, não esterilizado, sem histórico de doenças ou cirurgias e que não representa risco para a segurança por comportamento agressivo. Se o seu animal não corresponde a estas características, o prémio poderá variar.",
                    Observacoes = "Considerado cão de companhia, sem doenças ou cirurgias preexistentes, sem histórico de ofensas à integridade física de uma pessoa ou de outro animal, não esterilizado.",
                    DateEdicao = DateTime.Now,
                    ImagemSeguradora = "",
                    Responsabilidade_Civil_LimiteAnual = "50.000 €",
                    Responsabilidade_Civil_Franquia = "50 €",
                    Despesas_Veterinarias_LimiteAnual = "Acesso à rede",
                    Despesas_Veterinarias_Franquia = "",
                    Vacinas_LimiteAnual = "Acesso à rede",
                    Vacinas_Franquia = "",
                    Cirurgia_LimiteAnual = "Por acidente ou doença: 1000 €; Máx. 1 750 € ano; Exclusivo rede",
                    Cirurgia_Franquia = "10%",
                    Eutanasia_Funeral_LimiteAnual = "250 €",
                    Eutanasia_Funeral_Franquia = "Sem franquia",
                    Desaparecimento_LimiteAnual = "150 €",
                    Desaparecimento_Franquia = "Sem franquia",
                    Guarda_LimiteAnual = "200 €",
                    Guarda_Franquia = "Sem franquia"
                    },
                new Seguradora
                {
                    ID = 7,
                    Nome = "Fidelidade",
                    Designacao = "Pet Vital - Exclusivo subscritores",
                    Qualidade = 76,
                    QualidadeDesc = "Boa Qualidade",
                    Coberturas = "Responsabilidade Civil, Despesas veterinárias, Vacinas e Cirurgia",
                    Destaque = "Os subscritores da DECO PROTESTE beneficiam de um desconto de 10% no prémio ao longo de todo o contrato. O prémio apresentado pressupõe um animal do género masculino e não esterilizado. Se o seu animal não corresponde a estas características, o prémio poderá variar.",
                    Observacoes = "Considerado cão de companhia, sem doenças ou cirurgias preexistentes, sem histórico de ofensas à integridade física de uma pessoa ou de outro animal, não esterilizado.",
                    DateEdicao = DateTime.Now,
                    ImagemSeguradora = "",
                    Responsabilidade_Civil_LimiteAnual = "200.000 €",
                    Responsabilidade_Civil_Franquia = "10% danos, mín. 50 €",
                    Despesas_Veterinarias_LimiteAnual = "750 €",
                    Despesas_Veterinarias_Franquia = "30%",
                    Vacinas_LimiteAnual = "100 €",
                    Vacinas_Franquia = "30%",
                    Cirurgia_LimiteAnual = "2.250 €",
                    Cirurgia_Franquia = "30%",
                    Eutanasia_Funeral_LimiteAnual = "Eutanásia incluída nas despesas médicas; Funeral opcional",
                    Eutanasia_Funeral_Franquia = "",
                    Desaparecimento_LimiteAnual = "Cobertura não disponível",
                    Desaparecimento_Franquia = "",
                    Guarda_LimiteAnual = "Cobertura não disponível",
                    Guarda_Franquia = ""
                    },
                new Seguradora
                {
                    ID = 8,
                    Nome = "Fidelidade",
                    Designacao = "Pet Vital",
                    Qualidade = 76,
                    QualidadeDesc = "Boa Qualidade",
                    Coberturas = "Responsabilidade Civil, Despesas veterinárias, Vacinas e Cirurgia",
                    Destaque = "O prémio apresentado pressupõe um animal de companhia do género masculino, não esterilizado, sem histórico de doenças ou cirurgias e que não representa risco para a segurança por comportamento agressivo. Se o seu animal não corresponde a estas características, o prémio poderá variar.",
                    Observacoes = "Considerado cão de companhia, sem doenças ou cirurgias preexistentes, sem histórico de ofensas à integridade física de uma pessoa ou de outro animal, não esterilizado.",
                    DateEdicao = DateTime.Now,
                    ImagemSeguradora = "",
                    Responsabilidade_Civil_LimiteAnual = "200.000 €",
                    Responsabilidade_Civil_Franquia = "10% danos, mín. 50 €",
                    Despesas_Veterinarias_LimiteAnual = "750 €",
                    Despesas_Veterinarias_Franquia = "30%",
                    Vacinas_LimiteAnual = "100 €",
                    Vacinas_Franquia = "30%",
                    Cirurgia_LimiteAnual = "2.250 €",
                    Cirurgia_Franquia = "30%",
                    Eutanasia_Funeral_LimiteAnual = "Eutanásia incluída nas despesas médicas; Funeral opcional",
                    Eutanasia_Funeral_Franquia = "",
                    Desaparecimento_LimiteAnual = "Cobertura não disponível",
                    Desaparecimento_Franquia = "",
                    Guarda_LimiteAnual = "Cobertura não disponível",
                    Guarda_Franquia = ""
                    },
                new Seguradora
                {
                    ID = 9,
                    Nome = "Mapfre",
                    Designacao = "Netanimais Domésticos @Média",
                    Qualidade = 74,
                    QualidadeDesc = "Boa Qualidade",
                    Coberturas = "Responsabilidade Civil, Acesso à rede veterinária, Despesas médicas por acidente, Cirurgia, Eutanásia e Desaparecimento",
                    Destaque = "O prémio apresentado pressupõe um animal de companhia do género masculino, não esterilizado, sem histórico de doenças ou cirurgias e que não representa risco para a segurança por comportamento agressivo. Se o seu animal não corresponde a estas características, o prémio poderá variar.",
                    Observacoes = "Considerado cão de companhia, sem doenças ou cirurgias preexistentes, sem histórico de ofensas à integridade física de uma pessoa ou de outro animal, não esterilizado.",
                    DateEdicao = DateTime.Now,
                    ImagemSeguradora = "",
                    Responsabilidade_Civil_LimiteAnual = "50.000 €",
                    Responsabilidade_Civil_Franquia = "50 €",
                    Despesas_Veterinarias_LimiteAnual = "Por doença: acesso à rede. Por acidente: 300 €",
                    Despesas_Veterinarias_Franquia = "",
                    Vacinas_LimiteAnual = "Cobertura opcional",
                    Vacinas_Franquia = "",
                    Cirurgia_LimiteAnual = "Por doença: 300 €. Por acidente: 300 €",
                    Cirurgia_Franquia = "10% rede, 30% fora rede",
                    Eutanasia_Funeral_LimiteAnual = "100 €",
                    Eutanasia_Funeral_Franquia = "Sem franquia",
                    Desaparecimento_LimiteAnual = "50 €",
                    Desaparecimento_Franquia = "Sem franquia",
                    Guarda_LimiteAnual = "Cobertura não disponível",
                    Guarda_Franquia = ""
                    },
                new Seguradora
                {
                    ID = 10,
                    Nome = "Europ Assistance",
                    Designacao = "Petki Gold",
                    Qualidade = 74,
                    QualidadeDesc = "Boa Qualidade",
                    Coberturas = "Responsabilidade Civil, Acesso à rede veterinária, Cirurgia, Despesas de internamento, Desaparecimento e Guarda do Animal",
                    Destaque = "O prémio apresentado pressupõe um animal de companhia do género masculino, não esterilizado, sem histórico de doenças ou cirurgias e que não representa risco para a segurança por comportamento agressivo. Se o seu animal não corresponde a estas características, o prémio poderá variar.",
                    Observacoes = "Considerado cão de companhia, sem doenças ou cirurgias preexistentes, sem histórico de ofensas à integridade física de uma pessoa ou de outro animal, não esterilizado.",
                    DateEdicao = DateTime.Now,
                    ImagemSeguradora = "",
                    Responsabilidade_Civil_LimiteAnual = "50.000 €",
                    Responsabilidade_Civil_Franquia = "",
                    Despesas_Veterinarias_LimiteAnual = "Acesso à rede",
                    Despesas_Veterinarias_Franquia = "",
                    Vacinas_LimiteAnual = "Acesso à rede",
                    Vacinas_Franquia = "",
                    Cirurgia_LimiteAnual = "4 600 € por sinistro e 14 000 € por anuidade; Limites máximos por tipo de cirurgia",
                    Cirurgia_Franquia = "10 ou 30%, consoante o tipo de cirurgia",
                    Eutanasia_Funeral_LimiteAnual = "Cobertura não disponível",
                    Eutanasia_Funeral_Franquia = "",
                    Desaparecimento_LimiteAnual = "500 €; Máx. 30 dias",
                    Desaparecimento_Franquia = "Sem franquia",
                    Guarda_LimiteAnual = "500 €",
                    Guarda_Franquia = "Sem franquia"
                },
                new Seguradora
                {
                    ID = 11,
                    Nome = "Seguros Continente",
                    Designacao = "Cães e Gatos Conforto",
                    Qualidade = 73,
                    QualidadeDesc = "Boa Qualidade",
                    Coberturas = "Responsabilidade Civil, Acesso à rede veterinária, Cirurgia, Eutanásia e Desaparecimento",
                    Destaque = "O prémio apresentado pressupõe um animal de companhia do género masculino, não esterilizado, sem histórico de doenças ou cirurgias e que não representa risco para a segurança por comportamento agressivo. Se o seu animal não corresponde a estas características, o prémio poderá variar.",
                    Observacoes = "Considerado cão de companhia, sem doenças ou cirurgias preexistentes, sem histórico de ofensas à integridade física de uma pessoa ou de outro animal, não esterilizado.",
                    DateEdicao = DateTime.Now,
                    ImagemSeguradora = "",
                    Responsabilidade_Civil_LimiteAnual = "50.000 €",
                    Responsabilidade_Civil_Franquia = "50 €",
                    Despesas_Veterinarias_LimiteAnual = "Acesso à rede",
                    Despesas_Veterinarias_Franquia = "",
                    Vacinas_LimiteAnual = "Oferta vacina anual",
                    Vacinas_Franquia = "",
                    Cirurgia_LimiteAnual = "Por doença: 300 € Por acidente: 300 €",
                    Cirurgia_Franquia = "10% rede, 30% fora rede",
                    Eutanasia_Funeral_LimiteAnual = "200 €",
                    Eutanasia_Funeral_Franquia = "Sem franquia",
                    Desaparecimento_LimiteAnual = "50 €",
                    Desaparecimento_Franquia = "Sem franquia",
                    Guarda_LimiteAnual = "Cobertura não disponível",
                    Guarda_Franquia = ""
                    },
                new Seguradora
                {
                    ID = 12,
                    Nome = "NSeguros",
                    Designacao = "NPET TOP - Exclusivo subscritores",
                    Qualidade = 67,
                    QualidadeDesc = "Boa Qualidade",
                    Coberturas = "Responsabilidade Civil, Acesso à rede veterinária, Cirurgia, Desaparecimento e Guarda do animal",
                    Destaque = "Os subscritores da DECO PROTESTE usufruem de um desconto. O prémio apresentado pressupõe um animal de companhia do género masculino, não esterilizado, sem histórico de doenças ou cirurgias e que não representa risco para a segurança por comportamento agressivo. Se o seu animal não corresponde a estas características, o prémio poderá variar.",
                    Observacoes = "Considerado cão de companhia, sem doenças ou cirurgias preexistentes, sem histórico de ofensas à integridade física de uma pessoa ou de outro animal, não esterilizado.",
                    DateEdicao = DateTime.Now,
                    ImagemSeguradora = "",
                    Responsabilidade_Civil_LimiteAnual = "50.000 €",
                    Responsabilidade_Civil_Franquia = "50 €",
                    Despesas_Veterinarias_LimiteAnual = "Acesso à rede",
                    Despesas_Veterinarias_Franquia = "",
                    Vacinas_LimiteAnual = "Acesso à rede",
                    Vacinas_Franquia = "",
                    Cirurgia_LimiteAnual = "Por acidente ou doença: 1000 €; Máx. 1 750 € ano; Exclusivo rede",
                    Cirurgia_Franquia = "10%",
                    Eutanasia_Funeral_LimiteAnual = "Cobertura não disponível",
                    Eutanasia_Funeral_Franquia = "",
                    Desaparecimento_LimiteAnual = "150 €",
                    Desaparecimento_Franquia = "Sem franquia",
                    Guarda_LimiteAnual = "200 €",
                    Guarda_Franquia = "Sem franquia"
                    },
                new Seguradora
                {
                    ID = 13,
                    Nome = "NSeguros",
                    Designacao = "NPET TOP",
                    Qualidade = 67,
                    QualidadeDesc = "Boa Qualidade",
                    Coberturas = "Responsabilidade Civil, Acesso à rede veterinária, Cirurgia, Desaparecimento e Guarda do animal",
                    Destaque = "O prémio apresentado pressupõe um animal de companhia do género masculino, não esterilizado, sem histórico de doenças ou cirurgias e que não representa risco para a segurança por comportamento agressivo. Se o seu animal não corresponde a estas características, o prémio poderá variar.",
                    Observacoes = "Considerado cão de companhia, sem doenças ou cirurgias preexistentes, sem histórico de ofensas à integridade física de uma pessoa ou de outro animal, não esterilizado.",
                    DateEdicao = DateTime.Now,
                    ImagemSeguradora = "",
                    Responsabilidade_Civil_LimiteAnual = "50.000 €",
                    Responsabilidade_Civil_Franquia = "50 €",
                    Despesas_Veterinarias_LimiteAnual = "Acesso à rede",
                    Despesas_Veterinarias_Franquia = "",
                    Vacinas_LimiteAnual = "Acesso à rede",
                    Vacinas_Franquia = "",
                    Cirurgia_LimiteAnual = "Por acidentes ou doença: 500 €. Exclusivo rede",
                    Cirurgia_Franquia = "10%",
                    Eutanasia_Funeral_LimiteAnual = "Cobertura não disponível",
                    Eutanasia_Funeral_Franquia = "",
                    Desaparecimento_LimiteAnual = "150 €",
                    Desaparecimento_Franquia = "Sem franquia",
                    Guarda_LimiteAnual = "200 €",
                    Guarda_Franquia = "Sem franquia"
                    }
                );

        }
    }
}
