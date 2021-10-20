using Microsoft.EntityFrameworkCore.Migrations;

namespace IntecapBooks.Infrastructure.Migrations
{
    public partial class InitialBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "CoverTypeId", "Description", "Discount", "ISBN", "ImageUrl", "Price", "SiteUrl", "Title" },
                values: new object[] { 1, "Gabriel García Márquez", 1, 1, "Muchos años después, frente al pelotón de fusilamiento, el coronel Aureliano Buendía había de recordar aquella tarde remota en que su padre lo llevó a conocer el hielo. Macondo era entonces una aldea de veinte casas de barro y cañabrava construidas a la orilla de un río de aguas diáfanas que se precipitaban por un lecho de piedras pulidas, blancas y enormes como huevos prehistóricos. El mundo era tan reciente, que muchas cosas carecían de nombre, y para mencionarlas había que señalarlas con el dedo.» Con estas palabras empieza la novela ya legendaria en los anales de la literatura universal, una de las aventuras literarias más fascinantes de nuestro siglo. Millones de ejemplares deCien años de soledad leídos en todas las lenguas y el Premio Nobel de Literatura coronando una obra que se había abierto paso «boca a boca» -como gusta decir al escritor- son la más palpable demostración de que la aventura fabulosa de la familia Buendía-Iguarán, con sus milagros, fantasías, obsesiones, tragedias, incestos, adulterios, rebeldías, descubrimientos y condenas, representaba al mismo tiempo el mito y la historia, la tragedia y el amor del mundo entero.", 0.25, "9788497592208", "https://imagessl8.casadellibro.com/a/l/t5/08/9788497592208.jpg", 40000.0, null, "Cien Años de Soledad" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "CoverTypeId", "Description", "Discount", "ISBN", "ImageUrl", "Price", "SiteUrl", "Title" },
                values: new object[] { 2, "Hector Abad Faciolince", 1, 1, "El 25 de agosto de 1987 Hector Abad Gómez, medico y activista en pro de los derechos humanos, es asesinado en Medellín por los paramilitares.El olvido que seremos es su biografía novelada, escrita por su propio hijo. Un relato desgarrador y emocionante sobre la familia, que refleja, al tiempo, el infierno de la violencia que ha golpeado Colombia en los últimos cincuenta años.Esta novela de Hector Abad Faciolince ha sido ganadora del Premio WOLA-Duke en Derechos Humanos en Estados Unidos y del Premio Criaçao Literária Casa da America Latina de Portugal.Reseña: Era inevitable que un libro tan emocionante me removiera los cimientos. Octavio Salazar, The Huffington Post Un libro padre como dirían en Mexico - que es así como la lengua popular define todo aquello más que bueno -, por su calidad narrativa y sobre todo porque el protagonista de la historia es el doctor Hector Abad(1921 - 1987), un progenitor diferente: cristiano en religión,", 0.0, "9788420426402", "https://imagessl2.casadellibro.com/a/l/t5/02/9788420426402.jpg", 50000.0, null, "El Olvido que seremos" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "CoverTypeId", "Description", "Discount", "ISBN", "ImageUrl", "Price", "SiteUrl", "Title" },
                values: new object[] { 3, "George Orwell", 2, 2, "«No creo que la sociedad que he descrito en1984 necesariamente llegue a ser una realidad, pero sí creo que puede llegar a existir algo parecido», escribía Orwell después de publicar su novela. Corría el año 1948, y la realidad se ha encargado de convertir esa pieza -entonces de ciencia ficción- en un manifiesto de la realidad. En el año 1984 Londres es una ciudad lúgubre en la que la Policía del Pensamiento controla de forma asfixiante la vida de los ciudadanos. Winston Smith es un peón de este engranaje perverso y su cometido es reescribir la historia para adaptarla a lo que el Partido considera la versión oficial de los hechos. Hasta que decide replantearse la verdad del sistema que los gobierna y somete.La presente edición, avalada por The Orwell Estate, sigue fielmente el texto definitivo de las obras completas del autor, fijado por el profesor Peter Davison. Incluye un epílogo del novelista Thomas Pynchon, que aporta al análisis del libro su personal visión de los totalitarismos y la paranoia en el mundo moderno. Miguel Temprano García firma la soberbia traducción, que es la más reciente de la obra.", 0.0, "9788499890944", "https://imagessl4.casadellibro.com/a/l/t5/44/9788499890944.jpg", 35500.0, null, "1984" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
