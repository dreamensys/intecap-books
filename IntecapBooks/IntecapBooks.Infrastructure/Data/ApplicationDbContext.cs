
using Microsoft.EntityFrameworkCore;
using IntecapBooks.Business.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace IntecapBooks.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CoverType> CoverTypes { get; set; }

        public DbSet<ApplicationUser> Users { get; set; }
        public ApplicationDbContext()
        { 
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            // Seeding Admin user
            const string ADMIN_ID = "a18be9c0-aa65-4af8-bd17-00bd9344e575";
            const string ROLE_ID = "ad376a8f-9eab-4bb9-9fca-30b01540f445";
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = ROLE_ID,
                Name = "admin",
                NormalizedName = "admin"
            });

            var hasher = new PasswordHasher<ApplicationUser>();
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = ADMIN_ID,
                UserName = "admin@gmail.com",
                NormalizedUserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                NormalizedEmail = "admin@gmail.com",
                PasswordHash = hasher.HashPassword(null, "Admin123#"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });



            modelBuilder.Entity<Category>().HasData(
              new Category() { Id = 1, Name = "Novela" },
               new Category() { Id = 2, Name = "SciFi" },
               new Category() { Id = 3, Name = "Científico" }
           );
            modelBuilder.Entity<CoverType>().HasData(
                new CoverType() { Id = 1, Name = "Tapa Blanda" },
                new CoverType() { Id = 2, Name = "Tapa Dura" },
                new CoverType() { Id = 3, Name = "Digital" }
                );

            modelBuilder.Entity<Book>().HasData(
                new Book() { Id = 1, ISBN = "9788497592208", CoverTypeId = 1, CategoryId = 1, Title = "Cien Años de Soledad", Author = "Gabriel García Márquez", Discount = 0.25, Price = 40000, ImageUrl = "https://imagessl8.casadellibro.com/a/l/t5/08/9788497592208.jpg", Description = "Muchos años después, frente al pelotón de fusilamiento, el coronel Aureliano Buendía había de recordar aquella tarde remota en que su padre lo llevó a conocer el hielo. Macondo era entonces una aldea de veinte casas de barro y cañabrava construidas a la orilla de un río de aguas diáfanas que se precipitaban por un lecho de piedras pulidas, blancas y enormes como huevos prehistóricos. El mundo era tan reciente, que muchas cosas carecían de nombre, y para mencionarlas había que señalarlas con el dedo.» Con estas palabras empieza la novela ya legendaria en los anales de la literatura universal, una de las aventuras literarias más fascinantes de nuestro siglo. Millones de ejemplares deCien años de soledad leídos en todas las lenguas y el Premio Nobel de Literatura coronando una obra que se había abierto paso «boca a boca» -como gusta decir al escritor- son la más palpable demostración de que la aventura fabulosa de la familia Buendía-Iguarán, con sus milagros, fantasías, obsesiones, tragedias, incestos, adulterios, rebeldías, descubrimientos y condenas, representaba al mismo tiempo el mito y la historia, la tragedia y el amor del mundo entero." },
                new Book() { Id = 2, ISBN = "9788420426402", CoverTypeId = 1, CategoryId = 1, Title = "El Olvido que seremos", Author = "Hector Abad Faciolince", Discount = 0, Price = 50000, ImageUrl = "https://imagessl2.casadellibro.com/a/l/t5/02/9788420426402.jpg", Description = "El 25 de agosto de 1987 Hector Abad Gómez, medico y activista en pro de los derechos humanos, es asesinado en Medellín por los paramilitares.El olvido que seremos es su biografía novelada, escrita por su propio hijo. Un relato desgarrador y emocionante sobre la familia, que refleja, al tiempo, el infierno de la violencia que ha golpeado Colombia en los últimos cincuenta años.Esta novela de Hector Abad Faciolince ha sido ganadora del Premio WOLA-Duke en Derechos Humanos en Estados Unidos y del Premio Criaçao Literária Casa da America Latina de Portugal.Reseña: Era inevitable que un libro tan emocionante me removiera los cimientos. Octavio Salazar, The Huffington Post Un libro padre como dirían en Mexico - que es así como la lengua popular define todo aquello más que bueno -, por su calidad narrativa y sobre todo porque el protagonista de la historia es el doctor Hector Abad(1921 - 1987), un progenitor diferente: cristiano en religión," },
                new Book() { Id = 3, ISBN = "9788499890944", CoverTypeId = 2, CategoryId = 2, Title = "1984", Author = "George Orwell", Discount = 0, Price = 35500, ImageUrl = "https://imagessl4.casadellibro.com/a/l/t5/44/9788499890944.jpg", Description = "«No creo que la sociedad que he descrito en1984 necesariamente llegue a ser una realidad, pero sí creo que puede llegar a existir algo parecido», escribía Orwell después de publicar su novela. Corría el año 1948, y la realidad se ha encargado de convertir esa pieza -entonces de ciencia ficción- en un manifiesto de la realidad. En el año 1984 Londres es una ciudad lúgubre en la que la Policía del Pensamiento controla de forma asfixiante la vida de los ciudadanos. Winston Smith es un peón de este engranaje perverso y su cometido es reescribir la historia para adaptarla a lo que el Partido considera la versión oficial de los hechos. Hasta que decide replantearse la verdad del sistema que los gobierna y somete.La presente edición, avalada por The Orwell Estate, sigue fielmente el texto definitivo de las obras completas del autor, fijado por el profesor Peter Davison. Incluye un epílogo del novelista Thomas Pynchon, que aporta al análisis del libro su personal visión de los totalitarismos y la paranoia en el mundo moderno. Miguel Temprano García firma la soberbia traducción, que es la más reciente de la obra." }
            );
        }
    }
}
