using Microsoft.EntityFrameworkCore.Migrations;

namespace ModuloSeguridad.Entities.Migrations
{
    public partial class FakeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "MariaTeresa_Hidalgo0", null, "Hidalgo", "eoHmsho1nj", null, 1, null, null, "MariaTeresa.Hidalgo@hotmail.com", "María Teresa" },
                    { "JuanManuel.Kanea441663", null, "Kanea", "1nN6x43nry", null, 1, null, null, "JuanManuel.Kanea@nearbpo.com", "Juan Manuel" },
                    { "Gonzalo.Chavarria1664", null, "Chavarría", "LR3qcCHxMm", null, 1, null, null, "Gonzalo.Chavarria@gmail.com", "Gonzalo" },
                    { "Cesar_Veliz841665", null, "Véliz", "rARPB7jXCj", null, 1, null, null, "Cesar35@gmail.com", "César" },
                    { "Esperanza.Reynoso501666", null, "Reynoso", "oXRUAOcxel", null, 1, null, null, "Esperanza_Reynoso@gmail.com", "Esperanza" },
                    { "Jimena681667", null, "Yago", "blX7AxB1Ng", null, 1, null, null, "Jimena13@yahoo.com", "Jimena" },
                    { "Marcela.Valle191668", null, "Valle", "jsIkow9nxR", null, 1, null, null, "Marcela_Valle76@hotmail.com", "Marcela" },
                    { "Alejandra.Botello971669", null, "Botello", "HRIhOdJyKK", null, 1, null, null, "Alejandra75@corpfolder.com", "Alejandra" },
                    { "Berta_Guzman1670", null, "Guzmán", "GHBAnjO4H3", null, 1, null, null, "Berta.Guzman55@yahoo.com", "Berta" },
                    { "Mercedes_Quinterodelacruz601671", null, "Quintero de la cruz", "9MbTsO3XCi", null, 1, null, null, "Mercedes_Quinterodelacruz58@yahoo.com", "Mercedes" },
                    { "Luisa211672", null, "Navarro", "ABvXPmuGVQ", null, 1, null, null, "Luisa.Navarro@gmail.com", "Luisa" },
                    { "Nicolas.Beltran151673", null, "Beltrán", "YEZ_fnUYC5", null, 1, null, null, "Nicolas.Beltran93@gmail.com", "Nicolás" },
                    { "Naomi511674", null, "Kanimal", "__egxhaqUx", null, 1, null, null, "Naomi_Kanimal47@hotmail.com", "Naomi" },
                    { "Julieta.Kadarrodriguez431675", null, "Kadar rodriguez", "WX1nXtJTmx", null, 1, null, null, "Julieta.Kadarrodriguez@hotmail.com", "Julieta" },
                    { "AnaMaria.Quinta1676", null, "Quinta", "feW_0tbual", null, 1, null, null, "AnaMaria7@nearbpo.com", "Ana María" },
                    { "Beatriz.Arce1677", null, "Arce", "sFXOaRLHzJ", null, 1, null, null, "Beatriz_Arce47@nearbpo.com", "Beatriz" },
                    { "Rosa.Vela1662", null, "Vela", "QRYZw6dUmj", null, 1, null, null, "Rosa.Vela58@nearbpo.com", "Rosa" },
                    { "Marcos_Alonso491661", null, "Alonso", "xEMjCYlhFo", null, 1, null, null, "Marcos10@hotmail.com", "Marcos" },
                    { "Pilar91660", null, "Verdugo", "38mvNF2OWq", null, 1, null, null, "Pilar.Verdugo@gmail.com", "Pilar" },
                    { "Valentina801659", null, "Guillen", "Ja1U_Wd1z3", null, 1, null, null, "Valentina_Guillen39@corpfolder.com", "Valentina" },
                    { "Abraham.Preciado1643", null, "Preciado", "8oCmecHG3D", null, 1, null, null, "Abraham68@hotmail.com", "Abraham" },
                    { "Carolina.Cano1644", null, "Cano", "8ijFeqnVgM", null, 1, null, null, "Carolina60@nearbpo.com", "Carolina" },
                    { "Adela251645", null, "Mayorga", "RzeHaoAIIH", null, 1, null, null, "Adela_Mayorga@corpfolder.com", "Adela" },
                    { "Isaac.Apodaca1646", null, "Apodaca", "qqpJv_6vTa", null, 1, null, null, "Isaac92@gmail.com", "Isaac" },
                    { "MariaGuadalupe351647", null, "Báez", "tUdgMV_GW6", null, 1, null, null, "MariaGuadalupe_Baez@yahoo.com", "María Guadalupe" },
                    { "Ignacio61648", null, "Zaragoza", "gb7uVTcq_6", null, 1, null, null, "Ignacio_Zaragoza@gmail.com", "Ignacio" },
                    { "Rafael01649", null, "Pineda", "gaOZ7VRLWz", null, 1, null, null, "Rafael.Pineda31@nearbpo.com", "Rafael" },
                    { "Carlota621678", null, "Gurule", "Xw7_3Q_3FF", null, 1, null, null, "Carlota4@hotmail.com", "Carlota" },
                    { "Oscar_Villareal101650", null, "Villareal", "3OELhnlQ6K", null, 1, null, null, "Oscar.Villareal39@yahoo.com", "Óscar" },
                    { "LuisAngel_Pedroza571652", null, "Pedroza", "ToNCbUeCcb", null, 1, null, null, "LuisAngel.Pedroza@hotmail.com", "Luis Ángel" },
                    { "Paulina.Berrios811653", null, "Berríos", "RZNM9I2eBJ", null, 1, null, null, "Paulina.Berrios@gmail.com", "Paulina" },
                    { "JulioCesar721654", null, "Montez", "cPHhXMK1qJ", null, 1, null, null, "JulioCesar.Montez49@corpfolder.com", "Julio César" },
                    { "Anita241655", null, "Armijo", "Qpb0557irO", null, 1, null, null, "Anita_Armijo@nearbpo.com", "Anita" },
                    { "Tomas.Xiana1656", null, "Xiana", "4K2yMyeYGG", null, 1, null, null, "Tomas_Xiana95@gmail.com", "Tomás" },
                    { "Jesus_Galvez301657", null, "Gálvez", "ry5UB8o3j3", null, 1, null, null, "Jesus27@corpfolder.com", "Jesús" },
                    { "Paola321658", null, "Quintero", "0cuTG9YvwP", null, 1, null, null, "Paola19@nearbpo.com", "Paola" },
                    { "Daniela_Madera1651", null, "Madera", "fhujTgQbHq", null, 1, null, null, "Daniela.Madera80@yahoo.com", "Daniela" },
                    { "Diana31642", null, "Casanova", "CSX4V7ptO2", null, 1, null, null, "Diana12@nearbpo.com", "Diana" },
                    { "Jennifer.Cotto1679", null, "Cotto", "DH9yAACkIi", null, 1, null, null, "Jennifer70@corpfolder.com", "Jennifer" },
                    { "Virginia.Escobedo1681", null, "Escobedo", "2GvFM6i7Dx", null, 1, null, null, "Virginia5@corpfolder.com", "Virginia" },
                    { "Alexander_Velasquez121702", null, "Velásquez", "rV2JhQKlOp", null, 1, null, null, "Alexander_Velasquez28@hotmail.com", "Alexander" },
                    { "Gael941703", null, "Candelaria", "9dL6CtvJf4", null, 1, null, null, "Gael79@gmail.com", "Gael" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Araceli.Tapia491704", null, "Tapia", "0hYI1Gs5Xp", null, 1, null, null, "Araceli.Tapia23@hotmail.com", "Araceli" },
                    { "Luz_Ulloa1705", null, "Ulloa", "usuJFUohmL", null, 1, null, null, "Luz81@gmail.com", "Luz" },
                    { "Monica_Koenig1706", null, "Koenig", "a1RYF46GF1", null, 1, null, null, "Monica51@gmail.com", "Mónica" },
                    { "Benjamin_Trejo1707", null, "Trejo", "d_hQmDArdW", null, 1, null, null, "Benjamin57@nearbpo.com", "Benjamín" },
                    { "Homero_Villalpando1708", null, "Villalpando", "4hhsgWveiJ", null, 1, null, null, "Homero17@corpfolder.com", "Homero" },
                    { "Eva.Solorio01709", null, "Solorio", "kxSLMaQu6N", null, 1, null, null, "Eva.Solorio84@nearbpo.com", "Eva" },
                    { "Claudia.Marroquin1710", null, "Marroquín", "cZGfqByAyn", null, 1, null, null, "Claudia_Marroquin48@nearbpo.com", "Claudia" },
                    { "Israel891711", null, "Jáquez", "Ch7pshAfGk", null, 1, null, null, "Israel_Jaquez53@nearbpo.com", "Israel" },
                    { "Virginia.Beltran1712", null, "Beltrán", "SQYXzjfJGv", null, 1, null, null, "Virginia_Beltran@gmail.com", "Virginia" },
                    { "Damian231713", null, "Beltrán", "0SLGGog8bL", null, 1, null, null, "Damian.Beltran@yahoo.com", "Damián" },
                    { "Emmanuel_Tirado291714", null, "Tirado", "_t9vJJ0k49", null, 1, null, null, "Emmanuel_Tirado@yahoo.com", "Emmanuel" },
                    { "FernandoJavier_Sepulveda1715", null, "Sepúlveda", "F9Hh4UR06G", null, 1, null, null, "FernandoJavier9@corpfolder.com", "Fernando Javier" },
                    { "Lizbeth.Cuellar941716", null, "Cuellar", "VBd7jwVixp", null, 1, null, null, "Lizbeth8@yahoo.com", "Lizbeth" },
                    { "Alfonso131701", null, "Águilar", "CZBaPvLu8e", null, 1, null, null, "Alfonso_Aguilar83@hotmail.com", "Alfonso" },
                    { "Jaime_Laboy421700", null, "Laboy", "rsjMLUcR0V", null, 1, null, null, "Jaime63@yahoo.com", "Jaime" },
                    { "Gerardo_Ayala441699", null, "Ayala", "fXu8SgNmTe", null, 1, null, null, "Gerardo.Ayala43@hotmail.com", "Gerardo" },
                    { "MariaElena_Marroquin551698", null, "Marroquín", "GFwGaNQxo3", null, 1, null, null, "MariaElena28@yahoo.com", "María Elena" },
                    { "Francisco.Toro1682", null, "Toro", "UNcA8UqzWu", null, 1, null, null, "Francisco.Toro@yahoo.com", "Francisco" },
                    { "Marilu.Pulido1683", null, "Pulido", "WzLlN3xXTH", null, 1, null, null, "Marilu_Pulido@nearbpo.com", "Marilu" },
                    { "Ivan301684", null, "Vélez", "hiBacwGEnv", null, 1, null, null, "Ivan_Velez0@yahoo.com", "Ivan" },
                    { "Paulina.Nevarez781685", null, "Nevárez", "ntVNhijCV0", null, 1, null, null, "Paulina_Nevarez@yahoo.com", "Paulina" },
                    { "Tadeo.Gallegos501686", null, "Gallegos", "XRmFyQjEk2", null, 1, null, null, "Tadeo59@hotmail.com", "Tadeo" },
                    { "Axel.Cabrera1687", null, "Cabrera", "LAvtGo8Q6i", null, 1, null, null, "Axel_Cabrera39@gmail.com", "Axel" },
                    { "Emily631688", null, "Salcedo", "dqwhVO_OKq", null, 1, null, null, "Emily_Salcedo@nearbpo.com", "Emily" },
                    { "Hugo_Chavez241680", null, "Chávez", "r9TG3Kd5u5", null, 1, null, null, "Hugo.Chavez@yahoo.com", "Hugo" },
                    { "Guadalupe.Trejo531689", null, "Trejo", "aU2rJhOySc", null, 1, null, null, "Guadalupe91@nearbpo.com", "Guadalupe" },
                    { "MariadeJesus581691", null, "Centeno", "mlzzeU0E1e", null, 1, null, null, "MariadeJesus31@corpfolder.com", "María de Jesús" },
                    { "AngelDaniel721692", null, "Quinta", "Q4gWBrYKvt", null, 1, null, null, "AngelDaniel_Quinta@yahoo.com", "Ángel Daniel" },
                    { "LuisGabino931693", null, "Carranza", "_oPEyhINyR", null, 1, null, null, "LuisGabino.Carranza@gmail.com", "Luis Gabino" },
                    { "Damian741694", null, "Aparicio", "nMsNFqWdKS", null, 1, null, null, "Damian.Aparicio@gmail.com", "Damián" },
                    { "Jimena_Armas541695", null, "Armas", "jmjdGl452z", null, 1, null, null, "Jimena59@hotmail.com", "Jimena" },
                    { "Alexis.Banuelos1696", null, "Bañuelos", "5nxTikwltS", null, 1, null, null, "Alexis83@gmail.com", "Alexis" },
                    { "MariaCristina_Lemus1697", null, "Lemus", "Ow6AqDAvgs", null, 1, null, null, "MariaCristina.Lemus@hotmail.com", "María Cristina" },
                    { "Mercedes451690", null, "Candelaria", "zf1LEA6vWM", null, 1, null, null, "Mercedes.Candelaria49@hotmail.com", "Mercedes" },
                    { "FranciscoJavier.Nava801717", null, "Nava", "evg9kbkYpT", null, 1, null, null, "FranciscoJavier3@corpfolder.com", "Francisco Javier" },
                    { "JuanCarlos.Teran991641", null, "Terán", "zqK80OxyXe", null, 1, null, null, "JuanCarlos_Teran@hotmail.com", "Juan Carlos" },
                    { "Damian21639", null, "Saavedra", "2J5GohASrS", null, 1, null, null, "Damian_Saavedra82@gmail.com", "Damián" },
                    { "LuisFernando_Gollum301585", null, "Gollum", "6znjH0B1uC", null, 1, null, null, "LuisFernando85@corpfolder.com", "Luis Fernando" },
                    { "Alexis_Nanez1586", null, "Ñañez", "VSOSfJJ8sj", null, 1, null, null, "Alexis.Nanez@corpfolder.com", "Alexis" },
                    { "Salvador141587", null, "Escalante", "0Gjyg96hYZ", null, 1, null, null, "Salvador_Escalante6@corpfolder.com", "Salvador" },
                    { "Lola.Trejo1588", null, "Trejo", "OuopLIeWBg", null, 1, null, null, "Lola_Trejo64@corpfolder.com", "Lola" },
                    { "Rebeca181589", null, "Mateo", "LE8GtDiNtY", null, 1, null, null, "Rebeca.Mateo@gmail.com", "Rebeca" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Andres.Jasso871590", null, "Jasso", "SLkOk5pBYK", null, 1, null, null, "Andres_Jasso53@gmail.com", "Andrés" },
                    { "Ignacio.Alaniz201591", null, "Alaniz", "qawhEg4piH", null, 1, null, null, "Ignacio63@gmail.com", "Ignacio" },
                    { "Alexa_Torrez1592", null, "Tórrez", "WIUgPp5vzS", null, 1, null, null, "Alexa73@yahoo.com", "Alexa" },
                    { "MariaCristina_Ramon1593", null, "Ramón", "LY7GLTbBmz", null, 1, null, null, "MariaCristina_Ramon80@corpfolder.com", "María Cristina" },
                    { "Mariano_Osorio861594", null, "Osorio", "BwypnsJjAM", null, 1, null, null, "Mariano23@yahoo.com", "Mariano" },
                    { "Axel181595", null, "Ñañez", "K3yfLCJT_6", null, 1, null, null, "Axel_Nanez@yahoo.com", "Axel" },
                    { "Samuel171596", null, "Mejía", "oTI8lfwDDD", null, 1, null, null, "Samuel90@hotmail.com", "Samuel" },
                    { "Teresa201597", null, "Palacios", "MgHa7iKlCO", null, 1, null, null, "Teresa_Palacios@yahoo.com", "Teresa" },
                    { "Angela_Florez321598", null, "Flórez", "qWs27Ww148", null, 1, null, null, "Angela28@yahoo.com", "Ángela" },
                    { "Marilu661599", null, "Aguayo", "xfVfbk8cHz", null, 1, null, null, "Marilu29@corpfolder.com", "Marilu" },
                    { "Maximiliano.Escobedo1584", null, "Escobedo", "jf6GpV1z2A", null, 1, null, null, "Maximiliano31@nearbpo.com", "Maximiliano" },
                    { "AnaLuisa_Torrez351583", null, "Tórrez", "Bkg1mQotmM", null, 1, null, null, "AnaLuisa_Torrez@yahoo.com", "Ana Luisa" },
                    { "Berta_Arenas1582", null, "Arenas", "wtxE0kcx9j", null, 1, null, null, "Berta_Arenas@nearbpo.com", "Berta" },
                    { "Victoria791581", null, "Tórrez", "5a7U3dzRyA", null, 1, null, null, "Victoria.Torrez@hotmail.com", "Victoria" },
                    { "Susana311565", null, "Zayas", "xiT4MqduDY", null, 1, null, null, "Susana.Zayas@hotmail.com", "Susana" },
                    { "Armando_Kardachesoto201566", null, "Kardache soto", "rDoO7BXjSH", null, 1, null, null, "Armando.Kardachesoto27@gmail.com", "Armando" },
                    { "MariadelCarmen.Zepeda1567", null, "Zepeda", "vcSHiguBnk", null, 1, null, null, "MariadelCarmen_Zepeda@yahoo.com", "María del Carmen" },
                    { "MariaGuadalupe_Salazar1568", null, "Salazar", "J6N0BiwXGm", null, 1, null, null, "MariaGuadalupe.Salazar52@corpfolder.com", "María Guadalupe" },
                    { "Sofia.Mota721569", null, "Mota", "w9WnZXne1R", null, 1, null, null, "Sofia_Mota@nearbpo.com", "Sofia" },
                    { "Salvador281570", null, "Solorio", "DnDkoAzk60", null, 1, null, null, "Salvador.Solorio@hotmail.com", "Salvador" },
                    { "MariaTeresa_Barrientos1571", null, "Barrientos", "ey2j8NRe2j", null, 1, null, null, "MariaTeresa37@nearbpo.com", "María Teresa" },
                    { "JoseEduardo.Hinojosa1600", null, "Hinojosa", "sdZIgL0o6S", null, 1, null, null, "JoseEduardo.Hinojosa52@yahoo.com", "José Eduardo" },
                    { "JorgeLuis.Toledo291572", null, "Toledo", "cg5v52Dn2b", null, 1, null, null, "JorgeLuis6@yahoo.com", "Jorge Luis" },
                    { "Elizabeth571574", null, "Valdés", "m4W31FxTZ6", null, 1, null, null, "Elizabeth_Valdes@yahoo.com", "Elizabeth" },
                    { "Fatima311575", null, "Calvillo", "ZKH0ToGciu", null, 1, null, null, "Fatima73@nearbpo.com", "Fatima" },
                    { "Agustin.Delgado461576", null, "Delgado", "tAf9UMmHf2", null, 1, null, null, "Agustin83@yahoo.com", "Agustín" },
                    { "Jorge.Villareal971577", null, "Villareal", "Lpn2D5L00L", null, 1, null, null, "Jorge.Villareal@nearbpo.com", "Jorge" },
                    { "Erick431578", null, "Rascón", "hWRmqnrCRM", null, 1, null, null, "Erick_Rascon@nearbpo.com", "Erick" },
                    { "Miguel.Rojo311579", null, "Rojo", "d49MQEmo6k", null, 1, null, null, "Miguel62@gmail.com", "Miguel" },
                    { "Elena.Corral591580", null, "Corral", "hbVUyhuerR", null, 1, null, null, "Elena60@yahoo.com", "Elena" },
                    { "Marcos_Koenig91573", null, "Koenig", "XXMKEghqVW", null, 1, null, null, "Marcos_Koenig@yahoo.com", "Marcos" },
                    { "Nicole_Marquez1640", null, "Márquez", "S5Xd41yizD", null, 1, null, null, "Nicole.Marquez84@yahoo.com", "Nicole" },
                    { "JuanCarlos.Valdes281601", null, "Valdés", "M9KiXVy3sr", null, 1, null, null, "JuanCarlos_Valdes@hotmail.com", "Juan Carlos" },
                    { "Mariano.Bernal1603", null, "Bernal", "MRxl8bXm0F", null, 1, null, null, "Mariano.Bernal@hotmail.com", "Mariano" },
                    { "FranciscoJavier51624", null, "Cavazos", "C430ihcX6M", null, 1, null, null, "FranciscoJavier.Cavazos77@corpfolder.com", "Francisco Javier" },
                    { "JoseMiguel911625", null, "Pulido", "8ccInpKzzn", null, 1, null, null, "JoseMiguel_Pulido82@yahoo.com", "José Miguel" },
                    { "Liliana81626", null, "Deleón", "WNYweZkcmT", null, 1, null, null, "Liliana51@yahoo.com", "Liliana" },
                    { "Ramon.Vergara1627", null, "Vergara", "gL38zjDRiH", null, 1, null, null, "Ramon.Vergara92@corpfolder.com", "Ramón" },
                    { "Adriana_Rosas501628", null, "Rosas", "CsZeeYQjd_", null, 1, null, null, "Adriana24@corpfolder.com", "Adriana" },
                    { "Gael.Varela1629", null, "Varela", "h0HLWEKx1m", null, 1, null, null, "Gael4@corpfolder.com", "Gael" },
                    { "Luis441630", null, "Borrego", "12j0WuVCON", null, 1, null, null, "Luis78@hotmail.com", "Luis" },
                    { "Lorenzo241631", null, "Malave", "cpqj0z8JWr", null, 1, null, null, "Lorenzo.Malave59@nearbpo.com", "Lorenzo" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Naomi421632", null, "Esparza", "htRPGSGchx", null, 1, null, null, "Naomi63@hotmail.com", "Naomi" },
                    { "Federico_Medina221633", null, "Medina", "duFaFm8dkN", null, 1, null, null, "Federico81@hotmail.com", "Federico" },
                    { "Regina_Cervantez1634", null, "Cervántez", "wXQPvLmAnj", null, 1, null, null, "Regina.Cervantez@hotmail.com", "Regina" },
                    { "Cristian_Banda451635", null, "Banda", "IPYV8_Blj0", null, 1, null, null, "Cristian22@yahoo.com", "Cristian" },
                    { "DulceMaria491636", null, "Padrón", "CbshIbPDCR", null, 1, null, null, "DulceMaria_Padron@yahoo.com", "Dulce María" },
                    { "Juan.Garica1637", null, "Garica", "jkAQrV5zaQ", null, 1, null, null, "Juan_Garica@nearbpo.com", "Juan" },
                    { "Matias541638", null, "Castro", "i_OQ4veaOd", null, 1, null, null, "Matias14@corpfolder.com", "Matías" },
                    { "Josefina.Brito651623", null, "Brito", "N48_mqH2st", null, 1, null, null, "Josefina.Brito@corpfolder.com", "Josefina" },
                    { "JoseDaniel.Mendez681622", null, "Méndez", "tTNsn7rKWr", null, 1, null, null, "JoseDaniel_Mendez@gmail.com", "Jose Daniel" },
                    { "Alejandro_Vargas1621", null, "Vargas", "UJjc0lwVYh", null, 1, null, null, "Alejandro19@yahoo.com", "Alejandro" },
                    { "Rafael361620", null, "Urías", "fVnzy63yVs", null, 1, null, null, "Rafael2@gmail.com", "Rafael" },
                    { "Caridad_Mateo1604", null, "Mateo", "TpjqOGyXSu", null, 1, null, null, "Caridad86@nearbpo.com", "Caridad" },
                    { "Natalia.Bonilla141605", null, "Bonilla", "WTOtlOqGpg", null, 1, null, null, "Natalia.Bonilla61@hotmail.com", "Natalia" },
                    { "Brayan831606", null, "Arriaga", "DYioy8ke1Y", null, 1, null, null, "Brayan.Arriaga@nearbpo.com", "Brayan" },
                    { "Julio.Medina241607", null, "Medina", "UEV1q05p8x", null, 1, null, null, "Julio78@corpfolder.com", "Julio" },
                    { "Horacio_Lira111608", null, "Lira", "Lx5LcCmYce", null, 1, null, null, "Horacio_Lira33@corpfolder.com", "Horacio" },
                    { "MariaEugenia211609", null, "Ortega", "t7FlmHJdKJ", null, 1, null, null, "MariaEugenia88@nearbpo.com", "María Eugenia" },
                    { "Natalia541610", null, "Gutiérrez", "DsE0ndFKsm", null, 1, null, null, "Natalia_Gutierrez55@gmail.com", "Natalia" },
                    { "Alexis161602", null, "Tamayo", "KG0FoYb1Qo", null, 1, null, null, "Alexis75@yahoo.com", "Alexis" },
                    { "Leticia.Casarez1611", null, "Casárez", "Paa2awlZ72", null, 1, null, null, "Leticia.Casarez37@nearbpo.com", "Leticia" },
                    { "Ricardo791613", null, "Ponce", "PAOhmdqcUC", null, 1, null, null, "Ricardo_Ponce@nearbpo.com", "Ricardo" },
                    { "Gabriel.Alonso381614", null, "Alonso", "OiqdDIHqCT", null, 1, null, null, "Gabriel_Alonso@gmail.com", "Gabriel" },
                    { "Octavio861615", null, "Miranda", "MDS5li1ZWI", null, 1, null, null, "Octavio.Miranda8@hotmail.com", "Octavio" },
                    { "Maricarmen_Melendez1616", null, "Meléndez", "yqYoMHqsxZ", null, 1, null, null, "Maricarmen21@gmail.com", "Maricarmen" },
                    { "Esmeralda_Feliciano1617", null, "Feliciano", "GxlnIeb2Zi", null, 1, null, null, "Esmeralda_Feliciano98@hotmail.com", "Esmeralda" },
                    { "Claudia.Benavides191618", null, "Benavides", "UlwSe0r2d0", null, 1, null, null, "Claudia_Benavides72@gmail.com", "Claudia" },
                    { "Alexis.Sandoval691619", null, "Sandoval", "jiCZJYNTCu", null, 1, null, null, "Alexis68@corpfolder.com", "Alexis" },
                    { "AnaLuisa.Quiros421612", null, "Quiros", "nwy3rCdMKG", null, 1, null, null, "AnaLuisa72@hotmail.com", "Ana Luisa" },
                    { "Pedro_Alfaro11564", null, "Alfaro", "QgqXygV2q1", null, 1, null, null, "Pedro.Alfaro@yahoo.com", "Pedro" },
                    { "Eva.Arredondo1718", null, "Arredondo", "AjaHiemlki", null, 1, null, null, "Eva.Arredondo20@hotmail.com", "Eva" },
                    { "Andrea_Baeza1720", null, "Baeza", "yfInbrP3_5", null, 1, null, null, "Andrea63@corpfolder.com", "Andrea" },
                    { "Sonia271819", null, "Orosco", "ydbf6G6bA6", null, 1, null, null, "Sonia.Orosco@hotmail.com", "Sonia" },
                    { "Diego_Alonso331820", null, "Alonso", "8WpsyqHByx", null, 1, null, null, "Diego.Alonso81@hotmail.com", "Diego" },
                    { "Gerardo_Arevalo1821", null, "Arevalo", "WxdEunYuyG", null, 1, null, null, "Gerardo.Arevalo47@yahoo.com", "Gerardo" },
                    { "Ramiro351822", null, "Cerda", "Yuf9Np4lAx", null, 1, null, null, "Ramiro94@nearbpo.com", "Ramiro" },
                    { "Victor.Zabaleta921823", null, "Zabaleta", "kQTOEClgjf", null, 1, null, null, "Victor.Zabaleta0@gmail.com", "Víctor" },
                    { "MarcoAntonio_Riojas331824", null, "Riojas", "h8O0vPY2D6", null, 1, null, null, "MarcoAntonio45@nearbpo.com", "Marco Antonio" },
                    { "Melissa_Rosado421825", null, "Rosado", "_md91bi1Kr", null, 1, null, null, "Melissa.Rosado@yahoo.com", "Melissa" },
                    { "Eloisa_Monroy01826", null, "Monroy", "O71gODvQIj", null, 1, null, null, "Eloisa73@gmail.com", "Eloisa" },
                    { "Bernardo241827", null, "Zamudio", "QP_c_5xMp2", null, 1, null, null, "Bernardo_Zamudio@nearbpo.com", "Bernardo" },
                    { "Lourdes801828", null, "Estrada", "aB44Q8Qh65", null, 1, null, null, "Lourdes_Estrada@gmail.com", "Lourdes" },
                    { "Diana991829", null, "Segovia", "_LAZWmruw2", null, 1, null, null, "Diana_Segovia@yahoo.com", "Diana" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Miranda.Kara1830", null, "Kara", "jFcZfpRqvX", null, 1, null, null, "Miranda_Kara@nearbpo.com", "Miranda" },
                    { "Melany.Armas111831", null, "Armas", "XHKiCigUay", null, 1, null, null, "Melany.Armas@corpfolder.com", "Melany" },
                    { "Ivanna231832", null, "Yáñez", "apIDoTMlVK", null, 1, null, null, "Ivanna.Yanez38@hotmail.com", "Ivanna" },
                    { "Beatriz721833", null, "Gutiérrez", "ulsIl3fc7E", null, 1, null, null, "Beatriz.Gutierrez34@nearbpo.com", "Beatriz" },
                    { "Elsa781818", null, "Bueno", "hdj0y00FiK", null, 1, null, null, "Elsa_Bueno@gmail.com", "Elsa" },
                    { "Lorenzo531817", null, "Sisneros", "LhpQ5fdd8M", null, 1, null, null, "Lorenzo.Sisneros20@gmail.com", "Lorenzo" },
                    { "Tomas.Leiva1816", null, "Leiva", "LTZ75I23eW", null, 1, null, null, "Tomas70@hotmail.com", "Tomás" },
                    { "Homero.Espinal1815", null, "Espinal", "qHbloCizLK", null, 1, null, null, "Homero_Espinal51@yahoo.com", "Homero" },
                    { "Florencia_Valdes251799", null, "Valdés", "eV74q0OlCH", null, 1, null, null, "Florencia_Valdes24@corpfolder.com", "Florencia" },
                    { "Aaron_Romo1800", null, "Romo", "540weiYjw3", null, 1, null, null, "Aaron.Romo@gmail.com", "Aarón" },
                    { "Jose_Acuna1801", null, "Acuña", "oxYOEKbVUQ", null, 1, null, null, "Jose57@hotmail.com", "José" },
                    { "Ramiro.Flores1802", null, "Flores", "s0hG1zPEU7", null, 1, null, null, "Ramiro.Flores@hotmail.com", "Ramiro" },
                    { "Ines481803", null, "Mondragón", "TIu8TJVhhQ", null, 1, null, null, "Ines_Mondragon74@yahoo.com", "Inés" },
                    { "MariaTeresa_deAnda81804", null, "de Anda", "0tzawwwgG4", null, 1, null, null, "MariaTeresa.deAnda@nearbpo.com", "María Teresa" },
                    { "Vanessa911805", null, "Cuellar", "iylNnuTeWB", null, 1, null, null, "Vanessa_Cuellar@hotmail.com", "Vanessa" },
                    { "Clara581834", null, "Ponce", "FZePkayJ4f", null, 1, null, null, "Clara13@gmail.com", "Clara" },
                    { "Guillermo121806", null, "Cuellar", "mgn_5VX6jW", null, 1, null, null, "Guillermo15@corpfolder.com", "Guillermo" },
                    { "Reina401808", null, "Muñiz", "9ZyoYKzKOO", null, 1, null, null, "Reina62@corpfolder.com", "Reina" },
                    { "Olivia641809", null, "Alaniz", "8IbkX4rTrQ", null, 1, null, null, "Olivia15@yahoo.com", "Olivia" },
                    { "AngelGabriel_Villarreal461810", null, "Villarreal", "vep1bEKpol", null, 1, null, null, "AngelGabriel.Villarreal39@corpfolder.com", "Ángel Gabriel" },
                    { "Adela_Raya01811", null, "Raya", "80ghj6Tgg0", null, 1, null, null, "Adela_Raya@corpfolder.com", "Adela" },
                    { "Renata.Cordero91812", null, "Cordero", "aX0iSDUWsx", null, 1, null, null, "Renata_Cordero67@corpfolder.com", "Renata" },
                    { "Francisca_Cepeda1813", null, "Cepeda", "fVAYlW9Oc1", null, 1, null, null, "Francisca_Cepeda@gmail.com", "Francisca" },
                    { "Bernardo_Romero691814", null, "Romero", "zBsAa4zMXl", null, 1, null, null, "Bernardo.Romero10@hotmail.com", "Bernardo" },
                    { "Cristobal.Alarcon1807", null, "Alarcón", "d49MYluewr", null, 1, null, null, "Cristobal5@gmail.com", "Cristobal" },
                    { "Leticia311798", null, "Leyva", "07luLk2OJW", null, 1, null, null, "Leticia_Leyva@yahoo.com", "Leticia" },
                    { "Lorena_Pacheco601835", null, "Pacheco", "Cv1aW8tqRF", null, 1, null, null, "Lorena.Pacheco23@hotmail.com", "Lorena" },
                    { "Cecilia.Bahena1837", null, "Bahena", "VVHWaZQCsV", null, 1, null, null, "Cecilia_Bahena14@hotmail.com", "Cecilia" },
                    { "Elias_Solorio831858", null, "Solorio", "nkQAoZxaRH", null, 1, null, null, "Elias.Solorio65@hotmail.com", "Elías" },
                    { "Leonor.Karan261859", null, "Karan", "HrJX7EH35N", null, 1, null, null, "Leonor73@yahoo.com", "Leonor" },
                    { "Ricardo.Rodriquez1860", null, "Rodríquez", "FiE4UZQjUB", null, 1, null, null, "Ricardo.Rodriquez19@yahoo.com", "Ricardo" },
                    { "Luz.Escamilla191861", null, "Escamilla", "zN8YpT2tq0", null, 1, null, null, "Luz67@hotmail.com", "Luz" },
                    { "Carla_Tamayo441862", null, "Tamayo", "ZZL3b2IdBz", null, 1, null, null, "Carla43@yahoo.com", "Carla" },
                    { "Ines.Menendez461863", null, "Menéndez", "oBBLghiPAO", null, 1, null, null, "Ines.Menendez46@hotmail.com", "Inés" },
                    { "Ernesto_Tijerina1864", null, "Tijerina", "vcheSjpYyH", null, 1, null, null, "Ernesto.Tijerina45@corpfolder.com", "Ernesto" },
                    { "Micaela_Padron1865", null, "Padrón", "W6CG_3KCsi", null, 1, null, null, "Micaela.Padron31@hotmail.com", "Micaela" },
                    { "Sancho281866", null, "Miranda", "gkILHxsRBr", null, 1, null, null, "Sancho_Miranda56@yahoo.com", "Sancho" },
                    { "Octavio.Pelayo1867", null, "Pelayo", "MXp_7r4Uks", null, 1, null, null, "Octavio29@yahoo.com", "Octavio" },
                    { "Monica_Zaragoza821868", null, "Zaragoza", "GT2LMATWk0", null, 1, null, null, "Monica_Zaragoza34@hotmail.com", "Mónica" },
                    { "JuanManuel801869", null, "Cabrera", "clrZLO7bJa", null, 1, null, null, "JuanManuel_Cabrera22@corpfolder.com", "Juan Manuel" },
                    { "Jacobo.Castaneda521870", null, "Castañeda", "12iG_D0DpN", null, 1, null, null, "Jacobo_Castaneda@gmail.com", "Jacobo" },
                    { "Leticia.Rodriquez731871", null, "Rodríquez", "RSMoLjYg2a", null, 1, null, null, "Leticia.Rodriquez@corpfolder.com", "Leticia" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Paulina791872", null, "Monroy", "FCJ6YMc1V3", null, 1, null, null, "Paulina.Monroy@nearbpo.com", "Paulina" },
                    { "Clara.Urbina421857", null, "Urbina", "l8fp6DmE6J", null, 1, null, null, "Clara49@gmail.com", "Clara" },
                    { "JulioCesar.Porras1856", null, "Porras", "1nvo0cGfO1", null, 1, null, null, "JulioCesar_Porras11@hotmail.com", "Julio César" },
                    { "Gerardo441855", null, "Acosta", "6EO7yhH5vb", null, 1, null, null, "Gerardo78@nearbpo.com", "Gerardo" },
                    { "Francisca_Granados1854", null, "Granados", "gmME_H63ds", null, 1, null, null, "Francisca.Granados@nearbpo.com", "Francisca" },
                    { "LuisAngel_Otero731838", null, "Otero", "pNIraWq9Nu", null, 1, null, null, "LuisAngel16@nearbpo.com", "Luis Ángel" },
                    { "Liliana.Acosta1839", null, "Acosta", "5gXurMLxvW", null, 1, null, null, "Liliana_Acosta@hotmail.com", "Liliana" },
                    { "Diana741840", null, "Delao", "dRn7i0mlvT", null, 1, null, null, "Diana_Delao67@nearbpo.com", "Diana" },
                    { "Bernardo.Rivas531841", null, "Rivas", "cc63A4Nlt5", null, 1, null, null, "Bernardo54@corpfolder.com", "Bernardo" },
                    { "Natalia_Armas1842", null, "Armas", "WK0krq1Nk9", null, 1, null, null, "Natalia_Armas76@yahoo.com", "Natalia" },
                    { "Yamileth01843", null, "Vega", "Khha3G61i7", null, 1, null, null, "Yamileth.Vega3@nearbpo.com", "Yamileth" },
                    { "Emily341844", null, "Alonzo", "Z5Zhqn6pa1", null, 1, null, null, "Emily.Alonzo@gmail.com", "Emily" },
                    { "MariaElena.Caballero1836", null, "Caballero", "TTV0PzRxGE", null, 1, null, null, "MariaElena_Caballero@nearbpo.com", "María Elena" },
                    { "Julia651845", null, "Rocha", "qWx_vzddWv", null, 1, null, null, "Julia80@gmail.com", "Julia" },
                    { "Ramon.Avila101847", null, "Ávila", "gYKH8hfPgK", null, 1, null, null, "Ramon19@corpfolder.com", "Ramón" },
                    { "Daniela961848", null, "Rascón", "fqpQC2POIM", null, 1, null, null, "Daniela_Rascon@gmail.com", "Daniela" },
                    { "Pilar.Serna1849", null, "Serna", "AX76FV_foW", null, 1, null, null, "Pilar71@nearbpo.com", "Pilar" },
                    { "Soledad_Xicoy1850", null, "Xicoy", "DzNZ1rl7r4", null, 1, null, null, "Soledad_Xicoy@yahoo.com", "Soledad" },
                    { "Raul.Tirado1851", null, "Tirado", "k8VBGs4AOw", null, 1, null, null, "Raul_Tirado31@gmail.com", "Raúl" },
                    { "Alfonso_Alvarado861852", null, "Alvarado", "gfgFpKRpQB", null, 1, null, null, "Alfonso_Alvarado@nearbpo.com", "Alfonso" },
                    { "Gabriela.Mares1853", null, "Mares", "QuzQA4ubpx", null, 1, null, null, "Gabriela_Mares@nearbpo.com", "Gabriela" },
                    { "Rafael.Florez1846", null, "Flórez", "2yp9fAQ5ON", null, 1, null, null, "Rafael_Florez@gmail.com", "Rafael" },
                    { "Mercedes.Nevarez1719", null, "Nevárez", "_u2mHV7wjE", null, 1, null, null, "Mercedes_Nevarez76@gmail.com", "Mercedes" },
                    { "Antonio.Laureano1797", null, "Laureano", "J96uCsZ960", null, 1, null, null, "Antonio_Laureano98@hotmail.com", "Antonio" },
                    { "Susana.Iglesias41795", null, "Iglesias", "5ktQvxTPod", null, 1, null, null, "Susana17@nearbpo.com", "Susana" },
                    { "Ruben331741", null, "Kanzaki", "oJE6dawBX6", null, 1, null, null, "Ruben_Kanzaki57@hotmail.com", "Rubén" },
                    { "Elizabeth81742", null, "Viera", "W7DvXf_Tqu", null, 1, null, null, "Elizabeth.Viera55@nearbpo.com", "Elizabeth" },
                    { "Florencia.Olivares1743", null, "Olivares", "gZJojgMeyD", null, 1, null, null, "Florencia.Olivares@gmail.com", "Florencia" },
                    { "Victoria_Arce781744", null, "Arce", "7lJY5Y6gYy", null, 1, null, null, "Victoria94@yahoo.com", "Victoria" },
                    { "Evelyn_Chacon791745", null, "Chacón", "9nvf5jETb4", null, 1, null, null, "Evelyn83@hotmail.com", "Evelyn" },
                    { "Claudio.Sanchez851746", null, "Sánchez", "F4M744Rhmx", null, 1, null, null, "Claudio_Sanchez@gmail.com", "Claudio" },
                    { "Isaac911747", null, "Velázquez", "4FaxEpVRf1", null, 1, null, null, "Isaac.Velazquez14@yahoo.com", "Isaac" },
                    { "Octavio481748", null, "Gálvez", "pBXMiHukNl", null, 1, null, null, "Octavio_Galvez@yahoo.com", "Octavio" },
                    { "Cristina981749", null, "Merino", "jgoWuH9XVc", null, 1, null, null, "Cristina.Merino@yahoo.com", "Cristina" },
                    { "MariaJose141750", null, "Bueno", "Ukf379d3cp", null, 1, null, null, "MariaJose_Bueno22@nearbpo.com", "María José" },
                    { "Silvia_Trujillo921751", null, "Trujillo", "h4cUJmQk4v", null, 1, null, null, "Silvia65@nearbpo.com", "Silvia" },
                    { "Aaron.Montenegro521752", null, "Montenegro", "4cKVlVjOam", null, 1, null, null, "Aaron_Montenegro25@corpfolder.com", "Aarón" },
                    { "Luisa01753", null, "Guerra", "cje4v0IpH2", null, 1, null, null, "Luisa54@nearbpo.com", "Luisa" },
                    { "Soledad_Paredes1754", null, "Paredes", "CcU51tLuQR", null, 1, null, null, "Soledad.Paredes22@hotmail.com", "Soledad" },
                    { "Nicolas.Candelaria1755", null, "Candelaria", "NtFAqcc83D", null, 1, null, null, "Nicolas.Candelaria@hotmail.com", "Nicolás" },
                    { "Diana_Magana1740", null, "Magaña", "CHeAO8Lp8J", null, 1, null, null, "Diana.Magana60@corpfolder.com", "Diana" },
                    { "Isaac_Marroquin1739", null, "Marroquín", "Reea8WXtum", null, 1, null, null, "Isaac_Marroquin@gmail.com", "Isaac" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Ricardo871738", null, "Colunga", "ajd0wd9GL3", null, 1, null, null, "Ricardo.Colunga@nearbpo.com", "Ricardo" },
                    { "German321737", null, "Almonte", "ahv3psskue", null, 1, null, null, "German_Almonte@yahoo.com", "Germán" },
                    { "MariaFernanda_Resendez911721", null, "Reséndez", "jh0wHCSWed", null, 1, null, null, "MariaFernanda.Resendez@nearbpo.com", "María Fernanda" },
                    { "FranciscoJavier_Riojas1722", null, "Riojas", "vVe8oBbX6j", null, 1, null, null, "FranciscoJavier_Riojas@corpfolder.com", "Francisco Javier" },
                    { "MariaElena.Pantoja521723", null, "Pantoja", "n2UmDV98JP", null, 1, null, null, "MariaElena86@corpfolder.com", "María Elena" },
                    { "Marcos01724", null, "Viera", "yISJAGIgXZ", null, 1, null, null, "Marcos_Viera49@yahoo.com", "Marcos" },
                    { "Paulina_Salinas1725", null, "Salinas", "Q9x2qLbdoV", null, 1, null, null, "Paulina.Salinas59@nearbpo.com", "Paulina" },
                    { "Ivan.Montoya691726", null, "Montoya", "QRQ6CcEQHK", null, 1, null, null, "Ivan_Montoya@hotmail.com", "Ivan" },
                    { "Florencia401727", null, "Salinas", "9enxFvV1P_", null, 1, null, null, "Florencia28@hotmail.com", "Florencia" },
                    { "Benito.Tamayo1756", null, "Tamayo", "1J9wcu0LXn", null, 1, null, null, "Benito.Tamayo@nearbpo.com", "Benito" },
                    { "AnaLuisa.Lira1728", null, "Lira", "95h0FGLk7b", null, 1, null, null, "AnaLuisa17@hotmail.com", "Ana Luisa" },
                    { "Juana_Sevilla261730", null, "Sevilla", "ls5jiskRCV", null, 1, null, null, "Juana3@gmail.com", "Juana" },
                    { "Joaquin.Krasnova1731", null, "Krasnova", "wXSqI5wYb6", null, 1, null, null, "Joaquin.Krasnova71@hotmail.com", "Joaquín" },
                    { "Brandon.Villarreal551732", null, "Villarreal", "Y9Xkx8Y0el", null, 1, null, null, "Brandon_Villarreal@corpfolder.com", "Brandon" },
                    { "RosaMaria661733", null, "Gallardo", "S5KvXcbzAP", null, 1, null, null, "RosaMaria.Gallardo11@corpfolder.com", "Rosa María" },
                    { "Eloisa431734", null, "Salinas", "9LsjQNUi1a", null, 1, null, null, "Eloisa_Salinas@yahoo.com", "Eloisa" },
                    { "Adan711735", null, "Galván", "lYH17lRidt", null, 1, null, null, "Adan38@gmail.com", "Adán" },
                    { "Lucas.Lozada941736", null, "Lozada", "FuCNeFQHNl", null, 1, null, null, "Lucas.Lozada@corpfolder.com", "Lucas" },
                    { "Leonardo.Xicoy371729", null, "Xicoy", "dNxyU2eaTb", null, 1, null, null, "Leonardo.Xicoy@gmail.com", "Leonardo" },
                    { "AngelDaniel431796", null, "Venegas", "fVnP7xM8GE", null, 1, null, null, "AngelDaniel.Venegas42@hotmail.com", "Ángel Daniel" },
                    { "Alberto.Aparicio551757", null, "Aparicio", "xb3IIzfgYQ", null, 1, null, null, "Alberto.Aparicio26@gmail.com", "Alberto" },
                    { "Sebastian.Villarreal1759", null, "Villarreal", "6o9nugdfj1", null, 1, null, null, "Sebastian1@hotmail.com", "Sebastian" },
                    { "Araceli.Villagomez1780", null, "Villagómez", "QKyWkuCSjp", null, 1, null, null, "Araceli17@hotmail.com", "Araceli" },
                    { "Pedro_Barrios131781", null, "Barrios", "iTeMYZO3sF", null, 1, null, null, "Pedro.Barrios83@nearbpo.com", "Pedro" },
                    { "Marcela_Guardado231782", null, "Guardado", "kOy_HkFSn7", null, 1, null, null, "Marcela.Guardado@corpfolder.com", "Marcela" },
                    { "RosaMaria801783", null, "Jáquez", "SszSCDQ9Yl", null, 1, null, null, "RosaMaria.Jaquez@hotmail.com", "Rosa María" },
                    { "Isaias.Tamez751784", null, "Tamez", "xsP6oDFk7Q", null, 1, null, null, "Isaias21@nearbpo.com", "Isaias" },
                    { "Gustavo121785", null, "Domínquez", "ejirkJGkzP", null, 1, null, null, "Gustavo.Dominquez26@hotmail.com", "Gustavo" },
                    { "Fatima.Castro771786", null, "Castro", "5GQUEJW7Bz", null, 1, null, null, "Fatima19@nearbpo.com", "Fatima" },
                    { "Isaias621787", null, "Merino", "Uoe6iCwaQN", null, 1, null, null, "Isaias.Merino@hotmail.com", "Isaias" },
                    { "MariaGuadalupe_Tapia541788", null, "Tapia", "c4nSXTaWW8", null, 1, null, null, "MariaGuadalupe_Tapia@yahoo.com", "María Guadalupe" },
                    { "Nicolas.Abrego1789", null, "Abrego", "gghHahFSPg", null, 1, null, null, "Nicolas.Abrego53@hotmail.com", "Nicolás" },
                    { "Agustin.Carrero1790", null, "Carrero", "8d6Sgsw6SK", null, 1, null, null, "Agustin6@nearbpo.com", "Agustín" },
                    { "Monica.Rolon261791", null, "Rolón", "nbOUYaztal", null, 1, null, null, "Monica.Rolon20@corpfolder.com", "Mónica" },
                    { "Isabel_Valverde391792", null, "Valverde", "g37FbgG7xe", null, 1, null, null, "Isabel.Valverde@gmail.com", "Isabel" },
                    { "Esteban.Casares1793", null, "Casares", "CVlQyv33UR", null, 1, null, null, "Esteban_Casares@nearbpo.com", "Esteban" },
                    { "Elizabeth_Kara341794", null, "Kara", "rQXM9_fIi4", null, 1, null, null, "Elizabeth_Kara65@corpfolder.com", "Elizabeth" },
                    { "Aaron.Rico31779", null, "Rico", "z9pyCDsZi1", null, 1, null, null, "Aaron_Rico13@gmail.com", "Aarón" },
                    { "Claudio_Duarte1778", null, "Duarte", "pNm4iIcpgL", null, 1, null, null, "Claudio.Duarte@gmail.com", "Claudio" },
                    { "Paulina691777", null, "Niño", "9NzzvdFIkq", null, 1, null, null, "Paulina.Nino34@yahoo.com", "Paulina" },
                    { "Alexis_Villalpando1776", null, "Villalpando", "WL6e0UAl10", null, 1, null, null, "Alexis.Villalpando22@hotmail.com", "Alexis" },
                    { "Zoe.Rolon391760", null, "Rolón", "fvZtQVMgQJ", null, 1, null, null, "Zoe_Rolon75@yahoo.com", "Zoe" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Mario.Quintanilla1761", null, "Quintanilla", "lw120MQxCq", null, 1, null, null, "Mario40@yahoo.com", "Mario" },
                    { "Hugo.Manzanares1762", null, "Manzanares", "I_zNfvbyI7", null, 1, null, null, "Hugo.Manzanares@yahoo.com", "Hugo" },
                    { "Uriel.Lebron1763", null, "Lebrón", "ZQ8MNONbSf", null, 1, null, null, "Uriel.Lebron@yahoo.com", "Uriel" },
                    { "Eva381764", null, "Cisneros", "oJwhl7vSJO", null, 1, null, null, "Eva_Cisneros@corpfolder.com", "Eva" },
                    { "MariaSoledad.Corona91765", null, "Corona", "rEJM8dDBDO", null, 1, null, null, "MariaSoledad_Corona29@yahoo.com", "María Soledad" },
                    { "Margarita_Pelayo101766", null, "Pelayo", "fxBOzkxGpM", null, 1, null, null, "Margarita_Pelayo92@yahoo.com", "Margarita" },
                    { "Roberto921758", null, "Piña", "kMaigd0bW1", null, 1, null, null, "Roberto.Pina@corpfolder.com", "Roberto" },
                    { "JoseEduardo.Arriaga921767", null, "Arriaga", "YF3OJeD1de", null, 1, null, null, "JoseEduardo_Arriaga@yahoo.com", "José Eduardo" },
                    { "Barbara.Archuleta781769", null, "Archuleta", "3Q82S_WEWy", null, 1, null, null, "Barbara.Archuleta@gmail.com", "Barbara" },
                    { "JoseDaniel361770", null, "Mondragón", "MUsu6zv6ls", null, 1, null, null, "JoseDaniel8@nearbpo.com", "Jose Daniel" },
                    { "Elisa_Delgadillo151771", null, "Delgadillo", "W7cEwZKRhv", null, 1, null, null, "Elisa67@yahoo.com", "Elisa" },
                    { "MariaEugenia_Castaneda1772", null, "Castañeda", "cWcCmU3KFu", null, 1, null, null, "MariaEugenia_Castaneda@yahoo.com", "María Eugenia" },
                    { "Brayan_Soliz521773", null, "Soliz", "Xiq8dooQUs", null, 1, null, null, "Brayan.Soliz15@yahoo.com", "Brayan" },
                    { "Emmanuel.Gracia751774", null, "Gracia", "T1xOnBwAgl", null, 1, null, null, "Emmanuel_Gracia@nearbpo.com", "Emmanuel" },
                    { "Mariana_Malave841775", null, "Malave", "pyMgiKXFoL", null, 1, null, null, "Mariana_Malave@yahoo.com", "Mariana" },
                    { "Eva371768", null, "Tafoya", "qjkmyABb7k", null, 1, null, null, "Eva.Tafoya73@nearbpo.com", "Eva" },
                    { "Gilberto.Leon1563", null, "León", "uKDf6FIVKb", null, 1, null, null, "Gilberto64@gmail.com", "Gilberto" },
                    { "Teresa_Casillas1562", null, "Casillas", "HMu6h6vDqX", null, 1, null, null, "Teresa_Casillas45@yahoo.com", "Teresa" },
                    { "AnaSofia171561", null, "Ozuna", "Ips09hwGdN", null, 1, null, null, "AnaSofia.Ozuna48@gmail.com", "Ana Sofía" },
                    { "Lola581350", null, "Laureano", "QQmZH_gNrr", null, 1, null, null, "Lola_Laureano@gmail.com", "Lola" },
                    { "Esperanza_Tellez261351", null, "Téllez", "wDzFAkA1zn", null, 1, null, null, "Esperanza_Tellez@nearbpo.com", "Esperanza" },
                    { "AngelDaniel561352", null, "Ocasio", "GVY50xbnkg", null, 1, null, null, "AngelDaniel_Ocasio43@corpfolder.com", "Ángel Daniel" },
                    { "Abraham.Polanco1353", null, "Polanco", "zvbwhnbgfA", null, 1, null, null, "Abraham79@gmail.com", "Abraham" },
                    { "Olivia.Armendariz421354", null, "Armendáriz", "mwdKiRMu5A", null, 1, null, null, "Olivia.Armendariz@gmail.com", "Olivia" },
                    { "Susana41355", null, "Alva", "Am6CqZRWaj", null, 1, null, null, "Susana.Alva26@yahoo.com", "Susana" },
                    { "Gerardo971356", null, "Vera", "KarhfsWEfm", null, 1, null, null, "Gerardo15@gmail.com", "Gerardo" },
                    { "Monserrat_Rodrigez1357", null, "Rodrígez", "Z_4RUt4sl_", null, 1, null, null, "Monserrat.Rodrigez@hotmail.com", "Monserrat" },
                    { "Melissa.Deleon1358", null, "Deleón", "pfXnILSkTT", null, 1, null, null, "Melissa.Deleon18@nearbpo.com", "Melissa" },
                    { "Conchita921359", null, "Ceballos", "QxvArlJzLw", null, 1, null, null, "Conchita.Ceballos@corpfolder.com", "Conchita" },
                    { "Pilar61360", null, "Melgar", "GIDdnqqdvA", null, 1, null, null, "Pilar_Melgar@gmail.com", "Pilar" },
                    { "Micaela.Amador681361", null, "Amador", "eAYHiqsIPS", null, 1, null, null, "Micaela59@yahoo.com", "Micaela" },
                    { "Nicole.Ruiz1362", null, "Ruiz", "ydVODD77mb", null, 1, null, null, "Nicole.Ruiz@nearbpo.com", "Nicole" },
                    { "Laura91363", null, "Magaña", "Bo4tO9jXjU", null, 1, null, null, "Laura0@corpfolder.com", "Laura" },
                    { "Melissa.Angulo1364", null, "Angulo", "cbptMHgjel", null, 1, null, null, "Melissa.Angulo38@hotmail.com", "Melissa" },
                    { "MariaFernanda51349", null, "Vázquez", "KKJba27L1u", null, 1, null, null, "MariaFernanda.Vazquez53@hotmail.com", "María Fernanda" },
                    { "Miguel61348", null, "Krasnova", "n4ykTw778o", null, 1, null, null, "Miguel83@yahoo.com", "Miguel" },
                    { "Benjamin711347", null, "Burgos", "mlXEoLnZvA", null, 1, null, null, "Benjamin.Burgos@hotmail.com", "Benjamín" },
                    { "Eloisa_Rascon981346", null, "Rascón", "BRtsGBUZCl", null, 1, null, null, "Eloisa.Rascon@corpfolder.com", "Eloisa" },
                    { "MariaGuadalupe581330", null, "Abeyta", "OQo4O4h40m", null, 1, null, null, "MariaGuadalupe.Abeyta@gmail.com", "María Guadalupe" },
                    { "Kimberly221331", null, "Botello", "Gx3O6_rkq7", null, 1, null, null, "Kimberly.Botello95@corpfolder.com", "Kimberly" },
                    { "Damian_Becerra731332", null, "Becerra", "Y6pIy8gXNo", null, 1, null, null, "Damian_Becerra39@hotmail.com", "Damián" },
                    { "Martin_Xacon1333", null, "Xacon", "R7jA7dYbZK", null, 1, null, null, "Martin.Xacon21@hotmail.com", "Martín" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Carmen.Sanabria1334", null, "Sanabria", "sKYeePq99y", null, 1, null, null, "Carmen_Sanabria5@yahoo.com", "Carmen" },
                    { "Angela.Delafuente741335", null, "Delafuente", "zCNFOJuDRK", null, 1, null, null, "Angela_Delafuente@corpfolder.com", "Ángela" },
                    { "JoseMiguel_Zavala831336", null, "Zavala", "8TKgyee4FP", null, 1, null, null, "JoseMiguel83@nearbpo.com", "José Miguel" },
                    { "Rodrigo.Lozano1365", null, "Lozano", "wzAKhR6uCj", null, 1, null, null, "Rodrigo.Lozano@nearbpo.com", "Rodrigo" },
                    { "Javier591337", null, "Linares", "XBTzlKrCnt", null, 1, null, null, "Javier.Linares90@hotmail.com", "Javier" },
                    { "Lilia_Carreon121339", null, "Carreón", "BDQoa8Lv8X", null, 1, null, null, "Lilia.Carreon@nearbpo.com", "Lilia" },
                    { "MariaLuisa_Carrera671340", null, "Carrera", "KWfBBU_jJi", null, 1, null, null, "MariaLuisa_Carrera67@hotmail.com", "María Luisa" },
                    { "Diego.Cedillo1341", null, "Cedillo", "R2BjNk21Ps", null, 1, null, null, "Diego53@hotmail.com", "Diego" },
                    { "Claudia851342", null, "Xacon", "RallUzjCe8", null, 1, null, null, "Claudia.Xacon@gmail.com", "Claudia" },
                    { "Ivan561343", null, "Meraz", "LVNmzAU_3p", null, 1, null, null, "Ivan54@gmail.com", "Ivan" },
                    { "Ramon_Cordova841344", null, "Córdova", "2NnuLDXG6I", null, 1, null, null, "Ramon_Cordova@gmail.com", "Ramón" },
                    { "Antonia.Quintairos851345", null, "Quintairos", "djWHd9c7bg", null, 1, null, null, "Antonia_Quintairos58@yahoo.com", "Antonia" },
                    { "Lourdes851338", null, "Medrano", "Fcya5k_RC1", null, 1, null, null, "Lourdes16@nearbpo.com", "Lourdes" },
                    { "Mateo.Marroquin831329", null, "Marroquín", "28B0YBJqBM", null, 1, null, null, "Mateo_Marroquin@gmail.com", "Mateo" },
                    { "Ester_Chavarria311366", null, "Chavarría", "XrEyh7Lw9w", null, 1, null, null, "Ester.Chavarria81@hotmail.com", "Ester" },
                    { "Daniela121368", null, "Pulido", "9Yze7jsonJ", null, 1, null, null, "Daniela.Pulido51@hotmail.com", "Daniela" },
                    { "Alberto.Toro521389", null, "Toro", "F7vqBQF43K", null, 1, null, null, "Alberto_Toro4@hotmail.com", "Alberto" },
                    { "Marcela111390", null, "Véliz", "mqQVcJCvfR", null, 1, null, null, "Marcela.Veliz@nearbpo.com", "Marcela" },
                    { "Mateo671391", null, "Cervantes", "hBRRT1yzGU", null, 1, null, null, "Mateo_Cervantes@yahoo.com", "Mateo" },
                    { "Guadalupe_Cordero1392", null, "Cordero", "A0wAdzIUlI", null, 1, null, null, "Guadalupe_Cordero72@yahoo.com", "Guadalupe" },
                    { "AngelGabriel41393", null, "Merino", "P0EkNxu6nJ", null, 1, null, null, "AngelGabriel45@hotmail.com", "Ángel Gabriel" },
                    { "Guadalupe351394", null, "Angulo", "h22V3m9V1d", null, 1, null, null, "Guadalupe.Angulo0@nearbpo.com", "Guadalupe" },
                    { "Alfonso_Carrasco551395", null, "Carrasco", "mXxr3QZ4G3", null, 1, null, null, "Alfonso53@yahoo.com", "Alfonso" },
                    { "David_Salcedo691396", null, "Salcedo", "8vVJfkCXMI", null, 1, null, null, "David.Salcedo@hotmail.com", "David" },
                    { "Abraham.Escobedo1397", null, "Escobedo", "VQfDouGhrQ", null, 1, null, null, "Abraham_Escobedo77@gmail.com", "Abraham" },
                    { "Mariano541398", null, "Echevarría", "PfI2avh303", null, 1, null, null, "Mariano_Echevarria@hotmail.com", "Mariano" },
                    { "Jacobo_Abreu1399", null, "Abreu", "oCZ8FUCjv2", null, 1, null, null, "Jacobo_Abreu@nearbpo.com", "Jacobo" },
                    { "Matias.Bustos01400", null, "Bustos", "jPorlZUy74", null, 1, null, null, "Matias14@corpfolder.com", "Matías" },
                    { "Jorge631401", null, "Posada", "ip9LRlEKr2", null, 1, null, null, "Jorge_Posada@yahoo.com", "Jorge" },
                    { "Carolina_Vallejo501402", null, "Vallejo", "dvRioTnJw4", null, 1, null, null, "Carolina.Vallejo@yahoo.com", "Carolina" },
                    { "Veronica571403", null, "Sosa", "mNVCWOPdWX", null, 1, null, null, "Veronica.Sosa@yahoo.com", "Verónica" },
                    { "LuisGabino.Delacruz661388", null, "Delacrúz", "K1Rtv50AVe", null, 1, null, null, "LuisGabino_Delacruz@nearbpo.com", "Luis Gabino" },
                    { "AnaSofia_Solano521387", null, "Solano", "EF_9B33mdP", null, 1, null, null, "AnaSofia.Solano45@nearbpo.com", "Ana Sofía" },
                    { "Abril.Varela1386", null, "Varela", "jpEd9W2Z_F", null, 1, null, null, "Abril19@corpfolder.com", "Abril" },
                    { "Lilia701385", null, "Santiago", "oO3XSkpXqE", null, 1, null, null, "Lilia.Santiago43@corpfolder.com", "Lilia" },
                    { "Homero_Quintana1369", null, "Quintana", "efwNWTPn11", null, 1, null, null, "Homero.Quintana89@corpfolder.com", "Homero" },
                    { "Yamileth.Pizarro1370", null, "Pizarro", "oWej3m5m1K", null, 1, null, null, "Yamileth.Pizarro@hotmail.com", "Yamileth" },
                    { "Francisco531371", null, "Elizondo", "SUr0ITCMHA", null, 1, null, null, "Francisco_Elizondo1@yahoo.com", "Francisco" },
                    { "Andres.Melgar1372", null, "Melgar", "bzv0POI5yi", null, 1, null, null, "Andres.Melgar31@corpfolder.com", "Andrés" },
                    { "Barbara.Venegas1373", null, "Venegas", "Yi9ggpeovi", null, 1, null, null, "Barbara_Venegas@gmail.com", "Barbara" },
                    { "Lizbeth.Kortahernandez371374", null, "Korta hernandez", "DBGRWGWNlR", null, 1, null, null, "Lizbeth62@corpfolder.com", "Lizbeth" },
                    { "Antonio61375", null, "Villaseñor", "_NMURG0OxA", null, 1, null, null, "Antonio.Villasenor10@hotmail.com", "Antonio" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "JoseMiguel.Kamat851367", null, "Kamat", "HZt9tn3drt", null, 1, null, null, "JoseMiguel.Kamat59@gmail.com", "José Miguel" },
                    { "Fernando181376", null, "Navarro", "HHMYOqUxaK", null, 1, null, null, "Fernando_Navarro@gmail.com", "Fernando" },
                    { "Gael_Aguilera1378", null, "Aguilera", "p6lbh0RULy", null, 1, null, null, "Gael.Aguilera@yahoo.com", "Gael" },
                    { "Araceli.Lugo321379", null, "Lugo", "aIH48MADX3", null, 1, null, null, "Araceli_Lugo@hotmail.com", "Araceli" },
                    { "Elvira.Sanchez1380", null, "Sánchez", "f_k9YB3GMv", null, 1, null, null, "Elvira_Sanchez@nearbpo.com", "Elvira" },
                    { "Melissa.Zayas1381", null, "Zayas", "35ACgtM5Mn", null, 1, null, null, "Melissa78@gmail.com", "Melissa" },
                    { "Berta_Avalos311382", null, "Ávalos", "_fESc6JUy4", null, 1, null, null, "Berta_Avalos50@yahoo.com", "Berta" },
                    { "Rocio.Colon1383", null, "Colón", "HNNNFNPPCe", null, 1, null, null, "Rocio6@hotmail.com", "Rocio" },
                    { "Francisco991384", null, "Lebrón", "rSc32dIRwv", null, 1, null, null, "Francisco56@gmail.com", "Francisco" },
                    { "Virginia.Altamirano1377", null, "Altamirano", "xM50uAs7r6", null, 1, null, null, "Virginia49@corpfolder.com", "Virginia" },
                    { "Cesar_Henriquez131404", null, "Henríquez", "pZzFPC06V1", null, 1, null, null, "Cesar_Henriquez23@gmail.com", "César" },
                    { "Debora591328", null, "Domínguez", "G531L5trBb", null, 1, null, null, "Debora78@nearbpo.com", "Débora" },
                    { "Ricardo731326", null, "Estévez", "fT7JKv_ZD0", null, 1, null, null, "Ricardo.Estevez@yahoo.com", "Ricardo" },
                    { "Renata_Roybal1272", null, "Roybal", "yZ6vTBLGnF", null, 1, null, null, "Renata_Roybal@hotmail.com", "Renata" },
                    { "FranciscoJavier.Sedillo821273", null, "Sedillo", "vUSTsE3CF7", null, 1, null, null, "FranciscoJavier.Sedillo@corpfolder.com", "Francisco Javier" },
                    { "Isabela151274", null, "Kuzmina", "R8qRbGZ1VZ", null, 1, null, null, "Isabela.Kuzmina13@corpfolder.com", "Isabela" },
                    { "Iker_Jaime1275", null, "Jaime", "jHlq1CFIKa", null, 1, null, null, "Iker.Jaime@hotmail.com", "Iker" },
                    { "Debora.Carranza781276", null, "Carranza", "psfTKsbLd_", null, 1, null, null, "Debora_Carranza89@yahoo.com", "Débora" },
                    { "Blanca.Covarrubias41277", null, "Covarrubias", "2dmAQGJrRR", null, 1, null, null, "Blanca_Covarrubias@hotmail.com", "Blanca" },
                    { "Joaquin_Kano1278", null, "Kano", "u_fV2FzPeB", null, 1, null, null, "Joaquin81@nearbpo.com", "Joaquín" },
                    { "Clara91279", null, "Valles", "02Yh1Quwaj", null, 1, null, null, "Clara.Valles72@gmail.com", "Clara" },
                    { "Eloisa421280", null, "Arellano", "p5bJG23k3J", null, 1, null, null, "Eloisa.Arellano1@hotmail.com", "Eloisa" },
                    { "Hernan391281", null, "Delagarza", "lzjwmHWzps", null, 1, null, null, "Hernan.Delagarza63@gmail.com", "Hernán" },
                    { "Lola.Quinta701282", null, "Quinta", "AjdaeGh1wK", null, 1, null, null, "Lola_Quinta59@yahoo.com", "Lola" },
                    { "JoseLuis211283", null, "Sedillo", "to6BwReL1k", null, 1, null, null, "JoseLuis30@gmail.com", "José Luis" },
                    { "Debora.Dominquez261284", null, "Domínquez", "mixHEtS9VQ", null, 1, null, null, "Debora8@gmail.com", "Débora" },
                    { "Mercedes.Kadarrodriguez911285", null, "Kadar rodriguez", "f_cSCglKIO", null, 1, null, null, "Mercedes.Kadarrodriguez@yahoo.com", "Mercedes" },
                    { "Ernesto.Sevilla631286", null, "Sevilla", "heLyBnC2ga", null, 1, null, null, "Ernesto_Sevilla@corpfolder.com", "Ernesto" },
                    { "Elizabeth_Mateo121271", null, "Mateo", "hB3ZJEFRxG", null, 1, null, null, "Elizabeth.Mateo9@yahoo.com", "Elizabeth" },
                    { "Tomas491270", null, "León", "6m0Lq9Ky8F", null, 1, null, null, "Tomas81@yahoo.com", "Tomás" },
                    { "Eva_Paz431269", null, "Paz", "jtnvTxSm8m", null, 1, null, null, "Eva76@hotmail.com", "Eva" },
                    { "AngelGabriel_Vaca1268", null, "Vaca", "avAozHRVV0", null, 1, null, null, "AngelGabriel87@nearbpo.com", "Ángel Gabriel" },
                    { "Ivan_Gil1252", null, "Gil", "Q0RlPQnFBf", null, 1, null, null, "Ivan.Gil@corpfolder.com", "Ivan" },
                    { "Yamileth_Candelaria1253", null, "Candelaria", "K3CeKfQbew", null, 1, null, null, "Yamileth.Candelaria@nearbpo.com", "Yamileth" },
                    { "Francisca871254", null, "Montaño", "wN40ueuI6b", null, 1, null, null, "Francisca.Montano64@hotmail.com", "Francisca" },
                    { "Concepcion.Ybarra1255", null, "Ybarra", "tTtfemQOFP", null, 1, null, null, "Concepcion.Ybarra@hotmail.com", "Concepción" },
                    { "Rosario.Archuleta1256", null, "Archuleta", "yC_JcDTpO0", null, 1, null, null, "Rosario49@nearbpo.com", "Rosario" },
                    { "Guillermina.Quinterocruz691257", null, "Quintero cruz", "byO9Dbwqfl", null, 1, null, null, "Guillermina92@gmail.com", "Guillermina" },
                    { "Guadalupe651258", null, "Roldán", "VTJh8zQBit", null, 1, null, null, "Guadalupe_Roldan@gmail.com", "Guadalupe" },
                    { "Mario_Carbajal291287", null, "Carbajal", "OAm4tci_El", null, 1, null, null, "Mario55@nearbpo.com", "Mario" },
                    { "Alejandra.Rios1259", null, "Ríos", "vttwIIDRCy", null, 1, null, null, "Alejandra_Rios@corpfolder.com", "Alejandra" },
                    { "Veronica_Castaneda591261", null, "Castañeda", "zFycoqY9LP", null, 1, null, null, "Veronica.Castaneda39@nearbpo.com", "Verónica" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Esmeralda941262", null, "Fierro", "aDRz8RaoKj", null, 1, null, null, "Esmeralda9@gmail.com", "Esmeralda" },
                    { "Mercedes_Adorno1263", null, "Adorno", "BJCI6ysWVF", null, 1, null, null, "Mercedes.Adorno@corpfolder.com", "Mercedes" },
                    { "Carla.Valdes411264", null, "Valdés", "CaBO8R4Dde", null, 1, null, null, "Carla_Valdes31@hotmail.com", "Carla" },
                    { "JorgeLuis.Acuna1265", null, "Acuña", "7ts9qCKsia", null, 1, null, null, "JorgeLuis_Acuna81@corpfolder.com", "Jorge Luis" },
                    { "XimenaGuadalupe141266", null, "Jaimes", "C1D0HqxeUj", null, 1, null, null, "XimenaGuadalupe73@corpfolder.com", "Ximena Guadalupe" },
                    { "JoseEduardo_Batista1267", null, "Batista", "hOzJfoj8Af", null, 1, null, null, "JoseEduardo.Batista@gmail.com", "José Eduardo" },
                    { "Benito.Santana891260", null, "Santana", "hCfN2pIFUf", null, 1, null, null, "Benito_Santana44@hotmail.com", "Benito" },
                    { "Josefina_Manzanares1327", null, "Manzanares", "z3dlRdGbW3", null, 1, null, null, "Josefina.Manzanares89@hotmail.com", "Josefina" },
                    { "Joaquin_Rangel1288", null, "Rangel", "PtVI9gfwOT", null, 1, null, null, "Joaquin71@nearbpo.com", "Joaquín" },
                    { "JulioCesar.Ballesteros301290", null, "Ballesteros", "VDLL9rLyuF", null, 1, null, null, "JulioCesar_Ballesteros@yahoo.com", "Julio César" },
                    { "Estefania.Kanimal1311", null, "Kanimal", "ItbM4jNNny", null, 1, null, null, "Estefania_Kanimal@gmail.com", "Estefanía" },
                    { "Barbara861312", null, "Romero", "yRAtmCupd0", null, 1, null, null, "Barbara.Romero@yahoo.com", "Barbara" },
                    { "Alan101313", null, "Acosta", "vGQuSrvRlr", null, 1, null, null, "Alan.Acosta79@hotmail.com", "Alan" },
                    { "Sancho_Munoz1314", null, "Muñoz", "qHNcmMnZ9g", null, 1, null, null, "Sancho61@yahoo.com", "Sancho" },
                    { "Liliana_Gollum1315", null, "Gollum", "ewc2PEIJ8F", null, 1, null, null, "Liliana23@nearbpo.com", "Liliana" },
                    { "Ana.Alvarado571316", null, "Alvarado", "Suy4bh1yOi", null, 1, null, null, "Ana50@gmail.com", "Ana" },
                    { "Rafael_Berrios1317", null, "Berríos", "5xn_5KcRk5", null, 1, null, null, "Rafael32@gmail.com", "Rafael" },
                    { "Marta651318", null, "Aguilera", "Nz7CLdVcXn", null, 1, null, null, "Marta_Aguilera91@corpfolder.com", "Marta" },
                    { "JorgeLuis131319", null, "Cornejo", "CURJQXBGqz", null, 1, null, null, "JorgeLuis_Cornejo96@corpfolder.com", "Jorge Luis" },
                    { "Emilio_Coronado241320", null, "Coronado", "HoneUWjPAF", null, 1, null, null, "Emilio_Coronado4@yahoo.com", "Emilio" },
                    { "Abigail_Xicoy711321", null, "Xicoy", "UC6qkF0dP6", null, 1, null, null, "Abigail46@corpfolder.com", "Abigail" },
                    { "Beatriz691322", null, "Frías", "5nCJw8292p", null, 1, null, null, "Beatriz_Frias@nearbpo.com", "Beatriz" },
                    { "Sergio.Kara341323", null, "Kara", "iG7KSqjQ2L", null, 1, null, null, "Sergio.Kara34@yahoo.com", "Sergio" },
                    { "AnaMaria.Arias1324", null, "Arias", "yciP4pM6fP", null, 1, null, null, "AnaMaria_Arias@corpfolder.com", "Ana María" },
                    { "Cristina841325", null, "Sanabria", "36Lu9kP2yo", null, 1, null, null, "Cristina_Sanabria13@corpfolder.com", "Cristina" },
                    { "Gloria_Aguilera1310", null, "Aguilera", "OrJlve8pWr", null, 1, null, null, "Gloria.Aguilera91@yahoo.com", "Gloria" },
                    { "Tadeo.Rodarte861309", null, "Rodarte", "PchepRjpU8", null, 1, null, null, "Tadeo_Rodarte@corpfolder.com", "Tadeo" },
                    { "Sergio651308", null, "Colón", "_Q2yVFL7Z2", null, 1, null, null, "Sergio40@gmail.com", "Sergio" },
                    { "Melissa_Perales1307", null, "Perales", "aCL3qkeqkS", null, 1, null, null, "Melissa.Perales@corpfolder.com", "Melissa" },
                    { "Claudio.Cruz281291", null, "Cruz", "WcxJTUcNVh", null, 1, null, null, "Claudio98@hotmail.com", "Claudio" },
                    { "AngelGabriel481292", null, "Rivas", "_tSDXTi_Rw", null, 1, null, null, "AngelGabriel63@nearbpo.com", "Ángel Gabriel" },
                    { "Gloria_Espino621293", null, "Espino", "BW65Ot59H9", null, 1, null, null, "Gloria.Espino@yahoo.com", "Gloria" },
                    { "Estela_Quezada481294", null, "Quezada", "5vrEAgTHHC", null, 1, null, null, "Estela_Quezada@corpfolder.com", "Estela" },
                    { "Marta91295", null, "Karen", "94vAcx_qgK", null, 1, null, null, "Marta_Karen@nearbpo.com", "Marta" },
                    { "MiguelAngel.Fonseca1296", null, "Fonseca", "5SW74OrDnz", null, 1, null, null, "MiguelAngel_Fonseca@nearbpo.com", "Miguel Ángel" },
                    { "Alexa511297", null, "Valdés", "BaiUHvK0_8", null, 1, null, null, "Alexa81@nearbpo.com", "Alexa" },
                    { "Martin_Yanez561289", null, "Yáñez", "8z5qNgUVVV", null, 1, null, null, "Martin_Yanez@corpfolder.com", "Martín" },
                    { "Andres321298", null, "Lozano", "HlLCxFLwkT", null, 1, null, null, "Andres.Lozano@gmail.com", "Andrés" },
                    { "Rafael391300", null, "Mireles", "Cf0FGRouSi", null, 1, null, null, "Rafael_Mireles@nearbpo.com", "Rafael" },
                    { "Clemente941301", null, "Lira", "nXVpWdfdbM", null, 1, null, null, "Clemente_Lira30@gmail.com", "Clemente" },
                    { "Yamileth_Vega661302", null, "Vega", "rjmZs07aSU", null, 1, null, null, "Yamileth97@nearbpo.com", "Yamileth" },
                    { "Marilu.Rojo241303", null, "Rojo", "Wyb2zLczny", null, 1, null, null, "Marilu_Rojo59@hotmail.com", "Marilu" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Melany_Centeno701304", null, "Centeno", "6gYdU4SDNK", null, 1, null, null, "Melany85@hotmail.com", "Melany" },
                    { "Jimena31305", null, "Barreto", "247W5ZRrcr", null, 1, null, null, "Jimena46@yahoo.com", "Jimena" },
                    { "Saul.Sierra1306", null, "Sierra", "F4qCn1OHCb", null, 1, null, null, "Saul97@yahoo.com", "Saúl" },
                    { "Blanca.Tamez911299", null, "Tamez", "WuwwBasF37", null, 1, null, null, "Blanca53@nearbpo.com", "Blanca" },
                    { "Monica_Burgos1405", null, "Burgos", "7ponttFspq", null, 1, null, null, "Monica.Burgos82@nearbpo.com", "Mónica" },
                    { "Nicole831406", null, "Juárez", "GpnikIChWE", null, 1, null, null, "Nicole.Juarez20@gmail.com", "Nicole" },
                    { "Jacobo_Ocampo291407", null, "Ocampo", "1ilJHuiooX", null, 1, null, null, "Jacobo_Ocampo90@yahoo.com", "Jacobo" },
                    { "Sofia_Ortega531507", null, "Ortega", "M1vD8UF8JE", null, 1, null, null, "Sofia.Ortega4@nearbpo.com", "Sofia" },
                    { "Ignacio.deAnda341508", null, "de Anda", "BSVqlpO18v", null, 1, null, null, "Ignacio33@nearbpo.com", "Ignacio" },
                    { "Isaac551509", null, "Sepúlveda", "v2zCNBA9xm", null, 1, null, null, "Isaac70@corpfolder.com", "Isaac" },
                    { "Alejandro_Fierro111510", null, "Fierro", "WVF271CyGW", null, 1, null, null, "Alejandro.Fierro@nearbpo.com", "Alejandro" },
                    { "Homero.Gonzales571511", null, "Gonzales", "y8dQxPbPds", null, 1, null, null, "Homero16@hotmail.com", "Homero" },
                    { "Gregorio981512", null, "Corrales", "Dmh3HZnNv7", null, 1, null, null, "Gregorio_Corrales@yahoo.com", "Gregorio" },
                    { "Ernesto.Varela1513", null, "Varela", "svckL7vT3e", null, 1, null, null, "Ernesto.Varela@yahoo.com", "Ernesto" },
                    { "Tomas511514", null, "Villarreal", "bx8v1XHLmN", null, 1, null, null, "Tomas0@hotmail.com", "Tomás" },
                    { "Ruben_Zabaleta571515", null, "Zabaleta", "FMans5AxgR", null, 1, null, null, "Ruben_Zabaleta@hotmail.com", "Rubén" },
                    { "Emmanuel.Gallardo1516", null, "Gallardo", "mnI868cjlM", null, 1, null, null, "Emmanuel26@nearbpo.com", "Emmanuel" },
                    { "Andres.Farias1517", null, "Farías", "R6GprecSaN", null, 1, null, null, "Andres74@hotmail.com", "Andrés" },
                    { "Monica.Espinal521518", null, "Espinal", "0YiLlrtUxj", null, 1, null, null, "Monica29@gmail.com", "Mónica" },
                    { "Catalina291519", null, "Rico", "Q8U_Rcqilh", null, 1, null, null, "Catalina17@gmail.com", "Catalina" },
                    { "Emilio191520", null, "Partida", "e82UsfmaBv", null, 1, null, null, "Emilio5@corpfolder.com", "Emilio" },
                    { "Zoe.Arriaga791521", null, "Arriaga", "BAI8Pl6qwa", null, 1, null, null, "Zoe.Arriaga22@hotmail.com", "Zoe" },
                    { "Octavio.Martinez91506", null, "Martínez", "BD9SOf1hH4", null, 1, null, null, "Octavio.Martinez51@nearbpo.com", "Octavio" },
                    { "Virginia.Ocampo1505", null, "Ocampo", "foClg2tQvU", null, 1, null, null, "Virginia_Ocampo@gmail.com", "Virginia" },
                    { "Esperanza.Cedillo1504", null, "Cedillo", "0olXlWpJ6t", null, 1, null, null, "Esperanza_Cedillo73@nearbpo.com", "Esperanza" },
                    { "Sergio901503", null, "Moreno", "tQbbXiBdIo", null, 1, null, null, "Sergio.Moreno64@corpfolder.com", "Sergio" },
                    { "Samuel_Valentin1487", null, "Valentín", "hW8Gt0TQNm", null, 1, null, null, "Samuel28@nearbpo.com", "Samuel" },
                    { "Benito.Laboy901488", null, "Laboy", "Gz_pa2oNdQ", null, 1, null, null, "Benito_Laboy52@yahoo.com", "Benito" },
                    { "Gonzalo_Iglesias621489", null, "Iglesias", "iEv5KqIBp4", null, 1, null, null, "Gonzalo_Iglesias@hotmail.com", "Gonzalo" },
                    { "Mayte.Garibay1490", null, "Garibay", "NIMVgIrONs", null, 1, null, null, "Mayte77@gmail.com", "Mayte" },
                    { "German_Carrero621491", null, "Carrero", "dZeBusTd4e", null, 1, null, null, "German76@yahoo.com", "Germán" },
                    { "Julio.Irizarry1492", null, "Irizarry", "StMJ5K80UC", null, 1, null, null, "Julio_Irizarry86@gmail.com", "Julio" },
                    { "Victoria_Guevara1493", null, "Guevara", "IuMG39nqdt", null, 1, null, null, "Victoria_Guevara19@yahoo.com", "Victoria" },
                    { "Kimberly_Quevedo1522", null, "Quevedo", "31CfJ2gU1U", null, 1, null, null, "Kimberly_Quevedo11@hotmail.com", "Kimberly" },
                    { "VictorManuel91494", null, "Reynoso", "EONexbMm5f", null, 1, null, null, "VictorManuel_Reynoso64@hotmail.com", "Victor Manuel" },
                    { "Cristobal.Vega1496", null, "Vega", "RTmsvuFgXF", null, 1, null, null, "Cristobal44@nearbpo.com", "Cristobal" },
                    { "Micaela941497", null, "Muñiz", "UZHcmjLON0", null, 1, null, null, "Micaela80@yahoo.com", "Micaela" },
                    { "Timoteo_Fajardo1498", null, "Fajardo", "9M5xVM597j", null, 1, null, null, "Timoteo_Fajardo49@corpfolder.com", "Timoteo" },
                    { "Florencia.Cardenas771499", null, "Cardenas", "bn_zRdMmpt", null, 1, null, null, "Florencia_Cardenas@yahoo.com", "Florencia" },
                    { "Alan_Delagarza391500", null, "Delagarza", "SIeS5gsUUe", null, 1, null, null, "Alan.Delagarza@yahoo.com", "Alan" },
                    { "Ximena.Almonte1501", null, "Almonte", "mWJWrAr9E9", null, 1, null, null, "Ximena_Almonte@gmail.com", "Ximena" },
                    { "Andrea.Puga1502", null, "Puga", "WNvrqT2b1L", null, 1, null, null, "Andrea76@gmail.com", "Andrea" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Andres911495", null, "Aguirre", "gO6pBwIwd8", null, 1, null, null, "Andres_Aguirre@nearbpo.com", "Andrés" },
                    { "Isaac_Luevano1486", null, "Luevano", "biMInly84b", null, 1, null, null, "Isaac53@gmail.com", "Isaac" },
                    { "Julieta.Rincon1523", null, "Rincón", "RrcDJeXS5W", null, 1, null, null, "Julieta90@gmail.com", "Julieta" },
                    { "Jazmin.Muro1525", null, "Muro", "qOBX7U2Dkg", null, 1, null, null, "Jazmin_Muro@nearbpo.com", "Jazmin" },
                    { "Jorge851546", null, "Lugo", "CQpjgEb8_u", null, 1, null, null, "Jorge.Lugo@gmail.com", "Jorge" },
                    { "AnaSofia121547", null, "Carvajal", "MhSjBArLwT", null, 1, null, null, "AnaSofia2@yahoo.com", "Ana Sofía" },
                    { "Ramon171548", null, "Uribe", "VLcuRxiZAv", null, 1, null, null, "Ramon.Uribe40@yahoo.com", "Ramón" },
                    { "Patricio.Ramirez1549", null, "Ramírez", "iD46RazGvJ", null, 1, null, null, "Patricio_Ramirez97@gmail.com", "Patricio" },
                    { "Adan.Ocampo861550", null, "Ocampo", "18oJUG8R8M", null, 1, null, null, "Adan_Ocampo95@yahoo.com", "Adán" },
                    { "Debora_Zepeda1551", null, "Zepeda", "Faf2R8Q6JS", null, 1, null, null, "Debora_Zepeda@corpfolder.com", "Débora" },
                    { "Natalia_Arellano751552", null, "Arellano", "4LmiEVjnJJ", null, 1, null, null, "Natalia1@gmail.com", "Natalia" },
                    { "MariaGuadalupe_Gollum1553", null, "Gollum", "YauH2diIyo", null, 1, null, null, "MariaGuadalupe.Gollum@yahoo.com", "María Guadalupe" },
                    { "Roberto381554", null, "Delagarza", "vZSHhluSWq", null, 1, null, null, "Roberto.Delagarza@gmail.com", "Roberto" },
                    { "Emilio_Rendon1555", null, "Rendón", "BDOKRd15jr", null, 1, null, null, "Emilio_Rendon48@hotmail.com", "Emilio" },
                    { "Aaron_Carrasquillo1556", null, "Carrasquillo", "F3cbzLtT6W", null, 1, null, null, "Aaron.Carrasquillo@gmail.com", "Aarón" },
                    { "AlondraRomina341557", null, "Peña", "3EL6HNKz2p", null, 1, null, null, "AlondraRomina_Pena@gmail.com", "Alondra Romina" },
                    { "Cristobal_Amador1558", null, "Amador", "sT5f0O3VC1", null, 1, null, null, "Cristobal24@hotmail.com", "Cristobal" },
                    { "Adriana_Abreu1559", null, "Abreu", "Nm52w7mpHN", null, 1, null, null, "Adriana.Abreu38@gmail.com", "Adriana" },
                    { "Cesar461560", null, "Barela", "tsJ6U6SuBE", null, 1, null, null, "Cesar.Barela@hotmail.com", "César" },
                    { "Esmeralda.Barragan401545", null, "Barragán", "TuTlTGX_NS", null, 1, null, null, "Esmeralda.Barragan@hotmail.com", "Esmeralda" },
                    { "JuanPablo451544", null, "Perales", "8N5f6LfvDp", null, 1, null, null, "JuanPablo19@hotmail.com", "Juan Pablo" },
                    { "Maria841543", null, "Abeyta", "7fGnZM18Um", null, 1, null, null, "Maria.Abeyta74@hotmail.com", "María" },
                    { "Isaac.Velasco1542", null, "Velasco", "37ho4L1X9d", null, 1, null, null, "Isaac.Velasco43@hotmail.com", "Isaac" },
                    { "AnaMaria921526", null, "Delacrúz", "bbgM2T0CIU", null, 1, null, null, "AnaMaria_Delacruz@yahoo.com", "Ana María" },
                    { "Ivanna_Pelayo701527", null, "Pelayo", "AE9KqLX05J", null, 1, null, null, "Ivanna.Pelayo@hotmail.com", "Ivanna" },
                    { "MiguelAngel191528", null, "Castellanos", "DrA1VW5T4f", null, 1, null, null, "MiguelAngel_Castellanos@hotmail.com", "Miguel Ángel" },
                    { "Matias.Espino301529", null, "Espino", "e3jLBP5ZR9", null, 1, null, null, "Matias_Espino12@hotmail.com", "Matías" },
                    { "Daniel_Palacios1530", null, "Palacios", "INCt8lVq9W", null, 1, null, null, "Daniel.Palacios16@nearbpo.com", "Daniel" },
                    { "Melany981531", null, "Amaya", "U3okDbpC8E", null, 1, null, null, "Melany_Amaya@gmail.com", "Melany" },
                    { "Gabriela.Alcantar1532", null, "Alcántar", "Ql1lJCcmg7", null, 1, null, null, "Gabriela.Alcantar@nearbpo.com", "Gabriela" },
                    { "Manuel631524", null, "Yago", "hxx1ypgL4V", null, 1, null, null, "Manuel75@nearbpo.com", "Manuel" },
                    { "Xochitl_Santacruz1533", null, "Santacruz", "eSIGDoo4YV", null, 1, null, null, "Xochitl.Santacruz1@hotmail.com", "Xochitl" },
                    { "JoseLuis21535", null, "Meraz", "dGYgdtSpul", null, 1, null, null, "JoseLuis89@nearbpo.com", "José Luis" },
                    { "Lorena.Matias381536", null, "Matías", "XfdrfYeUzB", null, 1, null, null, "Lorena27@yahoo.com", "Lorena" },
                    { "Claudia_Concepcion251537", null, "Concepción", "CNAA26LaDf", null, 1, null, null, "Claudia.Concepcion@hotmail.com", "Claudia" },
                    { "Abraham_Acuna161538", null, "Acuña", "R092VHjjdx", null, 1, null, null, "Abraham.Acuna93@hotmail.com", "Abraham" },
                    { "Lorena_Gaytan1539", null, "Gaytán", "sUGAS_NKvC", null, 1, null, null, "Lorena.Gaytan@yahoo.com", "Lorena" },
                    { "MariaCristina961540", null, "Santana", "tlz7cKT6Em", null, 1, null, null, "MariaCristina.Santana60@yahoo.com", "María Cristina" },
                    { "MariaGuadalupe_Manzanares321541", null, "Manzanares", "saQEZJLjoR", null, 1, null, null, "MariaGuadalupe_Manzanares@nearbpo.com", "María Guadalupe" },
                    { "MariadelosAngeles.Torrez661534", null, "Tórrez", "B0fpzbkUZr", null, 1, null, null, "MariadelosAngeles_Torrez@corpfolder.com", "María de los Ángeles" },
                    { "Gonzalo.Delarosa1485", null, "Delarosa", "ozNevygNMw", null, 1, null, null, "Gonzalo82@corpfolder.com", "Gonzalo" },
                    { "Enrique.Rubio1484", null, "Rubio", "ERXxi7OMwR", null, 1, null, null, "Enrique.Rubio@corpfolder.com", "Enrique" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Francisca.Matias1483", null, "Matías", "57ySeYwf0T", null, 1, null, null, "Francisca_Matias@hotmail.com", "Francisca" },
                    { "Estefania521428", null, "Prado", "afgWt48kxl", null, 1, null, null, "Estefania74@hotmail.com", "Estefanía" },
                    { "Dolores691429", null, "Salas", "s2B3UAZFh0", null, 1, null, null, "Dolores.Salas@corpfolder.com", "Dolores" },
                    { "Claudio_Casas621430", null, "Casas", "tv4HN51sKq", null, 1, null, null, "Claudio.Casas@gmail.com", "Claudio" },
                    { "Esmeralda_Jaimes441431", null, "Jaimes", "FD6wpZm_WQ", null, 1, null, null, "Esmeralda90@hotmail.com", "Esmeralda" },
                    { "Rafael961432", null, "Aguayo", "xLBM5P_x8N", null, 1, null, null, "Rafael_Aguayo33@corpfolder.com", "Rafael" },
                    { "Carlota_Yebra1433", null, "Yebra", "jLgpcJXeI6", null, 1, null, null, "Carlota.Yebra@nearbpo.com", "Carlota" },
                    { "Alexis_Riojas311434", null, "Riojas", "XhbIIcEFCt", null, 1, null, null, "Alexis_Riojas91@gmail.com", "Alexis" },
                    { "MariaElena_Lerma1435", null, "Lerma", "yqum7O4cG8", null, 1, null, null, "MariaElena49@gmail.com", "María Elena" },
                    { "Ignacio331436", null, "Mercado", "Biq6dieHyK", null, 1, null, null, "Ignacio0@gmail.com", "Ignacio" },
                    { "Melissa.Rosado411437", null, "Rosado", "TXNiDB0EjW", null, 1, null, null, "Melissa17@corpfolder.com", "Melissa" },
                    { "Mateo581438", null, "Lira", "2IWzkualNx", null, 1, null, null, "Mateo.Lira54@hotmail.com", "Mateo" },
                    { "Emilio_Aguirre671439", null, "Aguirre", "WYng6pubSs", null, 1, null, null, "Emilio16@yahoo.com", "Emilio" },
                    { "Maria.Miramontes841440", null, "Miramontes", "Cv1ZMNW7Bw", null, 1, null, null, "Maria75@hotmail.com", "María" },
                    { "Micaela891441", null, "Armas", "BwIBuaox2V", null, 1, null, null, "Micaela_Armas95@corpfolder.com", "Micaela" },
                    { "Antonia.Covarrubias411442", null, "Covarrubias", "PDqPxNL_sh", null, 1, null, null, "Antonia.Covarrubias@gmail.com", "Antonia" },
                    { "Eloisa.Yunta1427", null, "Yunta", "rBuh05QhCG", null, 1, null, null, "Eloisa_Yunta@corpfolder.com", "Eloisa" },
                    { "Isaac_Estrada1426", null, "Estrada", "UCzuqkylLw", null, 1, null, null, "Isaac_Estrada77@corpfolder.com", "Isaac" },
                    { "David_Nieto1425", null, "Nieto", "9dbrJbDLST", null, 1, null, null, "David.Nieto@corpfolder.com", "David" },
                    { "DulceMaria51424", null, "Cavazos", "MzhuPC86O9", null, 1, null, null, "DulceMaria.Cavazos@gmail.com", "Dulce María" },
                    { "Isaac.Escalante1408", null, "Escalante", "xCKKukQ6lV", null, 1, null, null, "Isaac.Escalante@yahoo.com", "Isaac" },
                    { "Marcos581409", null, "Frías", "vKYPVHk1Bb", null, 1, null, null, "Marcos71@yahoo.com", "Marcos" },
                    { "Natalia.Zarate1410", null, "Zarate", "7mXkvdr20r", null, 1, null, null, "Natalia.Zarate9@yahoo.com", "Natalia" },
                    { "Leonor_Escobar1411", null, "Escobar", "leosWgiaYu", null, 1, null, null, "Leonor.Escobar@gmail.com", "Leonor" },
                    { "Clemente_Tamayo841412", null, "Tamayo", "12oasLQdaU", null, 1, null, null, "Clemente60@yahoo.com", "Clemente" },
                    { "Federico.Hernadez301413", null, "Hernádez", "Ll5NAaa9td", null, 1, null, null, "Federico.Hernadez39@gmail.com", "Federico" },
                    { "Rafael.Kranzsans1414", null, "Kranz sans", "bt0ty7UoEZ", null, 1, null, null, "Rafael38@hotmail.com", "Rafael" },
                    { "Adela.Gallegos421443", null, "Gallegos", "SWjPXjA0vJ", null, 1, null, null, "Adela_Gallegos@yahoo.com", "Adela" },
                    { "Rafael411415", null, "Galarza", "KwwDfB_yjK", null, 1, null, null, "Rafael67@hotmail.com", "Rafael" },
                    { "Silvia.Centeno561417", null, "Centeno", "0CY2IVId_Q", null, 1, null, null, "Silvia20@hotmail.com", "Silvia" },
                    { "Evelyn.Mora991418", null, "Mora", "UFG7XfkJhz", null, 1, null, null, "Evelyn59@gmail.com", "Evelyn" },
                    { "Patricio.Holguin731419", null, "Holguín", "_ZljawVL9Z", null, 1, null, null, "Patricio.Holguin@hotmail.com", "Patricio" },
                    { "Florencia.Montanez401420", null, "Montañez", "HBUQ0z8SJE", null, 1, null, null, "Florencia_Montanez98@nearbpo.com", "Florencia" },
                    { "Esmeralda_Rosales1421", null, "Rosales", "H1mioevtsG", null, 1, null, null, "Esmeralda.Rosales67@hotmail.com", "Esmeralda" },
                    { "Lucia.Deleon1422", null, "Deleón", "zxn4cjepyW", null, 1, null, null, "Lucia.Deleon@gmail.com", "Lucia" },
                    { "Damian601423", null, "Mireles", "IxV4P6IeAs", null, 1, null, null, "Damian75@yahoo.com", "Damián" },
                    { "Salvador_Villareal321416", null, "Villareal", "TDkDbicQJ3", null, 1, null, null, "Salvador.Villareal@nearbpo.com", "Salvador" },
                    { "Regina.Maestas1444", null, "Maestas", "uPtg5JA3rm", null, 1, null, null, "Regina_Maestas64@hotmail.com", "Regina" },
                    { "Nicole521445", null, "Armendáriz", "PMA03aio8m", null, 1, null, null, "Nicole.Armendariz77@nearbpo.com", "Nicole" },
                    { "MariaEugenia101446", null, "Meraz", "PUpKAwaKq7", null, 1, null, null, "MariaEugenia.Meraz@hotmail.com", "María Eugenia" },
                    { "Ximena_Korta1467", null, "Korta", "O5RzjfTHy1", null, 1, null, null, "Ximena66@corpfolder.com", "Ximena" },
                    { "Alfonso_Ulloa1468", null, "Ulloa", "NjNufnq8Ys", null, 1, null, null, "Alfonso.Ulloa9@hotmail.com", "Alfonso" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "AnaMaria_Corona1469", null, "Corona", "N0VbBrfgOk", null, 1, null, null, "AnaMaria_Corona@nearbpo.com", "Ana María" },
                    { "Pablo.Ruelas151470", null, "Ruelas", "4g0RazW3jE", null, 1, null, null, "Pablo_Ruelas70@hotmail.com", "Pablo" },
                    { "Cristobal581471", null, "Cepeda", "JlASvNvcpd", null, 1, null, null, "Cristobal41@gmail.com", "Cristobal" },
                    { "Elsa.Olivas1472", null, "Olivas", "ge0TgNLITf", null, 1, null, null, "Elsa.Olivas@corpfolder.com", "Elsa" },
                    { "Leonardo_Bahena1473", null, "Bahena", "n3JBlKXUdo", null, 1, null, null, "Leonardo_Bahena@yahoo.com", "Leonardo" },
                    { "Lola331466", null, "Pacheco", "eUjOKNmgZT", null, 1, null, null, "Lola.Pacheco@yahoo.com", "Lola" },
                    { "Reina_Huixtlacatl1474", null, "Huixtlacatl", "sqR3QFwWxZ", null, 1, null, null, "Reina47@hotmail.com", "Reina" },
                    { "Lizbeth_Kano1476", null, "Kano", "rrgpD20Aub", null, 1, null, null, "Lizbeth_Kano13@hotmail.com", "Lizbeth" },
                    { "JoseEduardo_Olivo1477", null, "Olivo", "vQ6HEWTJFc", null, 1, null, null, "JoseEduardo10@hotmail.com", "José Eduardo" },
                    { "Alexa_Chacon621478", null, "Chacón", "Mm_l98wX45", null, 1, null, null, "Alexa_Chacon58@hotmail.com", "Alexa" },
                    { "Abigail.Roldan1479", null, "Roldán", "YtU7qxMLf9", null, 1, null, null, "Abigail.Roldan77@yahoo.com", "Abigail" },
                    { "Angela.Iglesias931480", null, "Iglesias", "WFQc60pbBX", null, 1, null, null, "Angela.Iglesias@nearbpo.com", "Ángela" },
                    { "Silvia151481", null, "Acosta", "skk1lTZohm", null, 1, null, null, "Silvia_Acosta81@nearbpo.com", "Silvia" },
                    { "Abril451482", null, "Cepeda", "EhC_FM7nZc", null, 1, null, null, "Abril_Cepeda@corpfolder.com", "Abril" },
                    { "Monserrat.Aleman521475", null, "Alemán", "9VZ8m_xWDQ", null, 1, null, null, "Monserrat.Aleman58@corpfolder.com", "Monserrat" },
                    { "Ester631873", null, "Mascareñas", "VURirJBNO2", null, 1, null, null, "Ester28@corpfolder.com", "Ester" },
                    { "Saul_Patino1465", null, "Patiño", "AEdqoeaNMd", null, 1, null, null, "Saul.Patino86@gmail.com", "Saúl" },
                    { "Cristian71463", null, "Batista", "vNGH0ULZPl", null, 1, null, null, "Cristian12@gmail.com", "Cristian" },
                    { "Gerardo561447", null, "Calvillo", "DJcYMff5VD", null, 1, null, null, "Gerardo_Calvillo75@yahoo.com", "Gerardo" },
                    { "Teodoro.Melgar781448", null, "Melgar", "3iD6U8_ckq", null, 1, null, null, "Teodoro_Melgar@gmail.com", "Teodoro" },
                    { "Carlota171449", null, "Escalante", "I6jBnTZAMX", null, 1, null, null, "Carlota.Escalante80@hotmail.com", "Carlota" },
                    { "Soledad.Longoria1450", null, "Longoria", "HYf0nQzXPh", null, 1, null, null, "Soledad.Longoria12@hotmail.com", "Soledad" },
                    { "Hugo11451", null, "Alcala", "1hPh8blhza", null, 1, null, null, "Hugo.Alcala@corpfolder.com", "Hugo" },
                    { "Hugo.Sarabia1452", null, "Sarabia", "YejdElBL12", null, 1, null, null, "Hugo.Sarabia@gmail.com", "Hugo" },
                    { "Maximiliano_Vallejo981453", null, "Vallejo", "1MGPnQg0sM", null, 1, null, null, "Maximiliano71@corpfolder.com", "Maximiliano" },
                    { "Nicolas231464", null, "Curiel", "IAFulOyTDz", null, 1, null, null, "Nicolas_Curiel@hotmail.com", "Nicolás" },
                    { "Andres_Corral891454", null, "Corral", "kjvj9DWGSB", null, 1, null, null, "Andres91@hotmail.com", "Andrés" },
                    { "Catalina_Estrada891456", null, "Estrada", "ysswCMlJXq", null, 1, null, null, "Catalina74@hotmail.com", "Catalina" },
                    { "Gilberto221457", null, "Fajardo", "faJg4pgJOm", null, 1, null, null, "Gilberto53@gmail.com", "Gilberto" },
                    { "Elvira301458", null, "Camacho", "1GM_I3mUMZ", null, 1, null, null, "Elvira.Camacho@corpfolder.com", "Elvira" },
                    { "Enrique_Olvera571459", null, "Olvera", "dz1pFuUhZk", null, 1, null, null, "Enrique.Olvera@nearbpo.com", "Enrique" },
                    { "MiguelAngel41460", null, "Jáquez", "JXfnGJANVA", null, 1, null, null, "MiguelAngel_Jaquez@yahoo.com", "Miguel Ángel" },
                    { "LuisFernando_Rojas491461", null, "Rojas", "eWEcBRJnBA", null, 1, null, null, "LuisFernando.Rojas@hotmail.com", "Luis Fernando" },
                    { "Sergio571462", null, "Aguirre", "JpoxfLL9r2", null, 1, null, null, "Sergio.Aguirre59@hotmail.com", "Sergio" },
                    { "Benito.Tijerina951455", null, "Tijerina", "2IlL5tUsf1", null, 1, null, null, "Benito.Tijerina31@hotmail.com", "Benito" },
                    { "Rosario.Preciado331251", null, "Preciado", "S4kIjvqLn0", null, 1, null, null, "Rosario4@corpfolder.com", "Rosario" },
                    { "Ivanna271874", null, "Naranjo", "BMX0KB7yaq", null, 1, null, null, "Ivanna.Naranjo@nearbpo.com", "Ivanna" },
                    { "Cristina991876", null, "Vela", "kNmxomngMW", null, 1, null, null, "Cristina45@corpfolder.com", "Cristina" },
                    { "Sancho672288", null, "Guerra", "ySCliSsBrr", null, 1, null, null, "Sancho_Guerra84@corpfolder.com", "Sancho" },
                    { "Israel522289", null, "Quintero de la cruz", "aItEsCcwqX", null, 1, null, null, "Israel.Quinterodelacruz@hotmail.com", "Israel" },
                    { "Patricio_Alcaraz852290", null, "Alcaraz", "Raa9S9xGIB", null, 1, null, null, "Patricio_Alcaraz92@nearbpo.com", "Patricio" },
                    { "Teresa_Raya2291", null, "Raya", "rQQXMojgLL", null, 1, null, null, "Teresa49@gmail.com", "Teresa" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "JoseMiguel_Galindo2292", null, "Galindo", "PH5l1urHDE", null, 1, null, null, "JoseMiguel.Galindo74@corpfolder.com", "José Miguel" },
                    { "Soledad_Rendon2293", null, "Rendón", "HsuUFFFjJS", null, 1, null, null, "Soledad.Rendon@nearbpo.com", "Soledad" },
                    { "Julieta_Tamez2294", null, "Tamez", "sPr20ZsThU", null, 1, null, null, "Julieta.Tamez42@nearbpo.com", "Julieta" },
                    { "Roberto_Botello922295", null, "Botello", "3Le3iMg9Jl", null, 1, null, null, "Roberto_Botello38@yahoo.com", "Roberto" },
                    { "Magdalena952296", null, "Urías", "jvJJCu9PGO", null, 1, null, null, "Magdalena6@corpfolder.com", "Magdalena" },
                    { "Lourdes122297", null, "Barreto", "4evzsPzkua", null, 1, null, null, "Lourdes_Barreto97@nearbpo.com", "Lourdes" },
                    { "JulioCesar_Carrion752298", null, "Carrion", "PZqzaHiQ58", null, 1, null, null, "JulioCesar.Carrion@gmail.com", "Julio César" },
                    { "Abigail_Orta802299", null, "Orta", "hTPlDwU1vw", null, 1, null, null, "Abigail2@hotmail.com", "Abigail" },
                    { "Lola502300", null, "Posada", "KeIVZIISw5", null, 1, null, null, "Lola_Posada26@corpfolder.com", "Lola" },
                    { "Natalia.Olmos2301", null, "Olmos", "WhqXZXBWMo", null, 1, null, null, "Natalia.Olmos@nearbpo.com", "Natalia" },
                    { "Diego_Madrigal22302", null, "Madrigal", "yDzzIDzg4R", null, 1, null, null, "Diego_Madrigal37@gmail.com", "Diego" },
                    { "JoseEmilio_Cazares332287", null, "Cazares", "wEiFRtxkEv", null, 1, null, null, "JoseEmilio.Cazares54@yahoo.com", "José Emilio" },
                    { "Israel682286", null, "Saldivar", "wJzBj81FrJ", null, 1, null, null, "Israel24@yahoo.com", "Israel" },
                    { "Juana_Caraballo2285", null, "Caraballo", "7uQ0gl3ei_", null, 1, null, null, "Juana_Caraballo@yahoo.com", "Juana" },
                    { "Elisa.Chavez2284", null, "Chávez", "VAP2ije_Wg", null, 1, null, null, "Elisa_Chavez30@gmail.com", "Elisa" },
                    { "Isaac642268", null, "Pineda", "pXYEZiPqGe", null, 1, null, null, "Isaac88@hotmail.com", "Isaac" },
                    { "Evelyn112269", null, "Torres", "jt74UICI4n", null, 1, null, null, "Evelyn59@yahoo.com", "Evelyn" },
                    { "Mayte.Chavarria2270", null, "Chavarría", "NtHhvPJVA0", null, 1, null, null, "Mayte.Chavarria85@corpfolder.com", "Mayte" },
                    { "Iker_Alva132271", null, "Alva", "dmNFxeELJi", null, 1, null, null, "Iker.Alva91@yahoo.com", "Iker" },
                    { "Marta22272", null, "Carrillo", "9jZXoa2ouI", null, 1, null, null, "Marta_Carrillo73@gmail.com", "Marta" },
                    { "Alicia532273", null, "Palacios", "PbaljFWTq1", null, 1, null, null, "Alicia95@yahoo.com", "Alicia" },
                    { "Anita852274", null, "Griego", "KndmN1VJtX", null, 1, null, null, "Anita.Griego@hotmail.com", "Anita" },
                    { "Daniela_Gracia2303", null, "Gracia", "pEpZddQJhD", null, 1, null, null, "Daniela_Gracia26@gmail.com", "Daniela" },
                    { "Jennifer812275", null, "Hidalgo", "Uz7asRYrF1", null, 1, null, null, "Jennifer.Hidalgo@corpfolder.com", "Jennifer" },
                    { "Isaias.Ulibarri2277", null, "Ulibarri", "gl1fOFDO3F", null, 1, null, null, "Isaias.Ulibarri@nearbpo.com", "Isaias" },
                    { "Blanca02278", null, "Granados", "pmRtgPy8mw", null, 1, null, null, "Blanca_Granados53@corpfolder.com", "Blanca" },
                    { "Guillermo_Guillen2279", null, "Guillen", "4BpXPDg8vu", null, 1, null, null, "Guillermo24@gmail.com", "Guillermo" },
                    { "Lucia.Naranjo162280", null, "Naranjo", "Uv4XW2_VUq", null, 1, null, null, "Lucia_Naranjo@yahoo.com", "Lucia" },
                    { "Ester.Pina382281", null, "Piña", "AtPjUSs_Kw", null, 1, null, null, "Ester87@corpfolder.com", "Ester" },
                    { "Gustavo242282", null, "Armenta", "v1iLVsTHUt", null, 1, null, null, "Gustavo.Armenta4@yahoo.com", "Gustavo" },
                    { "Alan.Leiva2283", null, "Leiva", "DLcwmImIsC", null, 1, null, null, "Alan_Leiva23@nearbpo.com", "Alan" },
                    { "Axel.Balderas932276", null, "Balderas", "SXVvTt__o2", null, 1, null, null, "Axel20@hotmail.com", "Axel" },
                    { "Sebastian_Salcido872267", null, "Salcido", "7_A1a45qkP", null, 1, null, null, "Sebastian_Salcido@yahoo.com", "Sebastian" },
                    { "Ignacio_Oquendo2304", null, "Oquendo", "eSCsjQTrn_", null, 1, null, null, "Ignacio19@corpfolder.com", "Ignacio" },
                    { "Valentina82306", null, "Anguiano", "B5gF8UCGrV", null, 1, null, null, "Valentina.Anguiano53@hotmail.com", "Valentina" },
                    { "Vanessa992327", null, "Mora", "HLOskA7TlZ", null, 1, null, null, "Vanessa_Mora66@nearbpo.com", "Vanessa" },
                    { "MariaCristina_Palomo482328", null, "Palomo", "8ZCIPaARt3", null, 1, null, null, "MariaCristina_Palomo97@yahoo.com", "María Cristina" },
                    { "Marisol772329", null, "Padilla", "3w0QqJr8Gv", null, 1, null, null, "Marisol.Padilla@corpfolder.com", "Marisol" },
                    { "MariaLuisa.Tejada82330", null, "Tejada", "mw4aO8GtKA", null, 1, null, null, "MariaLuisa_Tejada@corpfolder.com", "María Luisa" },
                    { "Beatriz.Lozada232331", null, "Lozada", "jAf3cKAbvI", null, 1, null, null, "Beatriz.Lozada@corpfolder.com", "Beatriz" },
                    { "Daniela_Sepulveda742332", null, "Sepúlveda", "WVdjrqg31s", null, 1, null, null, "Daniela.Sepulveda@yahoo.com", "Daniela" },
                    { "Francisco152333", null, "Medrano", "wfzEBicIsV", null, 1, null, null, "Francisco.Medrano@nearbpo.com", "Francisco" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "MarcoAntonio832334", null, "Escobedo", "5Cnl33bINf", null, 1, null, null, "MarcoAntonio.Escobedo78@hotmail.com", "Marco Antonio" },
                    { "Pablo722335", null, "Almanza", "OWV3nLa2aB", null, 1, null, null, "Pablo.Almanza@hotmail.com", "Pablo" },
                    { "Enrique.Barrera2336", null, "Barrera", "Eoz96Ie965", null, 1, null, null, "Enrique.Barrera@yahoo.com", "Enrique" },
                    { "Zoe_Briseno2337", null, "Briseño", "a_zZriNWZf", null, 1, null, null, "Zoe_Briseno54@gmail.com", "Zoe" },
                    { "JoseAntonio_Prado2338", null, "Prado", "gtB2wW9XNo", null, 1, null, null, "JoseAntonio69@gmail.com", "José Antonio" },
                    { "Lilia652339", null, "Córdova", "IjrmjdVQP4", null, 1, null, null, "Lilia_Cordova@hotmail.com", "Lilia" },
                    { "Arturo212340", null, "Montes", "Cqd6sGFz4M", null, 1, null, null, "Arturo43@hotmail.com", "Arturo" },
                    { "Caridad222341", null, "Méndez", "jwDgMNa7aZ", null, 1, null, null, "Caridad_Mendez@corpfolder.com", "Caridad" },
                    { "Manuela.Salinas862326", null, "Salinas", "q2PM81UdTd", null, 1, null, null, "Manuela_Salinas50@nearbpo.com", "Manuela" },
                    { "LuisFernando_Colunga2325", null, "Colunga", "xft_m4SHTy", null, 1, null, null, "LuisFernando_Colunga@corpfolder.com", "Luis Fernando" },
                    { "Kimberly_Saenz82324", null, "Sáenz", "6LJGR2e_mY", null, 1, null, null, "Kimberly_Saenz@nearbpo.com", "Kimberly" },
                    { "Elvira852323", null, "Negrón", "r08AEla7W9", null, 1, null, null, "Elvira_Negron9@nearbpo.com", "Elvira" },
                    { "Aaron_Kanimal2307", null, "Kanimal", "EHz8Sh3HZ6", null, 1, null, null, "Aaron_Kanimal@corpfolder.com", "Aarón" },
                    { "Elias202308", null, "Batista", "1LvQCFhZgp", null, 1, null, null, "Elias_Batista@corpfolder.com", "Elías" },
                    { "Berta_Ochoa2309", null, "Ochoa", "1BzOigK5Y8", null, 1, null, null, "Berta.Ochoa64@hotmail.com", "Berta" },
                    { "Lucas_Negron522310", null, "Negrón", "IlrkdNS0ku", null, 1, null, null, "Lucas.Negron35@nearbpo.com", "Lucas" },
                    { "Mario_Velazquez512311", null, "Velázquez", "ZzROSuui40", null, 1, null, null, "Mario.Velazquez@hotmail.com", "Mario" },
                    { "Julieta_Bustos2312", null, "Bustos", "jHbwCmuGTF", null, 1, null, null, "Julieta90@yahoo.com", "Julieta" },
                    { "Kimberly.Valenzuela252313", null, "Valenzuela", "ouBjVAV65a", null, 1, null, null, "Kimberly_Valenzuela@corpfolder.com", "Kimberly" },
                    { "Jeronimo.Karan792305", null, "Karan", "P0CV6gofm7", null, 1, null, null, "Jeronimo39@nearbpo.com", "Jerónimo" },
                    { "Melany.Lomeli12314", null, "Lomeli", "QzFZe2P2Bl", null, 1, null, null, "Melany72@yahoo.com", "Melany" },
                    { "Leonardo_Xana2316", null, "Xana", "0iQZ3uKiAl", null, 1, null, null, "Leonardo90@gmail.com", "Leonardo" },
                    { "Valentina42317", null, "Sandoval", "n_qVLbQ7h4", null, 1, null, null, "Valentina_Sandoval52@corpfolder.com", "Valentina" },
                    { "Silvia_Miranda632318", null, "Miranda", "tP3h1ewSrw", null, 1, null, null, "Silvia45@gmail.com", "Silvia" },
                    { "Lorenzo.Duarte432319", null, "Duarte", "L_4jYhgHVC", null, 1, null, null, "Lorenzo.Duarte74@corpfolder.com", "Lorenzo" },
                    { "Sergio.Correa812320", null, "Correa", "dK2ALlSXgq", null, 1, null, null, "Sergio_Correa87@yahoo.com", "Sergio" },
                    { "Cecilia542321", null, "Anaya", "W3pynzhGlN", null, 1, null, null, "Cecilia_Anaya86@hotmail.com", "Cecilia" },
                    { "Pilar242322", null, "Cervantes", "QCyiMNhI1B", null, 1, null, null, "Pilar94@hotmail.com", "Pilar" },
                    { "Alicia732315", null, "Rubio", "fmhCtQpY_b", null, 1, null, null, "Alicia_Rubio@hotmail.com", "Alicia" },
                    { "Sonia_Solorio2342", null, "Solorio", "8SwIGBboWx", null, 1, null, null, "Sonia80@yahoo.com", "Sonia" },
                    { "Enrique_Madera2266", null, "Madera", "VF7lXAnm5h", null, 1, null, null, "Enrique_Madera@corpfolder.com", "Enrique" },
                    { "Natalia902264", null, "Casillas", "4v0gDBPjbe", null, 1, null, null, "Natalia.Casillas@hotmail.com", "Natalia" },
                    { "Gabriela532210", null, "Tijerina", "nb5buQv27D", null, 1, null, null, "Gabriela_Tijerina1@hotmail.com", "Gabriela" },
                    { "JorgeLuis412211", null, "Medina", "6xljyZA3Dp", null, 1, null, null, "JorgeLuis.Medina36@nearbpo.com", "Jorge Luis" },
                    { "Carolina.Beltran582212", null, "Beltrán", "AeKLuI2rGv", null, 1, null, null, "Carolina62@hotmail.com", "Carolina" },
                    { "JoseAntonio_Kadarrodriguez772213", null, "Kadar rodriguez", "_n6AR42TFG", null, 1, null, null, "JoseAntonio_Kadarrodriguez@corpfolder.com", "José Antonio" },
                    { "Isabela_Velasquez2214", null, "Velásquez", "uNvi4ZQKeA", null, 1, null, null, "Isabela88@hotmail.com", "Isabela" },
                    { "Diana_Velasquez2215", null, "Velásquez", "i6K9vOZI0u", null, 1, null, null, "Diana11@corpfolder.com", "Diana" },
                    { "Diego732216", null, "Puga", "zXyhm_Qzpd", null, 1, null, null, "Diego_Puga@hotmail.com", "Diego" },
                    { "Jazmin_Delafuente522217", null, "Delafuente", "3TRjx1rCu_", null, 1, null, null, "Jazmin37@gmail.com", "Jazmin" },
                    { "JorgeLuis_Espino2218", null, "Espino", "JP58m7LHNg", null, 1, null, null, "JorgeLuis_Espino@nearbpo.com", "Jorge Luis" },
                    { "Ramiro.Vega602219", null, "Vega", "2z0LYj8myQ", null, 1, null, null, "Ramiro76@nearbpo.com", "Ramiro" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Eduardo_Velasco892220", null, "Velasco", "EzGwqDkEpE", null, 1, null, null, "Eduardo_Velasco37@yahoo.com", "Eduardo" },
                    { "LuisAngel262221", null, "Lerma", "TMK6j4vHEt", null, 1, null, null, "LuisAngel49@hotmail.com", "Luis Ángel" },
                    { "Rocio.Acuna602222", null, "Acuña", "kJCA14eLJF", null, 1, null, null, "Rocio_Acuna66@yahoo.com", "Rocio" },
                    { "Federico822223", null, "Agosto", "Q8potDoprr", null, 1, null, null, "Federico_Agosto59@corpfolder.com", "Federico" },
                    { "Esteban42224", null, "Montes", "73aorqpDOA", null, 1, null, null, "Esteban54@nearbpo.com", "Esteban" },
                    { "Lorenzo.Ibarra2209", null, "Ibarra", "CJIIGygMoJ", null, 1, null, null, "Lorenzo.Ibarra53@hotmail.com", "Lorenzo" },
                    { "Adan.Orellana2208", null, "Orellana", "UR6n9nVbFE", null, 1, null, null, "Adan_Orellana44@yahoo.com", "Adán" },
                    { "Dorotea_Figueroa2207", null, "Figueroa", "RJ12l8BCG4", null, 1, null, null, "Dorotea.Figueroa@hotmail.com", "Dorotea" },
                    { "Oscar.Anaya902206", null, "Anaya", "yHcZpQlBOH", null, 1, null, null, "Oscar87@yahoo.com", "Óscar" },
                    { "Felipe502190", null, "Magaña", "UmlDTkX3R7", null, 1, null, null, "Felipe.Magana@yahoo.com", "Felipe" },
                    { "Nicolas.Loera2191", null, "Loera", "DBdQRz2qlP", null, 1, null, null, "Nicolas23@corpfolder.com", "Nicolás" },
                    { "JorgeLuis_Tamez262192", null, "Tamez", "2cfdb9BtTM", null, 1, null, null, "JorgeLuis.Tamez83@yahoo.com", "Jorge Luis" },
                    { "Miranda.Kardachesoto2193", null, "Kardache soto", "EU20_ZrGnx", null, 1, null, null, "Miranda26@nearbpo.com", "Miranda" },
                    { "Israel_Kara2194", null, "Kara", "1Vq1fC0wD9", null, 1, null, null, "Israel.Kara61@yahoo.com", "Israel" },
                    { "Susana292195", null, "Ortega", "0BW7xAsXAH", null, 1, null, null, "Susana40@yahoo.com", "Susana" },
                    { "JoseLuis.Lucero2196", null, "Lucero", "9bQPtrJCkj", null, 1, null, null, "JoseLuis_Lucero@yahoo.com", "José Luis" },
                    { "Uriel962225", null, "Urrutia", "HEraAislKc", null, 1, null, null, "Uriel61@nearbpo.com", "Uriel" },
                    { "Matias.Razo152197", null, "Razo", "FDui9p_92g", null, 1, null, null, "Matias.Razo91@gmail.com", "Matías" },
                    { "Andrea.Zapata682199", null, "Zapata", "QXXTFP3cNy", null, 1, null, null, "Andrea71@corpfolder.com", "Andrea" },
                    { "Leonardo.Cardenas2200", null, "Cardenas", "2mE0y01863", null, 1, null, null, "Leonardo.Cardenas73@nearbpo.com", "Leonardo" },
                    { "Brayan792201", null, "Negrón", "SayX4ObjEK", null, 1, null, null, "Brayan8@corpfolder.com", "Brayan" },
                    { "Abraham912202", null, "Rascón", "BvgwzJFdE7", null, 1, null, null, "Abraham.Rascon@corpfolder.com", "Abraham" },
                    { "Jose.Quintero512203", null, "Quintero", "MFYk6E3gKg", null, 1, null, null, "Jose.Quintero@gmail.com", "José" },
                    { "Catalina_Caban392204", null, "Cabán", "o4gLTM7oAw", null, 1, null, null, "Catalina_Caban76@nearbpo.com", "Catalina" },
                    { "Daniela_Correa2205", null, "Correa", "zi5vAk2YWM", null, 1, null, null, "Daniela_Correa@yahoo.com", "Daniela" },
                    { "Santiago.Haro12198", null, "Haro", "tcYqUaZQYW", null, 1, null, null, "Santiago.Haro35@yahoo.com", "Santiago" },
                    { "Marcela_Quinterocruz2265", null, "Quintero cruz", "RnNGqOF2Cn", null, 1, null, null, "Marcela_Quinterocruz@gmail.com", "Marcela" },
                    { "Esperanza.Tamayo72226", null, "Tamayo", "ahBjgoLTml", null, 1, null, null, "Esperanza23@hotmail.com", "Esperanza" },
                    { "Jeronimo932228", null, "Delagarza", "7qIHZKBQfc", null, 1, null, null, "Jeronimo46@corpfolder.com", "Jerónimo" },
                    { "Eduardo.Serrano2249", null, "Serrano", "I7mNqfocPb", null, 1, null, null, "Eduardo_Serrano86@gmail.com", "Eduardo" },
                    { "Magdalena_Olivares2250", null, "Olivares", "Hm4zE0d04D", null, 1, null, null, "Magdalena.Olivares@nearbpo.com", "Magdalena" },
                    { "Sancho_Holguin2251", null, "Holguín", "RB02GFsx03", null, 1, null, null, "Sancho78@nearbpo.com", "Sancho" },
                    { "Blanca482252", null, "Acevedo", "LtUSaaEimP", null, 1, null, null, "Blanca_Acevedo@corpfolder.com", "Blanca" },
                    { "Francisca_Echevarria242253", null, "Echevarría", "sGqzekhdrX", null, 1, null, null, "Francisca43@yahoo.com", "Francisca" },
                    { "JorgeLuis.Benavides692254", null, "Benavides", "j5ZSmrGe_K", null, 1, null, null, "JorgeLuis_Benavides60@corpfolder.com", "Jorge Luis" },
                    { "Guillermo_Delafuente2255", null, "Delafuente", "Ca4V1MB7fM", null, 1, null, null, "Guillermo43@hotmail.com", "Guillermo" },
                    { "Rafael_Barrientos2256", null, "Barrientos", "P_wbTqxCcE", null, 1, null, null, "Rafael.Barrientos51@yahoo.com", "Rafael" },
                    { "Rebeca_Kanaria2257", null, "Kanaria", "jo01PMW_l9", null, 1, null, null, "Rebeca.Kanaria@corpfolder.com", "Rebeca" },
                    { "Claudia92258", null, "Casanova", "h9qwf1Zt9R", null, 1, null, null, "Claudia79@gmail.com", "Claudia" },
                    { "Oscar_Casarez2259", null, "Casárez", "XhCeufhB4w", null, 1, null, null, "Oscar13@gmail.com", "Óscar" },
                    { "Paulina_Franco972260", null, "Franco", "_V8ChKM75c", null, 1, null, null, "Paulina82@yahoo.com", "Paulina" },
                    { "Guillermina_Alvarez2261", null, "Alvarez", "EqvELWVDBJ", null, 1, null, null, "Guillermina.Alvarez16@hotmail.com", "Guillermina" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Adriana662262", null, "Lira", "iWn9KW0ITD", null, 1, null, null, "Adriana_Lira38@hotmail.com", "Adriana" },
                    { "Camila572263", null, "Valles", "sEoWKKyQDP", null, 1, null, null, "Camila98@gmail.com", "Camila" },
                    { "Liliana_Mata912248", null, "Mata", "l7qBIgWvVN", null, 1, null, null, "Liliana23@nearbpo.com", "Liliana" },
                    { "Lola.Urbina312247", null, "Urbina", "QUcEcOU6G2", null, 1, null, null, "Lola_Urbina96@yahoo.com", "Lola" },
                    { "MariaFernanda332246", null, "Chávez", "Jh8ym_8fOm", null, 1, null, null, "MariaFernanda_Chavez73@yahoo.com", "María Fernanda" },
                    { "AngelGabriel.Xacon512245", null, "Xacon", "B4hIBCzu2e", null, 1, null, null, "AngelGabriel.Xacon99@corpfolder.com", "Ángel Gabriel" },
                    { "David.Montoya2229", null, "Montoya", "vq9Hy0v58L", null, 1, null, null, "David57@hotmail.com", "David" },
                    { "Elizabeth.Iglesias2230", null, "Iglesias", "MXqnYE74uY", null, 1, null, null, "Elizabeth.Iglesias@gmail.com", "Elizabeth" },
                    { "Marilu.Solorzano2231", null, "Solorzano", "QJG9o3Jtd8", null, 1, null, null, "Marilu_Solorzano@gmail.com", "Marilu" },
                    { "Santiago_Terrazas962232", null, "Terrazas", "qnU3LGGm5G", null, 1, null, null, "Santiago.Terrazas@nearbpo.com", "Santiago" },
                    { "Felipe.Mireles962233", null, "Mireles", "rXMrmmuW1w", null, 1, null, null, "Felipe13@nearbpo.com", "Felipe" },
                    { "Ester_Orellana2234", null, "Orellana", "5fHsJPnLXB", null, 1, null, null, "Ester.Orellana32@yahoo.com", "Ester" },
                    { "Veronica.Urrutia242235", null, "Urrutia", "uo_zoN9hgg", null, 1, null, null, "Veronica.Urrutia@hotmail.com", "Verónica" },
                    { "Diego802227", null, "Guevara", "_vNi5QWpwJ", null, 1, null, null, "Diego.Guevara39@yahoo.com", "Diego" },
                    { "Emilia872236", null, "Chavarría", "tcThftWoX4", null, 1, null, null, "Emilia.Chavarria86@corpfolder.com", "Emilia" },
                    { "Luz.Tamayo2238", null, "Tamayo", "Ci4foIj_5u", null, 1, null, null, "Luz_Tamayo@nearbpo.com", "Luz" },
                    { "Rosario_Sandoval2239", null, "Sandoval", "uxudvTvGAu", null, 1, null, null, "Rosario89@gmail.com", "Rosario" },
                    { "Esmeralda.Rolon602240", null, "Rolón", "jtmeAxy9rG", null, 1, null, null, "Esmeralda_Rolon@hotmail.com", "Esmeralda" },
                    { "Isaias_Aguilera882241", null, "Aguilera", "L9Se7sAUZg", null, 1, null, null, "Isaias_Aguilera@gmail.com", "Isaias" },
                    { "AnaLuisa22242", null, "Quintero cruz", "WlkhZ5cdja", null, 1, null, null, "AnaLuisa.Quinterocruz78@nearbpo.com", "Ana Luisa" },
                    { "Lola622243", null, "Quintero de la cruz", "xE39H14tfx", null, 1, null, null, "Lola30@nearbpo.com", "Lola" },
                    { "AnaMaria.Quintairos172244", null, "Quintairos", "olFZzKFXO1", null, 1, null, null, "AnaMaria.Quintairos@nearbpo.com", "Ana María" },
                    { "Araceli_Manzanares872237", null, "Manzanares", "dS5C_iE6rY", null, 1, null, null, "Araceli_Manzanares@hotmail.com", "Araceli" },
                    { "Liliana42189", null, "Posada", "RlXragez31", null, 1, null, null, "Liliana.Posada27@corpfolder.com", "Liliana" },
                    { "Ivanna.Villegas2343", null, "Villegas", "EwEw4_hp7F", null, 1, null, null, "Ivanna.Villegas@corpfolder.com", "Ivanna" },
                    { "Lorena.Arteaga2345", null, "Arteaga", "8Rn8oaS1Cy", null, 1, null, null, "Lorena_Arteaga@yahoo.com", "Lorena" },
                    { "Liliana_Valdivia652444", null, "Valdivia", "0WXGc_N4yh", null, 1, null, null, "Liliana_Valdivia22@hotmail.com", "Liliana" },
                    { "Emilio_Cavazos142445", null, "Cavazos", "pihUwZAQsW", null, 1, null, null, "Emilio48@corpfolder.com", "Emilio" },
                    { "Patricio632446", null, "Otero", "cLObKJGE5u", null, 1, null, null, "Patricio67@nearbpo.com", "Patricio" },
                    { "MariaGuadalupe92447", null, "Bahena", "h2IRnKPm9q", null, 1, null, null, "MariaGuadalupe.Bahena77@nearbpo.com", "María Guadalupe" },
                    { "Gloria_Ayala572448", null, "Ayala", "KMxHXJiDae", null, 1, null, null, "Gloria48@corpfolder.com", "Gloria" },
                    { "Barbara.Alcala2449", null, "Alcala", "GXK6XfgqcA", null, 1, null, null, "Barbara_Alcala@yahoo.com", "Barbara" },
                    { "Francisco702450", null, "Laureano", "ZSAXYmT2Ls", null, 1, null, null, "Francisco76@nearbpo.com", "Francisco" },
                    { "Ana_Razo702451", null, "Razo", "kaFkpFC5vt", null, 1, null, null, "Ana_Razo@nearbpo.com", "Ana" },
                    { "Yaretzi_Haro762452", null, "Haro", "ZLd8zGjLUv", null, 1, null, null, "Yaretzi_Haro@corpfolder.com", "Yaretzi" },
                    { "Homero_Alarcon2453", null, "Alarcón", "6uUqo3jryF", null, 1, null, null, "Homero_Alarcon@gmail.com", "Homero" },
                    { "Juan.Alcaraz372454", null, "Alcaraz", "2I2uugACUr", null, 1, null, null, "Juan.Alcaraz@yahoo.com", "Juan" },
                    { "Samuel372455", null, "Urías", "sEbLSsbRgs", null, 1, null, null, "Samuel.Urias28@yahoo.com", "Samuel" },
                    { "Miranda332456", null, "Xiana", "8R0FOWoBB4", null, 1, null, null, "Miranda.Xiana76@yahoo.com", "Miranda" },
                    { "Reina.Cazares202457", null, "Cazares", "6q_tHf3xry", null, 1, null, null, "Reina1@nearbpo.com", "Reina" },
                    { "MiguelAngel_Trujillo2458", null, "Trujillo", "NR4_RT62u8", null, 1, null, null, "MiguelAngel_Trujillo@yahoo.com", "Miguel Ángel" },
                    { "Jose72443", null, "Trujillo", "OCT93zxRVg", null, 1, null, null, "Jose12@corpfolder.com", "José" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Alejandro_Sierra2442", null, "Sierra", "_oMXMd5Yka", null, 1, null, null, "Alejandro.Sierra@corpfolder.com", "Alejandro" },
                    { "LuisMiguel.Barrera2441", null, "Barrera", "2s2fQDNdlC", null, 1, null, null, "LuisMiguel.Barrera@gmail.com", "Luis Miguel" },
                    { "Magdalena592440", null, "Rolón", "6bMkfXPpTb", null, 1, null, null, "Magdalena_Rolon25@nearbpo.com", "Magdalena" },
                    { "Anita122424", null, "Llamas", "e8q3d8SFNs", null, 1, null, null, "Anita.Llamas87@yahoo.com", "Anita" },
                    { "Luis.Sauceda2425", null, "Sauceda", "5fE8qWvvea", null, 1, null, null, "Luis_Sauceda41@nearbpo.com", "Luis" },
                    { "Elizabeth.Cordova2426", null, "Córdova", "ujqlQR8lAu", null, 1, null, null, "Elizabeth.Cordova53@gmail.com", "Elizabeth" },
                    { "Isabel.Kranzsans232427", null, "Kranz sans", "GfgyNpBQIb", null, 1, null, null, "Isabel_Kranzsans@hotmail.com", "Isabel" },
                    { "Rafael_Herrera2428", null, "Herrera", "kwXsOWQ_x8", null, 1, null, null, "Rafael_Herrera@gmail.com", "Rafael" },
                    { "Pablo922429", null, "Escobedo", "3D3haM8_yn", null, 1, null, null, "Pablo.Escobedo36@gmail.com", "Pablo" },
                    { "Eva_Nunez2430", null, "Núñez", "0I8EMRRbE2", null, 1, null, null, "Eva.Nunez@nearbpo.com", "Eva" },
                    { "Horacio.Madera2459", null, "Madera", "mOptb8xQ6p", null, 1, null, null, "Horacio_Madera@gmail.com", "Horacio" },
                    { "Carmen452431", null, "Saucedo", "E9GbfXjTB0", null, 1, null, null, "Carmen.Saucedo41@gmail.com", "Carmen" },
                    { "Lourdes.Feliciano172433", null, "Feliciano", "gz_HiUT1w4", null, 1, null, null, "Lourdes24@nearbpo.com", "Lourdes" },
                    { "Rocio_Vela2434", null, "Vela", "FobwaMnfKc", null, 1, null, null, "Rocio.Vela45@corpfolder.com", "Rocio" },
                    { "Emily_Ledesma162435", null, "Ledesma", "g1Q3KIUSXC", null, 1, null, null, "Emily58@gmail.com", "Emily" },
                    { "Xochitl_Chavarria572436", null, "Chavarría", "hmxzaGE8zm", null, 1, null, null, "Xochitl.Chavarria@corpfolder.com", "Xochitl" },
                    { "Matias272437", null, "Villanueva", "tIBQUzS5V0", null, 1, null, null, "Matias.Villanueva@corpfolder.com", "Matías" },
                    { "Jose_Montemayor2438", null, "Montemayor", "8_HrbsrCVo", null, 1, null, null, "Jose28@hotmail.com", "José" },
                    { "German.Rosado2439", null, "Rosado", "CM0bWhv8Z1", null, 1, null, null, "German_Rosado3@corpfolder.com", "Germán" },
                    { "Elena.Camacho2432", null, "Camacho", "r9OMy_7Adh", null, 1, null, null, "Elena24@yahoo.com", "Elena" },
                    { "Carolina702423", null, "Rentería", "KytShokI2b", null, 1, null, null, "Carolina.Renteria78@gmail.com", "Carolina" },
                    { "Erick.Palomo2460", null, "Palomo", "eSjYfqC0Xg", null, 1, null, null, "Erick.Palomo@nearbpo.com", "Erick" },
                    { "Brandon.Kaplan2462", null, "Kaplan", "gQR0uIY96Y", null, 1, null, null, "Brandon50@gmail.com", "Brandon" },
                    { "Kevin.Padilla412483", null, "Padilla", "wmGLmIwnHt", null, 1, null, null, "Kevin_Padilla97@nearbpo.com", "Kevin" },
                    { "Erick.Zaragoza2484", null, "Zaragoza", "VQiGi7kyI8", null, 1, null, null, "Erick48@gmail.com", "Erick" },
                    { "Carla122485", null, "Duarte", "Nzri_fqhNi", null, 1, null, null, "Carla61@corpfolder.com", "Carla" },
                    { "Vicente_Galvan912486", null, "Galván", "2YsLCz2nGf", null, 1, null, null, "Vicente_Galvan64@gmail.com", "Vicente" },
                    { "Lilia82487", null, "Luna", "1I94pPqJs0", null, 1, null, null, "Lilia_Luna80@corpfolder.com", "Lilia" },
                    { "Patricia_Ontiveros2488", null, "Ontiveros", "lHPIZV9Luy", null, 1, null, null, "Patricia.Ontiveros@corpfolder.com", "Patricia" },
                    { "Rosario_Rascon2489", null, "Rascón", "00ecC_WNDo", null, 1, null, null, "Rosario85@corpfolder.com", "Rosario" },
                    { "Claudio.Porras2490", null, "Porras", "Jt8LEwoeCc", null, 1, null, null, "Claudio22@nearbpo.com", "Claudio" },
                    { "Graciela92491", null, "Villalpando", "jjpJ8dumR7", null, 1, null, null, "Graciela93@nearbpo.com", "Graciela" },
                    { "Julio552492", null, "Loya", "ceLVLMrZs3", null, 1, null, null, "Julio52@yahoo.com", "Julio" },
                    { "Liliana.Quintana562493", null, "Quintana", "opLjs5JhwD", null, 1, null, null, "Liliana.Quintana@hotmail.com", "Liliana" },
                    { "JoseMaria332494", null, "Villanueva", "pwJy81pZOE", null, 1, null, null, "JoseMaria.Villanueva@corpfolder.com", "José María" },
                    { "Elias.Alvarez02495", null, "Alvarez", "GpwhBXjBuc", null, 1, null, null, "Elias25@yahoo.com", "Elías" },
                    { "Paola.Laureano2496", null, "Laureano", "YnG6ro2YcX", null, 1, null, null, "Paola60@corpfolder.com", "Paola" },
                    { "MariaSoledad_Rivera2497", null, "Rivera", "NmtohXIISk", null, 1, null, null, "MariaSoledad.Rivera@gmail.com", "María Soledad" },
                    { "Marcos872482", null, "Rodríquez", "KF53q_IxsL", null, 1, null, null, "Marcos_Rodriquez@nearbpo.com", "Marcos" },
                    { "Guillermo352481", null, "Campos", "lMmoQAr6JR", null, 1, null, null, "Guillermo.Campos14@hotmail.com", "Guillermo" },
                    { "Julio.Laboy602480", null, "Laboy", "RGvwwag1ee", null, 1, null, null, "Julio7@corpfolder.com", "Julio" },
                    { "Emilio_Rangel2479", null, "Rangel", "tvBPQ28xCA", null, 1, null, null, "Emilio.Rangel26@corpfolder.com", "Emilio" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "MariaEugenia.Macias2463", null, "Macías", "VDMQXuTaBA", null, 1, null, null, "MariaEugenia_Macias@gmail.com", "María Eugenia" },
                    { "JuanCarlos992464", null, "Cabán", "wwiVUvPYxC", null, 1, null, null, "JuanCarlos47@nearbpo.com", "Juan Carlos" },
                    { "Beatriz_Zuniga192465", null, "Zúñiga", "Sv8IAE2CJL", null, 1, null, null, "Beatriz.Zuniga@yahoo.com", "Beatriz" },
                    { "MariadeJesus812466", null, "Vigil", "eqRGvsOS56", null, 1, null, null, "MariadeJesus_Vigil90@corpfolder.com", "María de Jesús" },
                    { "Veronica502467", null, "Ocasio", "vkyCMmVoRc", null, 1, null, null, "Veronica.Ocasio44@corpfolder.com", "Verónica" },
                    { "JoseEmilio_Blanco2468", null, "Blanco", "MiyijpDXgr", null, 1, null, null, "JoseEmilio92@gmail.com", "José Emilio" },
                    { "Benjamin_Iglesias2469", null, "Iglesias", "6nWPEiXBR9", null, 1, null, null, "Benjamin50@gmail.com", "Benjamín" },
                    { "Gabriela_Bermudez2461", null, "Bermúdez", "RF8DACpVbj", null, 1, null, null, "Gabriela_Bermudez@yahoo.com", "Gabriela" },
                    { "AnaMaria_Pina2470", null, "Piña", "rB22aReXPR", null, 1, null, null, "AnaMaria.Pina96@gmail.com", "Ana María" },
                    { "Alexander.Cepeda2472", null, "Cepeda", "A1wfW0u4Ik", null, 1, null, null, "Alexander70@nearbpo.com", "Alexander" },
                    { "Sonia522473", null, "Cardona", "10jSf0aAAw", null, 1, null, null, "Sonia_Cardona@yahoo.com", "Sonia" },
                    { "Jose_Castaneda2474", null, "Castañeda", "VY31kWkrUf", null, 1, null, null, "Jose_Castaneda@gmail.com", "José" },
                    { "AnaLuisa_Fierro142475", null, "Fierro", "2H7QKyYLWB", null, 1, null, null, "AnaLuisa_Fierro8@corpfolder.com", "Ana Luisa" },
                    { "MariaJose582476", null, "Ferrer", "aVFQ09AyiH", null, 1, null, null, "MariaJose.Ferrer@yahoo.com", "María José" },
                    { "Elsa_Vargas2477", null, "Vargas", "TxzQCgKk9H", null, 1, null, null, "Elsa27@gmail.com", "Elsa" },
                    { "Cecilia_Hernadez2478", null, "Hernádez", "WOaildDG9j", null, 1, null, null, "Cecilia.Hernadez18@corpfolder.com", "Cecilia" },
                    { "Octavio302471", null, "Franco", "9Sp7lFpkQs", null, 1, null, null, "Octavio.Franco@hotmail.com", "Octavio" },
                    { "Cesar.Olvera2344", null, "Olvera", "bUk6umt_DF", null, 1, null, null, "Cesar57@nearbpo.com", "César" },
                    { "Federico342422", null, "Pineda", "ViGBpYapGI", null, 1, null, null, "Federico_Pineda@nearbpo.com", "Federico" },
                    { "Sonia_Rosas2420", null, "Rosas", "fCVl6dT1uD", null, 1, null, null, "Sonia_Rosas@gmail.com", "Sonia" },
                    { "Andrea232366", null, "Serrano", "pe_1GmGMvb", null, 1, null, null, "Andrea_Serrano32@nearbpo.com", "Andrea" },
                    { "Yolanda682367", null, "Rojo", "idPY6FZbHM", null, 1, null, null, "Yolanda80@hotmail.com", "Yolanda" },
                    { "Ivanna.Duarte672368", null, "Duarte", "fJSXc_IlP4", null, 1, null, null, "Ivanna65@nearbpo.com", "Ivanna" },
                    { "Alejandro22369", null, "Benavídez", "qAM4yNJZhN", null, 1, null, null, "Alejandro_Benavidez70@hotmail.com", "Alejandro" },
                    { "Debora.Barreto2370", null, "Barreto", "Rm199tNyze", null, 1, null, null, "Debora58@corpfolder.com", "Débora" },
                    { "Elizabeth822371", null, "Carvajal", "mYKp7l4zzV", null, 1, null, null, "Elizabeth22@nearbpo.com", "Elizabeth" },
                    { "Josefina.Melendez832372", null, "Meléndez", "AIjH7YuSws", null, 1, null, null, "Josefina_Melendez75@nearbpo.com", "Josefina" },
                    { "Emilia242373", null, "Trujillo", "xL4JfYu8Uk", null, 1, null, null, "Emilia_Trujillo@yahoo.com", "Emilia" },
                    { "Ines_Acuna492374", null, "Acuña", "gzshHuEz5k", null, 1, null, null, "Ines26@hotmail.com", "Inés" },
                    { "Gonzalo_Roldan682375", null, "Roldán", "BsUbtG_Mc1", null, 1, null, null, "Gonzalo77@corpfolder.com", "Gonzalo" },
                    { "Marcos442376", null, "Pichardo", "VonxVcHCse", null, 1, null, null, "Marcos.Pichardo60@gmail.com", "Marcos" },
                    { "Elsa_Saiz602377", null, "Saiz", "ST2dXSpiGb", null, 1, null, null, "Elsa_Saiz@yahoo.com", "Elsa" },
                    { "Mayte52378", null, "Madrid", "BaXRtjokBd", null, 1, null, null, "Mayte32@nearbpo.com", "Mayte" },
                    { "Brandon_Aguilera2379", null, "Aguilera", "tXLnN06Tq4", null, 1, null, null, "Brandon_Aguilera71@corpfolder.com", "Brandon" },
                    { "Cristobal62380", null, "Baca", "aNYGiAUOxh", null, 1, null, null, "Cristobal.Baca97@gmail.com", "Cristobal" },
                    { "Gilberto.Marin392365", null, "Marín", "Jfq0bwWSfJ", null, 1, null, null, "Gilberto13@hotmail.com", "Gilberto" },
                    { "Israel_Venegas2364", null, "Venegas", "wZHHrMK1Cd", null, 1, null, null, "Israel8@yahoo.com", "Israel" },
                    { "Cristian_Solis402363", null, "Solís", "1pLjOoqTLR", null, 1, null, null, "Cristian_Solis@hotmail.com", "Cristian" },
                    { "Alejandro472362", null, "Prieto", "2XE7yXGYw8", null, 1, null, null, "Alejandro_Prieto@yahoo.com", "Alejandro" },
                    { "Catalina_Alcala2346", null, "Alcala", "PXm3c9og2i", null, 1, null, null, "Catalina.Alcala95@nearbpo.com", "Catalina" },
                    { "Mariano992347", null, "Huixtlacatl", "Ql2RSIAHWB", null, 1, null, null, "Mariano_Huixtlacatl82@hotmail.com", "Mariano" },
                    { "Regina.Covarrubias2348", null, "Covarrubias", "ee1024w5E3", null, 1, null, null, "Regina80@yahoo.com", "Regina" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Victor912349", null, "Valadez", "41IvYZjBjG", null, 1, null, null, "Victor.Valadez19@hotmail.com", "Víctor" },
                    { "Tadeo.Casillas902350", null, "Casillas", "nRZQ2ggYjW", null, 1, null, null, "Tadeo48@gmail.com", "Tadeo" },
                    { "Patricia_Carrillo972351", null, "Carrillo", "Fl2ElC_F8A", null, 1, null, null, "Patricia.Carrillo@corpfolder.com", "Patricia" },
                    { "Antonio592352", null, "Alaniz", "w2669VCV3d", null, 1, null, null, "Antonio_Alaniz61@gmail.com", "Antonio" },
                    { "Joaquin862381", null, "Ceja", "QShkvZGk3n", null, 1, null, null, "Joaquin48@nearbpo.com", "Joaquín" },
                    { "Evelyn.Mena2353", null, "Mena", "NLNliGpqH4", null, 1, null, null, "Evelyn.Mena@gmail.com", "Evelyn" },
                    { "Teresa952355", null, "Alcaraz", "GnEdzzodAU", null, 1, null, null, "Teresa12@yahoo.com", "Teresa" },
                    { "Leonardo_Crespo542356", null, "Crespo", "rimCW1GaBF", null, 1, null, null, "Leonardo_Crespo@hotmail.com", "Leonardo" },
                    { "Maximiliano732357", null, "Cavazos", "CndjD9ez8C", null, 1, null, null, "Maximiliano_Cavazos98@nearbpo.com", "Maximiliano" },
                    { "Isabel_Mireles952358", null, "Mireles", "hlGZfBQyUV", null, 1, null, null, "Isabel.Mireles36@nearbpo.com", "Isabel" },
                    { "Cesar52359", null, "Castillo", "eoBvLY4Pje", null, 1, null, null, "Cesar.Castillo45@gmail.com", "César" },
                    { "Gerardo.Orta432360", null, "Orta", "uUlBN8d8i6", null, 1, null, null, "Gerardo7@yahoo.com", "Gerardo" },
                    { "Ricardo_Alejandro2361", null, "Alejandro", "8qGtopeTTu", null, 1, null, null, "Ricardo.Alejandro@yahoo.com", "Ricardo" },
                    { "AnaMaria542354", null, "Gracia", "nESxxF3SlM", null, 1, null, null, "AnaMaria_Gracia@hotmail.com", "Ana María" },
                    { "German982421", null, "Covarrubias", "zHRdR3NdzL", null, 1, null, null, "German78@nearbpo.com", "Germán" },
                    { "Emilia702382", null, "Karen", "mtLqNsIKs5", null, 1, null, null, "Emilia35@hotmail.com", "Emilia" },
                    { "Patricia682384", null, "Carrera", "on5eCh7NaN", null, 1, null, null, "Patricia.Carrera@yahoo.com", "Patricia" },
                    { "Yamileth_Vaca2405", null, "Vaca", "Nh7oYD4ZJ3", null, 1, null, null, "Yamileth_Vaca@gmail.com", "Yamileth" },
                    { "Monica342406", null, "Muñoz", "elx_boLDly", null, 1, null, null, "Monica75@yahoo.com", "Mónica" },
                    { "Alexa.Rodrigez2407", null, "Rodrígez", "8aDqLgjnkm", null, 1, null, null, "Alexa.Rodrigez@gmail.com", "Alexa" },
                    { "Benjamin.Linares482408", null, "Linares", "0vSgxZlO1s", null, 1, null, null, "Benjamin90@hotmail.com", "Benjamín" },
                    { "JorgeLuis.Padilla42409", null, "Padilla", "WsUUYq1LDc", null, 1, null, null, "JorgeLuis16@hotmail.com", "Jorge Luis" },
                    { "MariaFernanda662410", null, "Korta hernandez", "vVFhI4LzSB", null, 1, null, null, "MariaFernanda.Kortahernandez@yahoo.com", "María Fernanda" },
                    { "Gabriela_Lira2411", null, "Lira", "2joOHHBhXU", null, 1, null, null, "Gabriela_Lira@nearbpo.com", "Gabriela" },
                    { "Eloisa382412", null, "Guerrero", "0q1hdIP4HJ", null, 1, null, null, "Eloisa.Guerrero4@gmail.com", "Eloisa" },
                    { "Ximena.Tejada312413", null, "Tejada", "uALzZ2Y7r4", null, 1, null, null, "Ximena92@yahoo.com", "Ximena" },
                    { "LuisMiguel_Montez52414", null, "Montez", "xgcsTcX8qC", null, 1, null, null, "LuisMiguel.Montez@nearbpo.com", "Luis Miguel" },
                    { "Regina.Garza2415", null, "Garza", "q5GFyauj3v", null, 1, null, null, "Regina4@gmail.com", "Regina" },
                    { "Luis612416", null, "Prieto", "ea1tHvWM1q", null, 1, null, null, "Luis62@nearbpo.com", "Luis" },
                    { "Adela.Salinas882417", null, "Salinas", "YNHjnwIWfK", null, 1, null, null, "Adela.Salinas@yahoo.com", "Adela" },
                    { "Patricia.Atencio2418", null, "Atencio", "Ugo_XpDSOb", null, 1, null, null, "Patricia83@corpfolder.com", "Patricia" },
                    { "Alfredo852419", null, "Korta hernandez", "8HNbk30xcL", null, 1, null, null, "Alfredo_Kortahernandez@hotmail.com", "Alfredo" },
                    { "Alicia_Quinterocruz2404", null, "Quintero cruz", "THruMuuaR2", null, 1, null, null, "Alicia35@hotmail.com", "Alicia" },
                    { "Carlos_Olmos482403", null, "Olmos", "VqwnNajvEO", null, 1, null, null, "Carlos.Olmos@nearbpo.com", "Carlos" },
                    { "LuisMiguel402402", null, "Carranza", "pqLMS9dwqG", null, 1, null, null, "LuisMiguel_Carranza50@hotmail.com", "Luis Miguel" },
                    { "Elisa_Cepeda2401", null, "Cepeda", "iV_ATlheld", null, 1, null, null, "Elisa68@corpfolder.com", "Elisa" },
                    { "Estela_Badillo2385", null, "Badillo", "ANW_ALyXip", null, 1, null, null, "Estela_Badillo@corpfolder.com", "Estela" },
                    { "Lorenzo_Quevedo402386", null, "Quevedo", "sDkk7A7UEF", null, 1, null, null, "Lorenzo.Quevedo@hotmail.com", "Lorenzo" },
                    { "Isaac_Alcala262387", null, "Alcala", "z0AvYj9_yI", null, 1, null, null, "Isaac_Alcala@hotmail.com", "Isaac" },
                    { "Lilia292388", null, "Marroquín", "2JqTcCQIaF", null, 1, null, null, "Lilia55@nearbpo.com", "Lilia" },
                    { "Daniela272389", null, "Corral", "UAXV1kElRl", null, 1, null, null, "Daniela.Corral39@corpfolder.com", "Daniela" },
                    { "MariadelosAngeles52390", null, "Montalvo", "4RS328XBwG", null, 1, null, null, "MariadelosAngeles.Montalvo@nearbpo.com", "María de los Ángeles" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Irene972391", null, "Ayala", "hisRhvsvCq", null, 1, null, null, "Irene72@hotmail.com", "Irene" },
                    { "Adela.Olivarez2383", null, "Olivárez", "BtqXYJdTVK", null, 1, null, null, "Adela_Olivarez@yahoo.com", "Adela" },
                    { "Adriana.Brito2392", null, "Brito", "MqhIIK_VGP", null, 1, null, null, "Adriana.Brito@gmail.com", "Adriana" },
                    { "Abraham702394", null, "Rosales", "Vr2twbaCjg", null, 1, null, null, "Abraham63@corpfolder.com", "Abraham" },
                    { "Lola_Benitez2395", null, "Benítez", "PiG3lVPas_", null, 1, null, null, "Lola.Benitez42@hotmail.com", "Lola" },
                    { "Rafael.Korta2396", null, "Korta", "VQ6_RcLuol", null, 1, null, null, "Rafael36@nearbpo.com", "Rafael" },
                    { "Uriel.Zapata2397", null, "Zapata", "NFhpCNJKeS", null, 1, null, null, "Uriel99@yahoo.com", "Uriel" },
                    { "Marta.Caraballo532398", null, "Caraballo", "HU69hk6n96", null, 1, null, null, "Marta.Caraballo61@yahoo.com", "Marta" },
                    { "Beatriz_Villanueva2399", null, "Villanueva", "pAdJqNK7_w", null, 1, null, null, "Beatriz.Villanueva39@hotmail.com", "Beatriz" },
                    { "Luz612400", null, "Polanco", "E9Q_vHggn4", null, 1, null, null, "Luz_Polanco@gmail.com", "Luz" },
                    { "AnaMaria.Alaniz2393", null, "Alaniz", "TK8I_wabKo", null, 1, null, null, "AnaMaria94@nearbpo.com", "Ana María" },
                    { "Leonor252188", null, "Delarosa", "6C0s_tPksL", null, 1, null, null, "Leonor.Delarosa@gmail.com", "Leonor" },
                    { "Nicole.Beltran232187", null, "Beltrán", "4QEbDj8tZs", null, 1, null, null, "Nicole74@corpfolder.com", "Nicole" },
                    { "Ines292186", null, "Lozano", "4SIwRGHUer", null, 1, null, null, "Ines.Lozano@gmail.com", "Inés" },
                    { "FranciscoJavier121975", null, "Caraballo", "OMUSgKbGlA", null, 1, null, null, "FranciscoJavier_Caraballo@yahoo.com", "Francisco Javier" },
                    { "Olivia_Olivo911976", null, "Olivo", "Lgxld3oTae", null, 1, null, null, "Olivia40@corpfolder.com", "Olivia" },
                    { "JuanManuel.Palacios841977", null, "Palacios", "P3Q3S3F3Ik", null, 1, null, null, "JuanManuel3@hotmail.com", "Juan Manuel" },
                    { "Alan891978", null, "Santana", "1luamBo7xi", null, 1, null, null, "Alan.Santana@nearbpo.com", "Alan" },
                    { "Marisol01979", null, "Naranjo", "2srA_ZZ_EQ", null, 1, null, null, "Marisol.Naranjo48@gmail.com", "Marisol" },
                    { "Cecilia_Cantu1980", null, "Cantú", "jTHQGKN_ZY", null, 1, null, null, "Cecilia42@hotmail.com", "Cecilia" },
                    { "Antonia451981", null, "Benítez", "EwRboUvV9r", null, 1, null, null, "Antonia37@nearbpo.com", "Antonia" },
                    { "Ruben.Fonseca231982", null, "Fonseca", "3oeKGFoTA3", null, 1, null, null, "Ruben19@yahoo.com", "Rubén" },
                    { "AnaVictoria_Mora91983", null, "Mora", "CKi3Jl65nT", null, 1, null, null, "AnaVictoria.Mora79@yahoo.com", "Ana Victoria" },
                    { "Soledad_Camarillo1984", null, "Camarillo", "x04Y8yZqTm", null, 1, null, null, "Soledad.Camarillo94@yahoo.com", "Soledad" },
                    { "Luz.Melgar181985", null, "Melgar", "gxwtl3QYXm", null, 1, null, null, "Luz_Melgar@gmail.com", "Luz" },
                    { "Gerardo.Bernal611986", null, "Bernal", "rXNogVpPb2", null, 1, null, null, "Gerardo.Bernal53@gmail.com", "Gerardo" },
                    { "Raul_Blanco1987", null, "Blanco", "O5UdWAWSFq", null, 1, null, null, "Raul2@nearbpo.com", "Raúl" },
                    { "Isaac.Vigil1988", null, "Vigil", "gLyI_OClHv", null, 1, null, null, "Isaac.Vigil@nearbpo.com", "Isaac" },
                    { "Abigail531989", null, "Hernandes", "SwVrKMHGvx", null, 1, null, null, "Abigail_Hernandes@yahoo.com", "Abigail" },
                    { "AnaSofia_Kanea321974", null, "Kanea", "14p3x9dQUy", null, 1, null, null, "AnaSofia36@hotmail.com", "Ana Sofía" },
                    { "Guadalupe.Ulibarri951973", null, "Ulibarri", "pmswO_cI9b", null, 1, null, null, "Guadalupe71@yahoo.com", "Guadalupe" },
                    { "Xochitl_Aguilera181972", null, "Aguilera", "Bdu2pMQ1mq", null, 1, null, null, "Xochitl61@corpfolder.com", "Xochitl" },
                    { "Ivan.Mireles1971", null, "Mireles", "aYkiIFjpbE", null, 1, null, null, "Ivan_Mireles48@nearbpo.com", "Ivan" },
                    { "Emily.Curiel1955", null, "Curiel", "13iQccJSnA", null, 1, null, null, "Emily_Curiel68@hotmail.com", "Emily" },
                    { "MariaCristina.Carbajal1956", null, "Carbajal", "fz1mVPLtFH", null, 1, null, null, "MariaCristina_Carbajal@gmail.com", "María Cristina" },
                    { "Anita.Cerda301957", null, "Cerda", "STDnx4WEhG", null, 1, null, null, "Anita86@gmail.com", "Anita" },
                    { "Esteban_Parra61958", null, "Parra", "zQ4jozLS24", null, 1, null, null, "Esteban.Parra@nearbpo.com", "Esteban" },
                    { "Martin101959", null, "Garica", "FekfhCI01l", null, 1, null, null, "Martin_Garica@yahoo.com", "Martín" },
                    { "Isaias.Hidalgo271960", null, "Hidalgo", "JsyKWDmWcJ", null, 1, null, null, "Isaias95@gmail.com", "Isaias" },
                    { "Florencia.Varela31961", null, "Varela", "iBFz8rYJWJ", null, 1, null, null, "Florencia40@hotmail.com", "Florencia" },
                    { "Jennifer_Montez1990", null, "Montez", "QePCVzNj0k", null, 1, null, null, "Jennifer18@nearbpo.com", "Jennifer" },
                    { "Jimena781962", null, "Saiz", "L2YV3fhn_Q", null, 1, null, null, "Jimena58@gmail.com", "Jimena" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Daniela831964", null, "Khalid", "riLwMFz7Zb", null, 1, null, null, "Daniela_Khalid36@yahoo.com", "Daniela" },
                    { "Adela_Chavarria1965", null, "Chavarría", "PM9LiEprT4", null, 1, null, null, "Adela.Chavarria7@gmail.com", "Adela" },
                    { "Carlos_Pichardo1966", null, "Pichardo", "eO0sYaqW2J", null, 1, null, null, "Carlos98@gmail.com", "Carlos" },
                    { "MariadelosAngeles.Rojas1967", null, "Rojas", "l_0dSEaQf8", null, 1, null, null, "MariadelosAngeles_Rojas@nearbpo.com", "María de los Ángeles" },
                    { "Ernesto741968", null, "Salazar", "BbiOcWJ30R", null, 1, null, null, "Ernesto.Salazar26@nearbpo.com", "Ernesto" },
                    { "JulioCesar_Frias341969", null, "Frías", "KTxvneQVIR", null, 1, null, null, "JulioCesar_Frias@nearbpo.com", "Julio César" },
                    { "Melissa.Solano1970", null, "Solano", "RYPkloFBB0", null, 1, null, null, "Melissa_Solano67@nearbpo.com", "Melissa" },
                    { "Victoria.Angulo1963", null, "Angulo", "pAO66MAc22", null, 1, null, null, "Victoria_Angulo8@hotmail.com", "Victoria" },
                    { "Gustavo_Tafoya1954", null, "Tafoya", "5lzX9eXg1a", null, 1, null, null, "Gustavo29@yahoo.com", "Gustavo" },
                    { "Esmeralda_Arce1991", null, "Arce", "YkmNYiQFKO", null, 1, null, null, "Esmeralda.Arce36@nearbpo.com", "Esmeralda" },
                    { "Margarita.Ulloa1993", null, "Ulloa", "hEMoxqVL45", null, 1, null, null, "Margarita81@gmail.com", "Margarita" },
                    { "Monserrat_Solis2014", null, "Solís", "rT2nA_HTe2", null, 1, null, null, "Monserrat60@yahoo.com", "Monserrat" },
                    { "Guadalupe782015", null, "Negrete", "9l_7hD0NwR", null, 1, null, null, "Guadalupe34@yahoo.com", "Guadalupe" },
                    { "MariaJose.Zamora2016", null, "Zamora", "7qJSR68gz8", null, 1, null, null, "MariaJose.Zamora@nearbpo.com", "María José" },
                    { "Eva.Corona2017", null, "Corona", "V983ls9_qz", null, 1, null, null, "Eva.Corona@gmail.com", "Eva" },
                    { "Isaac742018", null, "Preciado", "S_OmGZWik7", null, 1, null, null, "Isaac41@corpfolder.com", "Isaac" },
                    { "MariaTeresa352019", null, "Karen", "7f1JzEcoQV", null, 1, null, null, "MariaTeresa_Karen@corpfolder.com", "María Teresa" },
                    { "Rosario_Melgar2020", null, "Melgar", "ekQO2yrnGh", null, 1, null, null, "Rosario23@nearbpo.com", "Rosario" },
                    { "David.Urena462021", null, "Ureña", "9YsFmIZ4HB", null, 1, null, null, "David99@yahoo.com", "David" },
                    { "Natalia_Castillo652022", null, "Castillo", "p2j0ewtlBw", null, 1, null, null, "Natalia_Castillo70@yahoo.com", "Natalia" },
                    { "Elias.Pineda862023", null, "Pineda", "YsWQq7Zutb", null, 1, null, null, "Elias_Pineda@nearbpo.com", "Elías" },
                    { "FranciscoJavier_Saavedra432024", null, "Saavedra", "E0JP2Wkdh9", null, 1, null, null, "FranciscoJavier19@corpfolder.com", "Francisco Javier" },
                    { "David692025", null, "Cuellar", "MqGRzT0VKl", null, 1, null, null, "David90@nearbpo.com", "David" },
                    { "Isaias_Polanco2026", null, "Polanco", "_m8VPb0QWQ", null, 1, null, null, "Isaias_Polanco@corpfolder.com", "Isaias" },
                    { "Emiliano_Delarosa2027", null, "Delarosa", "fMfvngKEqK", null, 1, null, null, "Emiliano.Delarosa3@yahoo.com", "Emiliano" },
                    { "Julia.Valentin412028", null, "Valentín", "rHwCYinBg7", null, 1, null, null, "Julia34@corpfolder.com", "Julia" },
                    { "Blanca942013", null, "Llamas", "Rxmr1cFg9d", null, 1, null, null, "Blanca_Llamas34@corpfolder.com", "Blanca" },
                    { "Paulina.Carvajal2012", null, "Carvajal", "ZX80cRMA3G", null, 1, null, null, "Paulina_Carvajal9@yahoo.com", "Paulina" },
                    { "Gilberto62011", null, "Ocampo", "maFRuDa2e7", null, 1, null, null, "Gilberto_Ocampo62@nearbpo.com", "Gilberto" },
                    { "Jorge.Rivera2010", null, "Rivera", "llunD_uLXO", null, 1, null, null, "Jorge38@corpfolder.com", "Jorge" },
                    { "Natalia.Sosa1994", null, "Sosa", "4cp90uZwMn", null, 1, null, null, "Natalia54@nearbpo.com", "Natalia" },
                    { "Sonia.Peralta611995", null, "Peralta", "Gw42YxIwjt", null, 1, null, null, "Sonia13@hotmail.com", "Sonia" },
                    { "Ester661996", null, "Lozano", "grHTyWxVcN", null, 1, null, null, "Ester_Lozano@nearbpo.com", "Ester" },
                    { "Valeria.Alonso791997", null, "Alonso", "ELUo0wyA0Y", null, 1, null, null, "Valeria.Alonso91@yahoo.com", "Valeria" },
                    { "Renata.Echevarria231998", null, "Echevarría", "Adzopc5hUf", null, 1, null, null, "Renata_Echevarria@gmail.com", "Renata" },
                    { "AnaLuisa_Archuleta1999", null, "Archuleta", "YosgxvUBQU", null, 1, null, null, "AnaLuisa.Archuleta@nearbpo.com", "Ana Luisa" },
                    { "Lourdes.Maestas522000", null, "Maestas", "YxSOrlPE9g", null, 1, null, null, "Lourdes_Maestas28@hotmail.com", "Lourdes" },
                    { "Mariana771992", null, "Anaya", "y7Em_pcVPx", null, 1, null, null, "Mariana.Anaya98@corpfolder.com", "Mariana" },
                    { "AnaMaria.Arevalo942001", null, "Arevalo", "FE6T3HnbNH", null, 1, null, null, "AnaMaria95@yahoo.com", "Ana María" },
                    { "Axel582003", null, "Luevano", "6gr6ljvPeY", null, 1, null, null, "Axel_Luevano41@nearbpo.com", "Axel" },
                    { "AnaMaria_Agosto502004", null, "Agosto", "etiiAfRVT8", null, 1, null, null, "AnaMaria_Agosto@hotmail.com", "Ana María" },
                    { "Cecilia.Yago432005", null, "Yago", "6BrJYkxeCI", null, 1, null, null, "Cecilia_Yago8@gmail.com", "Cecilia" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Alfredo842006", null, "Aparicio", "hybtSXCcTO", null, 1, null, null, "Alfredo.Aparicio71@hotmail.com", "Alfredo" },
                    { "Melissa.Duran612007", null, "Duran", "T7_GReQ9u4", null, 1, null, null, "Melissa.Duran@yahoo.com", "Melissa" },
                    { "Manuela.Esparza2008", null, "Esparza", "ToMWOMQJrV", null, 1, null, null, "Manuela37@gmail.com", "Manuela" },
                    { "Dolores.Tello652009", null, "Tello", "8sVzAvhy5g", null, 1, null, null, "Dolores98@yahoo.com", "Dolores" },
                    { "Dorotea732002", null, "Mireles", "FuisWJMRfw", null, 1, null, null, "Dorotea50@hotmail.com", "Dorotea" },
                    { "Ramona_Mena652029", null, "Mena", "UENahenFhX", null, 1, null, null, "Ramona_Mena80@nearbpo.com", "Ramona" },
                    { "Jaime.Sandoval321953", null, "Sandoval", "rpO7__08tb", null, 1, null, null, "Jaime70@yahoo.com", "Jaime" },
                    { "Elias_Cadena1951", null, "Cadena", "zA6ibz3nHm", null, 1, null, null, "Elias_Cadena38@gmail.com", "Elías" },
                    { "Isabela.Rael1897", null, "Rael", "Xv9n66xQeL", null, 1, null, null, "Isabela_Rael29@corpfolder.com", "Isabela" },
                    { "Joaquin871898", null, "Karan", "BgA5Q02Nsg", null, 1, null, null, "Joaquin.Karan@hotmail.com", "Joaquín" },
                    { "Mateo851899", null, "Kanea", "Yqrhv93lU8", null, 1, null, null, "Mateo.Kanea10@nearbpo.com", "Mateo" },
                    { "Patricia151900", null, "Correa", "edzShDXP9G", null, 1, null, null, "Patricia46@nearbpo.com", "Patricia" },
                    { "Saul_Luna51901", null, "Luna", "C3Q7MDTuc5", null, 1, null, null, "Saul.Luna37@hotmail.com", "Saúl" },
                    { "Carlota201902", null, "Colunga", "nd911iF0Hj", null, 1, null, null, "Carlota_Colunga36@gmail.com", "Carlota" },
                    { "JuanPablo.Saucedo991903", null, "Saucedo", "YTqnwd0XGY", null, 1, null, null, "JuanPablo.Saucedo87@corpfolder.com", "Juan Pablo" },
                    { "JoseMaria_Lemus331904", null, "Lemus", "XI6FEc1ycA", null, 1, null, null, "JoseMaria_Lemus86@yahoo.com", "José María" },
                    { "Damian511905", null, "Angulo", "AW_FVEaKSA", null, 1, null, null, "Damian_Angulo17@nearbpo.com", "Damián" },
                    { "Victor351906", null, "Delatorre", "AsFN84GFEx", null, 1, null, null, "Victor_Delatorre@gmail.com", "Víctor" },
                    { "Elias_Esquibel411907", null, "Esquibel", "0Fuao_SKFL", null, 1, null, null, "Elias.Esquibel@nearbpo.com", "Elías" },
                    { "JoseMiguel.Cruz1908", null, "Cruz", "E6oodvbARW", null, 1, null, null, "JoseMiguel_Cruz@corpfolder.com", "José Miguel" },
                    { "Emmanuel_Quiros871909", null, "Quiros", "nyKFdIvhmT", null, 1, null, null, "Emmanuel.Quiros66@yahoo.com", "Emmanuel" },
                    { "Salvador.Garica1910", null, "Garica", "3Ff8Q02iJX", null, 1, null, null, "Salvador_Garica22@corpfolder.com", "Salvador" },
                    { "Eloisa.Palomino1911", null, "Palomino", "WLwTe6dP5l", null, 1, null, null, "Eloisa28@hotmail.com", "Eloisa" },
                    { "Lola.Alaniz1896", null, "Alaniz", "MZ1xS0ovaO", null, 1, null, null, "Lola.Alaniz2@corpfolder.com", "Lola" },
                    { "Diego_Saldana191895", null, "Saldaña", "SVANHDGqrB", null, 1, null, null, "Diego52@nearbpo.com", "Diego" },
                    { "Monica.Zabaleta831894", null, "Zabaleta", "N0I55rEDzW", null, 1, null, null, "Monica53@yahoo.com", "Mónica" },
                    { "Olivia.Benavides1893", null, "Benavides", "fEBS7Z1os3", null, 1, null, null, "Olivia78@hotmail.com", "Olivia" },
                    { "Raquel_Tovar1877", null, "Tovar", "FYz9Ohnyrq", null, 1, null, null, "Raquel16@gmail.com", "Raquel" },
                    { "Ivan_Yago1878", null, "Yago", "KZ2ScDMEsr", null, 1, null, null, "Ivan.Yago43@gmail.com", "Ivan" },
                    { "Rosa521879", null, "Juárez", "GwtcQ_vJ5P", null, 1, null, null, "Rosa.Juarez@nearbpo.com", "Rosa" },
                    { "Rosario.Ulibarri1880", null, "Ulibarri", "JVoLGSRBA9", null, 1, null, null, "Rosario_Ulibarri@hotmail.com", "Rosario" },
                    { "Hernan201881", null, "Sauceda", "yAROoplKid", null, 1, null, null, "Hernan19@nearbpo.com", "Hernán" },
                    { "David951882", null, "Matías", "Bjw7SeEQKH", null, 1, null, null, "David92@hotmail.com", "David" },
                    { "Adan91883", null, "Almanza", "0mGW5pe3Z2", null, 1, null, null, "Adan.Almanza19@gmail.com", "Adán" },
                    { "Gustavo_Madera1912", null, "Madera", "mihIfcy7_1", null, 1, null, null, "Gustavo10@hotmail.com", "Gustavo" },
                    { "Juan_Narvaez111884", null, "Narváez", "QvJuzWfMYU", null, 1, null, null, "Juan92@hotmail.com", "Juan" },
                    { "Felipe201886", null, "León", "rd_fx7WHK9", null, 1, null, null, "Felipe_Leon62@corpfolder.com", "Felipe" },
                    { "Federico_Villasenor1887", null, "Villaseñor", "ORgd_pjeyd", null, 1, null, null, "Federico_Villasenor58@corpfolder.com", "Federico" },
                    { "Esperanza91888", null, "Malave", "6KpQYz407i", null, 1, null, null, "Esperanza.Malave@hotmail.com", "Esperanza" },
                    { "Esteban491889", null, "Borrego", "IDQcqORDty", null, 1, null, null, "Esteban29@corpfolder.com", "Esteban" },
                    { "Vanessa_Velasquez451890", null, "Velásquez", "ymCwzTyLsu", null, 1, null, null, "Vanessa.Velasquez@nearbpo.com", "Vanessa" },
                    { "Cristian121891", null, "Gutiérrez", "JE821U2Ooi", null, 1, null, null, "Cristian47@nearbpo.com", "Cristian" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Yolanda.Becerra41892", null, "Becerra", "SONaAGnbES", null, 1, null, null, "Yolanda12@yahoo.com", "Yolanda" },
                    { "Gabriel161885", null, "Tejada", "4DohN02ftG", null, 1, null, null, "Gabriel_Tejada65@corpfolder.com", "Gabriel" },
                    { "Elisa_Nava1952", null, "Nava", "4zYJ7IQxaT", null, 1, null, null, "Elisa.Nava@nearbpo.com", "Elisa" },
                    { "Marcela.Cerda1913", null, "Cerda", "6ikrd97Tm8", null, 1, null, null, "Marcela86@nearbpo.com", "Marcela" },
                    { "AnaLuisa811915", null, "Vázquez", "qHdaL4Zqvv", null, 1, null, null, "AnaLuisa.Vazquez48@nearbpo.com", "Ana Luisa" },
                    { "Julia701936", null, "Acosta", "Np8S15XwnH", null, 1, null, null, "Julia.Acosta6@yahoo.com", "Julia" },
                    { "Reina101937", null, "Villalobos", "hOHWJlou0C", null, 1, null, null, "Reina_Villalobos85@gmail.com", "Reina" },
                    { "Luisa671938", null, "Gracia", "Z1L9WN3SWU", null, 1, null, null, "Luisa_Gracia63@nearbpo.com", "Luisa" },
                    { "Ester_Pineda1939", null, "Pineda", "CjzhLDRE9U", null, 1, null, null, "Ester92@nearbpo.com", "Ester" },
                    { "Armando_Melendez801940", null, "Meléndez", "2wCEJ8m344", null, 1, null, null, "Armando16@corpfolder.com", "Armando" },
                    { "AngelGabriel641941", null, "Linares", "TlqqNwfrlS", null, 1, null, null, "AngelGabriel_Linares@corpfolder.com", "Ángel Gabriel" },
                    { "Oscar951942", null, "Quezada", "YkWHAalEi2", null, 1, null, null, "Oscar_Quezada32@gmail.com", "Óscar" },
                    { "Elsa251943", null, "Robledo", "L0JfC7cn3S", null, 1, null, null, "Elsa39@hotmail.com", "Elsa" },
                    { "MariaJose231944", null, "Kanea", "YjKZmZHUZw", null, 1, null, null, "MariaJose.Kanea@yahoo.com", "María José" },
                    { "LuisMiguel.Valencia711945", null, "Valencia", "xF1vZhramb", null, 1, null, null, "LuisMiguel_Valencia94@hotmail.com", "Luis Miguel" },
                    { "Estefania231946", null, "Salazar", "oQG7P7RV__", null, 1, null, null, "Estefania_Salazar61@yahoo.com", "Estefanía" },
                    { "Xochitl721947", null, "Rojo", "YqzgNLFKNg", null, 1, null, null, "Xochitl.Rojo8@yahoo.com", "Xochitl" },
                    { "Erick571948", null, "Koenig", "0OYZjoQIS5", null, 1, null, null, "Erick.Koenig@nearbpo.com", "Erick" },
                    { "Julio_Mayorga291949", null, "Mayorga", "oQOwSEeUts", null, 1, null, null, "Julio52@nearbpo.com", "Julio" },
                    { "Benito741950", null, "Rivera", "btyuKX7s7R", null, 1, null, null, "Benito95@yahoo.com", "Benito" },
                    { "Valeria171935", null, "Fuentes", "WaeQLLSIBX", null, 1, null, null, "Valeria55@hotmail.com", "Valeria" },
                    { "Clemente.Sauceda711934", null, "Sauceda", "4eg99NPLEg", null, 1, null, null, "Clemente52@nearbpo.com", "Clemente" },
                    { "Angela.Kanea61933", null, "Kanea", "qKMxeEN1gG", null, 1, null, null, "Angela22@corpfolder.com", "Ángela" },
                    { "MariaCristina_Hurtado1932", null, "Hurtado", "ojX76zrMgT", null, 1, null, null, "MariaCristina_Hurtado@hotmail.com", "María Cristina" },
                    { "Daniel_Trujillo721916", null, "Trujillo", "33oCCZUma6", null, 1, null, null, "Daniel.Trujillo36@corpfolder.com", "Daniel" },
                    { "Raul_Solorzano811917", null, "Solorzano", "yHxWJqnvR6", null, 1, null, null, "Raul_Solorzano32@gmail.com", "Raúl" },
                    { "Patricia.Corral91918", null, "Corral", "qDlsV1PyIN", null, 1, null, null, "Patricia.Corral93@yahoo.com", "Patricia" },
                    { "MarcoAntonio.Zamarripa371919", null, "Zamarripa", "tLzdKynP7z", null, 1, null, null, "MarcoAntonio_Zamarripa4@hotmail.com", "Marco Antonio" },
                    { "Saul_Riojas1920", null, "Riojas", "RICNw9GOFw", null, 1, null, null, "Saul_Riojas@yahoo.com", "Saúl" },
                    { "Hugo01921", null, "Kortajarena", "LL1IbWcTy4", null, 1, null, null, "Hugo_Kortajarena@hotmail.com", "Hugo" },
                    { "Elizabeth.Razo921922", null, "Razo", "fSSOUtYv5v", null, 1, null, null, "Elizabeth.Razo28@nearbpo.com", "Elizabeth" },
                    { "Concepcion881914", null, "Estévez", "ia_09abuJH", null, 1, null, null, "Concepcion_Estevez20@corpfolder.com", "Concepción" },
                    { "Reina641923", null, "Cabán", "CZyLccPnjC", null, 1, null, null, "Reina.Caban@gmail.com", "Reina" },
                    { "Brandon.Rosales531925", null, "Rosales", "6WdBB4cVXm", null, 1, null, null, "Brandon.Rosales@yahoo.com", "Brandon" },
                    { "Gabriela_Mendoza1926", null, "Mendoza", "6Kb1pEx_zW", null, 1, null, null, "Gabriela26@nearbpo.com", "Gabriela" },
                    { "Victor_Macias1927", null, "Macías", "QFjtI13Vx0", null, 1, null, null, "Victor_Macias@nearbpo.com", "Víctor" },
                    { "Cristobal_Jasso791928", null, "Jasso", "hdK2Nm4Uy6", null, 1, null, null, "Cristobal79@corpfolder.com", "Cristobal" },
                    { "Rosa_Ulibarri531929", null, "Ulibarri", "hLetS5OMoo", null, 1, null, null, "Rosa98@yahoo.com", "Rosa" },
                    { "Renata_Aparicio751930", null, "Aparicio", "1tLQJa6zWe", null, 1, null, null, "Renata_Aparicio15@yahoo.com", "Renata" },
                    { "David.Valdes641931", null, "Valdés", "gnzTMX6hpV", null, 1, null, null, "David66@corpfolder.com", "David" },
                    { "Gustavo.Kanzaki931924", null, "Kanzaki", "kw7ymd9TuY", null, 1, null, null, "Gustavo.Kanzaki29@hotmail.com", "Gustavo" },
                    { "Jose_Gonzalez2030", null, "González", "z3PhIl6ml_", null, 1, null, null, "Jose.Gonzalez@gmail.com", "José" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Julio.Bermudez2031", null, "Bermúdez", "oyM9fX3IJC", null, 1, null, null, "Julio92@hotmail.com", "Julio" },
                    { "MariaCristina182032", null, "Escobar", "WzkedWzvyU", null, 1, null, null, "MariaCristina.Escobar83@nearbpo.com", "María Cristina" },
                    { "Vicente.Pina632132", null, "Piña", "l6_uf0d5B8", null, 1, null, null, "Vicente65@hotmail.com", "Vicente" },
                    { "XimenaGuadalupe.Sarabia2133", null, "Sarabia", "wJNUU3X3b5", null, 1, null, null, "XimenaGuadalupe.Sarabia@yahoo.com", "Ximena Guadalupe" },
                    { "Francisco_Cervantez832134", null, "Cervántez", "IrG0dO21mZ", null, 1, null, null, "Francisco_Cervantez8@yahoo.com", "Francisco" },
                    { "Marcela.Alcala2135", null, "Alcala", "uhFb6OpMTc", null, 1, null, null, "Marcela.Alcala35@hotmail.com", "Marcela" },
                    { "Juana.Karen2136", null, "Karen", "W4Pt5xt7cr", null, 1, null, null, "Juana_Karen@corpfolder.com", "Juana" },
                    { "Jazmin542137", null, "Varela", "qpSJuGnw7H", null, 1, null, null, "Jazmin40@nearbpo.com", "Jazmin" },
                    { "Ana_Robledo792138", null, "Robledo", "eRN264e_4M", null, 1, null, null, "Ana.Robledo84@nearbpo.com", "Ana" },
                    { "Vanessa.Munguia2139", null, "Munguía", "_2EcqcYY0s", null, 1, null, null, "Vanessa_Munguia81@corpfolder.com", "Vanessa" },
                    { "Patricia.Serrato72140", null, "Serrato", "3jVFhrTfqp", null, 1, null, null, "Patricia_Serrato76@yahoo.com", "Patricia" },
                    { "Octavio_Ulibarri862141", null, "Ulibarri", "ZsmcSRjN1H", null, 1, null, null, "Octavio_Ulibarri@nearbpo.com", "Octavio" },
                    { "Ivanna_Esquibel2142", null, "Esquibel", "VHxLXUKWEx", null, 1, null, null, "Ivanna.Esquibel84@yahoo.com", "Ivanna" },
                    { "Alexa762143", null, "Pedraza", "HKW5tVt7kU", null, 1, null, null, "Alexa_Pedraza@hotmail.com", "Alexa" },
                    { "Lorenzo_Gutierrez72144", null, "Gutiérrez", "024APq8PIB", null, 1, null, null, "Lorenzo.Gutierrez2@gmail.com", "Lorenzo" },
                    { "Lorena752145", null, "Tórrez", "Wb6kZDSQEE", null, 1, null, null, "Lorena81@yahoo.com", "Lorena" },
                    { "Emilia852146", null, "Partida", "RH2WTDP7gP", null, 1, null, null, "Emilia27@nearbpo.com", "Emilia" },
                    { "Melissa_Romo2131", null, "Romo", "7eitrnCFxy", null, 1, null, null, "Melissa.Romo@gmail.com", "Melissa" },
                    { "Lorenzo_Almonte2130", null, "Almonte", "KEDhdIGctE", null, 1, null, null, "Lorenzo.Almonte@gmail.com", "Lorenzo" },
                    { "Marisol902129", null, "Fajardo", "DYoaZzLIQS", null, 1, null, null, "Marisol.Fajardo3@hotmail.com", "Marisol" },
                    { "Cesar_Valladares2128", null, "Valladares", "B_eiLpu_rS", null, 1, null, null, "Cesar_Valladares@yahoo.com", "César" },
                    { "JoseAntonio_Ponce2112", null, "Ponce", "K2PwsfXJI4", null, 1, null, null, "JoseAntonio.Ponce11@corpfolder.com", "José Antonio" },
                    { "Alan52113", null, "Caldera", "t6QD2wbifS", null, 1, null, null, "Alan61@gmail.com", "Alan" },
                    { "Emily802114", null, "Frías", "5H8mNAKZcB", null, 1, null, null, "Emily.Frias79@nearbpo.com", "Emily" },
                    { "Valeria432115", null, "Sisneros", "EWbXStcAQn", null, 1, null, null, "Valeria.Sisneros35@yahoo.com", "Valeria" },
                    { "Martin.Guerra202116", null, "Guerra", "KDU5qRrApE", null, 1, null, null, "Martin_Guerra84@nearbpo.com", "Martín" },
                    { "Clemente322117", null, "Quintero cruz", "CRKKTaO8Op", null, 1, null, null, "Clemente59@nearbpo.com", "Clemente" },
                    { "Silvia_Pacheco942118", null, "Pacheco", "sH3AapxWuu", null, 1, null, null, "Silvia36@yahoo.com", "Silvia" },
                    { "VictorManuel_Montez2147", null, "Montez", "8fRdlC0nSY", null, 1, null, null, "VictorManuel_Montez65@gmail.com", "Victor Manuel" },
                    { "Vicente.Rojo832119", null, "Rojo", "iykHDTa9Y2", null, 1, null, null, "Vicente85@hotmail.com", "Vicente" },
                    { "Alexa.Loera2121", null, "Loera", "7G8mN6NcSS", null, 1, null, null, "Alexa56@hotmail.com", "Alexa" },
                    { "AlondraRomina_Carrero542122", null, "Carrero", "IMUky9y80p", null, 1, null, null, "AlondraRomina_Carrero27@gmail.com", "Alondra Romina" },
                    { "Anita.Beltran2123", null, "Beltrán", "n5yj0V3_23", null, 1, null, null, "Anita.Beltran62@gmail.com", "Anita" },
                    { "Julieta.Gallardo542124", null, "Gallardo", "aD0lMYzJrR", null, 1, null, null, "Julieta.Gallardo37@nearbpo.com", "Julieta" },
                    { "Pilar.Nunez2125", null, "Núñez", "1xK2esv2z8", null, 1, null, null, "Pilar83@corpfolder.com", "Pilar" },
                    { "Roberto.Barajas2126", null, "Barajas", "bswln0oSPd", null, 1, null, null, "Roberto_Barajas71@hotmail.com", "Roberto" },
                    { "Florencia_Reyna2127", null, "Reyna", "_9DPiEL9wf", null, 1, null, null, "Florencia_Reyna@corpfolder.com", "Florencia" },
                    { "Paulina352120", null, "Cervántez", "LvgzCsXtoP", null, 1, null, null, "Paulina_Cervantez@yahoo.com", "Paulina" },
                    { "Olivia_Arteaga2111", null, "Arteaga", "AQ_WyEXPME", null, 1, null, null, "Olivia.Arteaga@hotmail.com", "Olivia" },
                    { "Dorotea_Candelaria2148", null, "Candelaria", "VmTNj1vUp6", null, 1, null, null, "Dorotea_Candelaria19@gmail.com", "Dorotea" },
                    { "Jeronimo_Martinez2150", null, "Martínez", "89RwRqhYXS", null, 1, null, null, "Jeronimo_Martinez15@hotmail.com", "Jerónimo" },
                    { "Ricardo_Najera2171", null, "Nájera", "cnRjwzvcA4", null, 1, null, null, "Ricardo_Najera19@corpfolder.com", "Ricardo" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Lizbeth.Navarrete472172", null, "Navarrete", "yIabMhQPtA", null, 1, null, null, "Lizbeth.Navarrete15@nearbpo.com", "Lizbeth" },
                    { "Magdalena_Cortes2173", null, "Cortés", "ODdEqpif2X", null, 1, null, null, "Magdalena.Cortes72@yahoo.com", "Magdalena" },
                    { "Silvia_Serrato412174", null, "Serrato", "XgE7mxMDA7", null, 1, null, null, "Silvia13@gmail.com", "Silvia" },
                    { "Brandon.Barajas332175", null, "Barajas", "sDtXrCXjtc", null, 1, null, null, "Brandon.Barajas81@yahoo.com", "Brandon" },
                    { "Rodrigo_Nevarez2176", null, "Nevárez", "KRMbAlLqI4", null, 1, null, null, "Rodrigo.Nevarez47@nearbpo.com", "Rodrigo" },
                    { "Yamileth742177", null, "Arevalo", "BBbPCJwSxB", null, 1, null, null, "Yamileth.Arevalo@corpfolder.com", "Yamileth" },
                    { "Elias_Yebra262178", null, "Yebra", "T7gfledJqA", null, 1, null, null, "Elias.Yebra@corpfolder.com", "Elías" },
                    { "Hernan892179", null, "Mota", "Uw9IM4lFEH", null, 1, null, null, "Hernan.Mota@nearbpo.com", "Hernán" },
                    { "Guadalupe_Orta2180", null, "Orta", "3JJUSOenjL", null, 1, null, null, "Guadalupe6@nearbpo.com", "Guadalupe" },
                    { "Gloria_Correa2181", null, "Correa", "zkb78SOLqr", null, 1, null, null, "Gloria87@corpfolder.com", "Gloria" },
                    { "Emiliano_Alarcon792182", null, "Alarcón", "UFqy7CB9_O", null, 1, null, null, "Emiliano_Alarcon@hotmail.com", "Emiliano" },
                    { "Juana.Maestas232183", null, "Maestas", "QhJ4t95hdD", null, 1, null, null, "Juana.Maestas@nearbpo.com", "Juana" },
                    { "LuisMiguel802184", null, "Domínguez", "uVMAGX8Kw5", null, 1, null, null, "LuisMiguel.Dominguez@hotmail.com", "Luis Miguel" },
                    { "Jeronimo.Jasso902185", null, "Jasso", "KLTqIhfYRp", null, 1, null, null, "Jeronimo49@corpfolder.com", "Jerónimo" },
                    { "Sergio302170", null, "Serrato", "c6t6IfYzoN", null, 1, null, null, "Sergio82@yahoo.com", "Sergio" },
                    { "Aaron.Caldera642169", null, "Caldera", "EBna1a4aq1", null, 1, null, null, "Aaron.Caldera@nearbpo.com", "Aarón" },
                    { "Jeronimo.Najera592168", null, "Nájera", "kxKRu9GPEg", null, 1, null, null, "Jeronimo_Najera@nearbpo.com", "Jerónimo" },
                    { "Estefania.Parra2167", null, "Parra", "Mojod_NSpp", null, 1, null, null, "Estefania.Parra28@yahoo.com", "Estefanía" },
                    { "Elsa.Pulido602151", null, "Pulido", "loZ7TiravP", null, 1, null, null, "Elsa.Pulido@gmail.com", "Elsa" },
                    { "Elena442152", null, "Alvarado", "CsEezHS5wP", null, 1, null, null, "Elena82@gmail.com", "Elena" },
                    { "Emilio922153", null, "Casares", "FPC_ukHUUu", null, 1, null, null, "Emilio.Casares@hotmail.com", "Emilio" },
                    { "Monserrat.Acevedo622154", null, "Acevedo", "Seqj1kNOfZ", null, 1, null, null, "Monserrat_Acevedo29@nearbpo.com", "Monserrat" },
                    { "LuisAngel.Acevedo502155", null, "Acevedo", "4PK1Xr9uPs", null, 1, null, null, "LuisAngel_Acevedo@corpfolder.com", "Luis Ángel" },
                    { "MariadelosAngeles72156", null, "Acevedo", "3E_2QHh9UQ", null, 1, null, null, "MariadelosAngeles_Acevedo@hotmail.com", "María de los Ángeles" },
                    { "Victoria_Orta322157", null, "Orta", "MkwHkTcwMl", null, 1, null, null, "Victoria_Orta13@gmail.com", "Victoria" },
                    { "Brayan312149", null, "Marrero", "645oTWs4hI", null, 1, null, null, "Brayan11@nearbpo.com", "Brayan" },
                    { "Teresa202158", null, "Paredes", "C_6AiOXiU1", null, 1, null, null, "Teresa40@yahoo.com", "Teresa" },
                    { "Damian_Reyna2160", null, "Reyna", "BdbNRMQEUy", null, 1, null, null, "Damian11@nearbpo.com", "Damián" },
                    { "Berta252161", null, "León", "p7bDAsaebE", null, 1, null, null, "Berta86@corpfolder.com", "Berta" },
                    { "Miguel802162", null, "Loera", "mRrWDEum7N", null, 1, null, null, "Miguel.Loera45@hotmail.com", "Miguel" },
                    { "Elias.Gomez362163", null, "Gómez", "kIqT0JBKEw", null, 1, null, null, "Elias.Gomez@yahoo.com", "Elías" },
                    { "Camila452164", null, "Solorzano", "nKu77JDTI4", null, 1, null, null, "Camila_Solorzano@hotmail.com", "Camila" },
                    { "Melissa_Mayorga2165", null, "Mayorga", "w0vuRFurw6", null, 1, null, null, "Melissa48@gmail.com", "Melissa" },
                    { "Carlos892166", null, "Barraza", "UAkrk3MOYm", null, 1, null, null, "Carlos_Barraza12@corpfolder.com", "Carlos" },
                    { "Ines.Quiroz2159", null, "Quiroz", "U0Q29fwxem", null, 1, null, null, "Ines_Quiroz72@gmail.com", "Inés" },
                    { "Laura592110", null, "Sarabia", "ljfMxQuFcI", null, 1, null, null, "Laura_Sarabia@corpfolder.com", "Laura" },
                    { "Alejandro_Cornejo882109", null, "Cornejo", "2InFABse5A", null, 1, null, null, "Alejandro5@hotmail.com", "Alejandro" },
                    { "Camila782108", null, "Quiñónez", "nQWFyMcECS", null, 1, null, null, "Camila_Quinonez@gmail.com", "Camila" },
                    { "XimenaGuadalupe.Razo2053", null, "Razo", "7dchfd_NMP", null, 1, null, null, "XimenaGuadalupe50@yahoo.com", "Ximena Guadalupe" },
                    { "Marisol_Resendez2054", null, "Reséndez", "cO3I5ptW08", null, 1, null, null, "Marisol53@nearbpo.com", "Marisol" },
                    { "AngelGabriel_Pantoja342055", null, "Pantoja", "6lfEws6vJZ", null, 1, null, null, "AngelGabriel.Pantoja6@yahoo.com", "Ángel Gabriel" },
                    { "Gael922056", null, "Prado", "CVCfu8sulW", null, 1, null, null, "Gael86@hotmail.com", "Gael" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Araceli542057", null, "Pantoja", "HnMtbmXuRs", null, 1, null, null, "Araceli.Pantoja@nearbpo.com", "Araceli" },
                    { "AnaVictoria.Solano342058", null, "Solano", "wToUO_boHT", null, 1, null, null, "AnaVictoria_Solano75@nearbpo.com", "Ana Victoria" },
                    { "Cristobal502059", null, "Limón", "kgzbMF6qJk", null, 1, null, null, "Cristobal72@yahoo.com", "Cristobal" },
                    { "Rosario.Gallegos472060", null, "Gallegos", "eJL8pJi75v", null, 1, null, null, "Rosario.Gallegos74@hotmail.com", "Rosario" },
                    { "Carmen_Torrez172061", null, "Tórrez", "zg07ofqG57", null, 1, null, null, "Carmen90@yahoo.com", "Carmen" },
                    { "Agustin812062", null, "Arenas", "3UumEo5YAo", null, 1, null, null, "Agustin.Arenas@gmail.com", "Agustín" },
                    { "Armando_Romo2063", null, "Romo", "lZDmuSZ5dW", null, 1, null, null, "Armando67@corpfolder.com", "Armando" },
                    { "Daniela372064", null, "Roldán", "P8xIi6CkBm", null, 1, null, null, "Daniela85@yahoo.com", "Daniela" },
                    { "Marilu312065", null, "Acevedo", "XL5aRXNzZQ", null, 1, null, null, "Marilu12@nearbpo.com", "Marilu" },
                    { "Enrique_Renteria222066", null, "Rentería", "iAj2ICrkE_", null, 1, null, null, "Enrique1@corpfolder.com", "Enrique" },
                    { "Melissa.Amador2067", null, "Amador", "G1p9zsmhd5", null, 1, null, null, "Melissa.Amador55@gmail.com", "Melissa" },
                    { "Angela.Villalpando122052", null, "Villalpando", "hsoFqNnIdm", null, 1, null, null, "Angela_Villalpando@nearbpo.com", "Ángela" },
                    { "Kimberly902051", null, "Nieto", "JdBymevdnx", null, 1, null, null, "Kimberly.Nieto@hotmail.com", "Kimberly" },
                    { "Arturo_Vergara2050", null, "Vergara", "qg4LJZsW5U", null, 1, null, null, "Arturo_Vergara@nearbpo.com", "Arturo" },
                    { "Elisa_Urbina352049", null, "Urbina", "binru4OdYw", null, 1, null, null, "Elisa.Urbina@yahoo.com", "Elisa" },
                    { "Gabriela182033", null, "Gaytán", "0CBvxCyT9O", null, 1, null, null, "Gabriela_Gaytan@hotmail.com", "Gabriela" },
                    { "Mario152034", null, "Ríos", "OsgA8iyzVH", null, 1, null, null, "Mario_Rios@hotmail.com", "Mario" },
                    { "Benito_Rubio2035", null, "Rubio", "OF2unsMWwd", null, 1, null, null, "Benito.Rubio29@gmail.com", "Benito" },
                    { "Ricardo_Salcedo2036", null, "Salcedo", "XWS4pNsxbz", null, 1, null, null, "Ricardo.Salcedo@hotmail.com", "Ricardo" },
                    { "Fatima642037", null, "Ceballos", "FZaZaaVGDN", null, 1, null, null, "Fatima.Ceballos14@nearbpo.com", "Fatima" },
                    { "Mayte.Urena2038", null, "Ureña", "5oLkiSG2yx", null, 1, null, null, "Mayte.Urena14@nearbpo.com", "Mayte" },
                    { "Ramiro.Alcaraz2039", null, "Alcaraz", "OVSyDz4bWm", null, 1, null, null, "Ramiro.Alcaraz52@nearbpo.com", "Ramiro" },
                    { "Gabriela_Nieves122068", null, "Nieves", "gUP4JyYAIF", null, 1, null, null, "Gabriela_Nieves14@hotmail.com", "Gabriela" },
                    { "Abigail.Llamas2040", null, "Llamas", "5BKeJSzWWe", null, 1, null, null, "Abigail_Llamas14@gmail.com", "Abigail" },
                    { "Iker.Avalos2042", null, "Ávalos", "9nu42a7QUO", null, 1, null, null, "Iker40@nearbpo.com", "Iker" },
                    { "Isabel42043", null, "Zamarreno", "oOcAfArUFX", null, 1, null, null, "Isabel.Zamarreno73@corpfolder.com", "Isabel" },
                    { "Claudio652044", null, "Zamora", "qe7DLvSgiP", null, 1, null, null, "Claudio.Zamora@gmail.com", "Claudio" },
                    { "Teodoro.Dominquez2045", null, "Domínquez", "fpMTttE657", null, 1, null, null, "Teodoro_Dominquez@hotmail.com", "Teodoro" },
                    { "Esteban792046", null, "Palomino", "uRzIs2S1_q", null, 1, null, null, "Esteban.Palomino@corpfolder.com", "Esteban" },
                    { "Joaquin_Cornejo82047", null, "Cornejo", "pMoLqsnIEu", null, 1, null, null, "Joaquin.Cornejo@corpfolder.com", "Joaquín" },
                    { "Jorge72048", null, "Sevilla", "59xDviNfkM", null, 1, null, null, "Jorge.Sevilla94@gmail.com", "Jorge" },
                    { "Eloisa.deAnda852041", null, "de Anda", "6AV0zUoRYp", null, 1, null, null, "Eloisa46@nearbpo.com", "Eloisa" },
                    { "Norma.Batista842069", null, "Batista", "1A9yRBd42X", null, 1, null, null, "Norma77@corpfolder.com", "Norma" },
                    { "Barbara312070", null, "Atencio", "n_I3ohtoZu", null, 1, null, null, "Barbara_Atencio@hotmail.com", "Barbara" },
                    { "Raul.Gonzalez882071", null, "González", "F77PuawYa7", null, 1, null, null, "Raul42@yahoo.com", "Raúl" },
                    { "MarcoAntonio542092", null, "Alejandro", "svfJ9y3JOi", null, 1, null, null, "MarcoAntonio49@hotmail.com", "Marco Antonio" },
                    { "Patricio_Murillo2093", null, "Murillo", "tTjmfy1eh0", null, 1, null, null, "Patricio14@hotmail.com", "Patricio" },
                    { "Daniela_Zayas222094", null, "Zayas", "X0gKNEYyvn", null, 1, null, null, "Daniela71@gmail.com", "Daniela" },
                    { "Adriana.Salazar2095", null, "Salazar", "gHXbZ4wrjo", null, 1, null, null, "Adriana77@gmail.com", "Adriana" },
                    { "Gustavo812096", null, "Sarabia", "_T5kEGO3_F", null, 1, null, null, "Gustavo.Sarabia@hotmail.com", "Gustavo" },
                    { "Maricarmen_Prieto932097", null, "Prieto", "vgtbDIp33l", null, 1, null, null, "Maricarmen.Prieto73@corpfolder.com", "Maricarmen" },
                    { "Gabriela_Mares362098", null, "Mares", "HgCk8qG8sg", null, 1, null, null, "Gabriela86@hotmail.com", "Gabriela" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "JoseMaria262091", null, "Carreón", "vUY_w_QpgY", null, 1, null, null, "JoseMaria_Carreon76@yahoo.com", "José María" },
                    { "Daniel.Negron2099", null, "Negrón", "RdACbyIRUk", null, 1, null, null, "Daniel_Negron50@gmail.com", "Daniel" },
                    { "Oscar.Aparicio2101", null, "Aparicio", "0ov4Rm1c9D", null, 1, null, null, "Oscar55@corpfolder.com", "Óscar" },
                    { "Adriana_Miranda2102", null, "Miranda", "UZA2wH9abE", null, 1, null, null, "Adriana97@nearbpo.com", "Adriana" },
                    { "Pedro272103", null, "Valles", "t0HjVA6HxM", null, 1, null, null, "Pedro_Valles94@yahoo.com", "Pedro" },
                    { "Federico192104", null, "Valdés", "a1QcHvbfsx", null, 1, null, null, "Federico_Valdes57@yahoo.com", "Federico" },
                    { "Emiliano_Altamirano852105", null, "Altamirano", "KlYBT_TYpE", null, 1, null, null, "Emiliano.Altamirano37@corpfolder.com", "Emiliano" },
                    { "Emily862106", null, "Tapia", "Zf15TqGRde", null, 1, null, null, "Emily.Tapia@corpfolder.com", "Emily" },
                    { "MariaElena542107", null, "Balderas", "jdMAg49VOz", null, 1, null, null, "MariaElena11@hotmail.com", "María Elena" },
                    { "LuisMiguel_Montez432100", null, "Montez", "Z0FgsaKHY5", null, 1, null, null, "LuisMiguel92@corpfolder.com", "Luis Miguel" },
                    { "Alfredo501875", null, "Barragán", "YBMbMuHacO", null, 1, null, null, "Alfredo_Barragan26@gmail.com", "Alfredo" },
                    { "Elsa_Zambrana612090", null, "Zambrana", "h97Yl0LnDA", null, 1, null, null, "Elsa_Zambrana@yahoo.com", "Elsa" },
                    { "Ivanna_Guerra902088", null, "Guerra", "OiuF33ZyvK", null, 1, null, null, "Ivanna64@nearbpo.com", "Ivanna" },
                    { "Marcos_Krauelnatera912072", null, "Krauel natera", "1iLtY28lHG", null, 1, null, null, "Marcos73@gmail.com", "Marcos" },
                    { "Susana.Alonzo2073", null, "Alonzo", "oCUx_MqR6i", null, 1, null, null, "Susana15@nearbpo.com", "Susana" },
                    { "Marilu.Kortajarena762074", null, "Kortajarena", "v1rLSZPIx1", null, 1, null, null, "Marilu18@hotmail.com", "Marilu" },
                    { "MariaTeresa.Cordero462075", null, "Cordero", "6lvjwKRedl", null, 1, null, null, "MariaTeresa56@corpfolder.com", "María Teresa" },
                    { "Adriana_Guardado842076", null, "Guardado", "3cW44MkZ99", null, 1, null, null, "Adriana60@corpfolder.com", "Adriana" },
                    { "Rosa.Cardona2077", null, "Cardona", "xiAC_EccMb", null, 1, null, null, "Rosa.Cardona20@gmail.com", "Rosa" },
                    { "Jesus252078", null, "Cruz", "B_F1tOOIra", null, 1, null, null, "Jesus_Cruz@corpfolder.com", "Jesús" },
                    { "Antonia.Melgar2089", null, "Melgar", "lIUwpxmA4b", null, 1, null, null, "Antonia.Melgar@corpfolder.com", "Antonia" },
                    { "Isabel.Gonzales2079", null, "Gonzales", "2txxyX6G6g", null, 1, null, null, "Isabel_Gonzales@hotmail.com", "Isabel" },
                    { "Renata_Meza2081", null, "Meza", "KOo4vnyx7q", null, 1, null, null, "Renata.Meza@nearbpo.com", "Renata" },
                    { "MariaSoledad_Nunez2082", null, "Núñez", "0fDJbiAD6f", null, 1, null, null, "MariaSoledad.Nunez@nearbpo.com", "María Soledad" },
                    { "Ines.Nunez182083", null, "Núñez", "lcXFMQlVzZ", null, 1, null, null, "Ines82@corpfolder.com", "Inés" },
                    { "Paola_Delagarza2084", null, "Delagarza", "IleM5Q2qPa", null, 1, null, null, "Paola_Delagarza26@hotmail.com", "Paola" },
                    { "Diana_Zapata2085", null, "Zapata", "TVkZOSljAx", null, 1, null, null, "Diana87@nearbpo.com", "Diana" },
                    { "Teodoro752086", null, "Villaseñor", "bDk2HEedid", null, 1, null, null, "Teodoro10@yahoo.com", "Teodoro" },
                    { "Silvia_Mayorga552087", null, "Mayorga", "hcfbsw6mGb", null, 1, null, null, "Silvia_Mayorga65@gmail.com", "Silvia" },
                    { "Lola262080", null, "Kanzaki", "V48CVWsR34", null, 1, null, null, "Lola_Kanzaki@yahoo.com", "Lola" },
                    { "Xochitl.Pantoja1250", null, "Pantoja", "VRHzVfNGJR", null, 1, null, null, "Xochitl_Pantoja@gmail.com", "Xochitl" },
                    { "Sancho.Ulibarri301249", null, "Ulibarri", "NX0x0VUcAP", null, 1, null, null, "Sancho_Ulibarri90@nearbpo.com", "Sancho" },
                    { "Samuel301248", null, "Quintana", "gQg4rkAEOK", null, 1, null, null, "Samuel.Quintana@hotmail.com", "Samuel" },
                    { "Alfonso.Jimenez3412", null, "Jiménez", "2JSkCdMBoq", null, 1, null, null, "Alfonso30@yahoo.com", "Alfonso" },
                    { "Dolores.Padilla413", null, "Padilla", "TWsj9mQ9AU", null, 1, null, null, "Dolores27@corpfolder.com", "Dolores" },
                    { "MariaCristina_Solano3414", null, "Solano", "byFT1rjta4", null, 1, null, null, "MariaCristina_Solano97@yahoo.com", "María Cristina" },
                    { "JoseDaniel.Cavazos415", null, "Cavazos", "dmBVZCayP4", null, 1, null, null, "JoseDaniel_Cavazos20@nearbpo.com", "Jose Daniel" },
                    { "JoseMaria.Rojas62416", null, "Rojas", "ttfDwm1qHd", null, 1, null, null, "JoseMaria_Rojas41@hotmail.com", "José María" },
                    { "Emmanuel84417", null, "Estévez", "AfOU21nyiP", null, 1, null, null, "Emmanuel80@nearbpo.com", "Emmanuel" },
                    { "MariaEugenia75418", null, "Oquendo", "hjTOjtlXfj", null, 1, null, null, "MariaEugenia82@nearbpo.com", "María Eugenia" },
                    { "Maria_Garza419", null, "Garza", "BkA3AG9331", null, 1, null, null, "Maria_Garza@hotmail.com", "María" },
                    { "Xochitl.Saucedo420", null, "Saucedo", "GtYzq3h1ib", null, 1, null, null, "Xochitl_Saucedo88@yahoo.com", "Xochitl" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "MariaGuadalupe.Mora421", null, "Mora", "SLxrr4boit", null, 1, null, null, "MariaGuadalupe_Mora89@corpfolder.com", "María Guadalupe" },
                    { "Raul30422", null, "Guerra", "IOFUhnhIGQ", null, 1, null, null, "Raul.Guerra@nearbpo.com", "Raúl" },
                    { "Gabriel4423", null, "Garica", "GttNklMJKQ", null, 1, null, null, "Gabriel_Garica6@gmail.com", "Gabriel" },
                    { "Arturo.Gonzalez38424", null, "González", "vqzYDC3YP_", null, 1, null, null, "Arturo_Gonzalez@corpfolder.com", "Arturo" },
                    { "Rosa_Delagarza425", null, "Delagarza", "ybnsXuvKH2", null, 1, null, null, "Rosa.Delagarza@nearbpo.com", "Rosa" },
                    { "Salvador.Menchaca426", null, "Menchaca", "SbyophJVjC", null, 1, null, null, "Salvador92@gmail.com", "Salvador" },
                    { "JoseAntonio_Gaona98411", null, "Gaona", "d6bqDn_1Zb", null, 1, null, null, "JoseAntonio_Gaona11@corpfolder.com", "José Antonio" },
                    { "Daniela_Ruelas35410", null, "Ruelas", "9UodLGOWJt", null, 1, null, null, "Daniela77@yahoo.com", "Daniela" },
                    { "Jazmin.Velez58409", null, "Vélez", "0YzK0Rnrk4", null, 1, null, null, "Jazmin66@corpfolder.com", "Jazmin" },
                    { "Marisol_Zambrano408", null, "Zambrano", "_ZSvjHtpzu", null, 1, null, null, "Marisol_Zambrano71@gmail.com", "Marisol" },
                    { "JorgeLuis.Casas392", null, "Casas", "GcoAFlRlgA", null, 1, null, null, "JorgeLuis47@gmail.com", "Jorge Luis" },
                    { "German.Urrutia74393", null, "Urrutia", "VT10OHYJqg", null, 1, null, null, "German11@yahoo.com", "Germán" },
                    { "Jeronimo89394", null, "Estévez", "y6a65Ldi6n", null, 1, null, null, "Jeronimo.Estevez@hotmail.com", "Jerónimo" },
                    { "Tadeo63395", null, "Kanea", "2wp8T6xmf2", null, 1, null, null, "Tadeo.Kanea@hotmail.com", "Tadeo" },
                    { "MariaGuadalupe.Olvera396", null, "Olvera", "ACHgyv6qSd", null, 1, null, null, "MariaGuadalupe.Olvera@yahoo.com", "María Guadalupe" },
                    { "David.Montenegro87397", null, "Montenegro", "2BIxcu_7AY", null, 1, null, null, "David_Montenegro80@corpfolder.com", "David" },
                    { "AnaLuisa.Serna398", null, "Serna", "zrsk7JTqQg", null, 1, null, null, "AnaLuisa_Serna@corpfolder.com", "Ana Luisa" },
                    { "Emilio_Magana40427", null, "Magaña", "Rgp4j5jRIv", null, 1, null, null, "Emilio30@hotmail.com", "Emilio" },
                    { "Agustin57399", null, "Olivares", "jNOb17M9Uu", null, 1, null, null, "Agustin37@nearbpo.com", "Agustín" },
                    { "LuisAngel91401", null, "Sandoval", "jWYSkqrVBA", null, 1, null, null, "LuisAngel.Sandoval@gmail.com", "Luis Ángel" },
                    { "Manuela0402", null, "Almaraz", "3hdrCLWtfT", null, 1, null, null, "Manuela56@yahoo.com", "Manuela" },
                    { "Vanessa14403", null, "Montoya", "LFgOYAhUJI", null, 1, null, null, "Vanessa.Montoya88@corpfolder.com", "Vanessa" },
                    { "MariaSoledad90404", null, "Campos", "ZGmWsYodUc", null, 1, null, null, "MariaSoledad_Campos@yahoo.com", "María Soledad" },
                    { "Mayte78405", null, "Haro", "Gg3ZTXpf9b", null, 1, null, null, "Mayte74@hotmail.com", "Mayte" },
                    { "Brayan.Lovato406", null, "Lovato", "Dhu2Ypw52A", null, 1, null, null, "Brayan_Lovato95@nearbpo.com", "Brayan" },
                    { "Irene65407", null, "Domínquez", "LnbNj0g6uL", null, 1, null, null, "Irene_Dominquez25@yahoo.com", "Irene" },
                    { "Esteban.Aparicio400", null, "Aparicio", "igKifpnDkO", null, 1, null, null, "Esteban37@gmail.com", "Esteban" },
                    { "Maximiliano_Caban391", null, "Cabán", "N3vEFmxUfH", null, 1, null, null, "Maximiliano99@yahoo.com", "Maximiliano" },
                    { "Concepcion.Yanez428", null, "Yáñez", "1Fr3bjyxoz", null, 1, null, null, "Concepcion13@nearbpo.com", "Concepción" },
                    { "Ramona_Becerra79430", null, "Becerra", "YNSlXQnBsc", null, 1, null, null, "Ramona52@gmail.com", "Ramona" },
                    { "Lilia_Leiva30451", null, "Leiva", "Nh2BAUGoyR", null, 1, null, null, "Lilia.Leiva3@nearbpo.com", "Lilia" },
                    { "Alfonso_Yanez452", null, "Yáñez", "syrkOqeBBE", null, 1, null, null, "Alfonso_Yanez@yahoo.com", "Alfonso" },
                    { "Luis.Gomez453", null, "Gómez", "esJAVOSK4N", null, 1, null, null, "Luis.Gomez@gmail.com", "Luis" },
                    { "Emily_Montero454", null, "Montero", "C_mHybc6eI", null, 1, null, null, "Emily57@gmail.com", "Emily" },
                    { "Kimberly86455", null, "Montemayor", "sO_Thj4Eak", null, 1, null, null, "Kimberly_Montemayor17@corpfolder.com", "Kimberly" },
                    { "Uriel_Cordova456", null, "Córdova", "0WXcCpkJI0", null, 1, null, null, "Uriel.Cordova61@gmail.com", "Uriel" },
                    { "Rosa_Nieves89457", null, "Nieves", "FTW22lCSUZ", null, 1, null, null, "Rosa78@nearbpo.com", "Rosa" },
                    { "Elsa.Gurule59458", null, "Gurule", "haBkslYn8v", null, 1, null, null, "Elsa25@nearbpo.com", "Elsa" },
                    { "Estela14459", null, "Ordóñez", "8VJ8QPnM07", null, 1, null, null, "Estela_Ordonez24@corpfolder.com", "Estela" },
                    { "Maricarmen93460", null, "Cortés", "hOIJB4A6c1", null, 1, null, null, "Maricarmen.Cortes99@hotmail.com", "Maricarmen" },
                    { "Vicente_Garay461", null, "Garay", "0nSsJJzRgK", null, 1, null, null, "Vicente.Garay68@hotmail.com", "Vicente" },
                    { "Ruben_Bahena462", null, "Bahena", "UWxj5tMyyz", null, 1, null, null, "Ruben6@hotmail.com", "Rubén" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Cristina_Koenig463", null, "Koenig", "5a6Gmm_AgW", null, 1, null, null, "Cristina79@gmail.com", "Cristina" },
                    { "Concepcion_Urbina93464", null, "Urbina", "5LXkQY_uTn", null, 1, null, null, "Concepcion.Urbina35@hotmail.com", "Concepción" },
                    { "FernandoJavier26465", null, "Rojas", "EbQcSh4g6g", null, 1, null, null, "FernandoJavier.Rojas89@hotmail.com", "Fernando Javier" },
                    { "Ximena.Lovato70450", null, "Lovato", "wW_dFlVBUm", null, 1, null, null, "Ximena85@corpfolder.com", "Ximena" },
                    { "Concepcion_Valdez53449", null, "Valdez", "xFfgKXSpRX", null, 1, null, null, "Concepcion_Valdez89@nearbpo.com", "Concepción" },
                    { "Adriana57448", null, "Ureña", "ced3NGe3tZ", null, 1, null, null, "Adriana_Urena@yahoo.com", "Adriana" },
                    { "Diego55447", null, "Vera", "zsP5GxsYAM", null, 1, null, null, "Diego_Vera@nearbpo.com", "Diego" },
                    { "Paulina.Jiminez431", null, "Jimínez", "x3YQvJ8HdT", null, 1, null, null, "Paulina.Jiminez88@nearbpo.com", "Paulina" },
                    { "LuisAngel57432", null, "Naranjo", "k_ETVMFDbk", null, 1, null, null, "LuisAngel51@yahoo.com", "Luis Ángel" },
                    { "Julia_Vergara51433", null, "Vergara", "K6d7r8Yb3u", null, 1, null, null, "Julia_Vergara@corpfolder.com", "Julia" },
                    { "Esperanza53434", null, "Miranda", "O8fKiiLETc", null, 1, null, null, "Esperanza.Miranda7@hotmail.com", "Esperanza" },
                    { "Ivan.Saiz89435", null, "Saiz", "y7j9zx9PM2", null, 1, null, null, "Ivan_Saiz@gmail.com", "Ivan" },
                    { "Rebeca.Manzanares436", null, "Manzanares", "WS9TCmbV7U", null, 1, null, null, "Rebeca_Manzanares@hotmail.com", "Rebeca" },
                    { "MariaElena.Haro14437", null, "Haro", "VYnPHDJsi_", null, 1, null, null, "MariaElena_Haro71@corpfolder.com", "María Elena" },
                    { "Monserrat_Acuna99429", null, "Acuña", "WPkx4eBBd0", null, 1, null, null, "Monserrat53@nearbpo.com", "Monserrat" },
                    { "Marcela.Xicoy438", null, "Xicoy", "bk9CuuEM5z", null, 1, null, null, "Marcela_Xicoy@yahoo.com", "Marcela" },
                    { "Mateo.Sanches78440", null, "Sanches", "MTMJfTncPQ", null, 1, null, null, "Mateo_Sanches@corpfolder.com", "Mateo" },
                    { "Dolores90441", null, "Llamas", "SqsWYQxbdK", null, 1, null, null, "Dolores_Llamas@hotmail.com", "Dolores" },
                    { "JoseEduardo2442", null, "Olvera", "0gPNhwx2UZ", null, 1, null, null, "JoseEduardo_Olvera30@gmail.com", "José Eduardo" },
                    { "Axel.Velasco443", null, "Velasco", "Rp1t0FQaHn", null, 1, null, null, "Axel_Velasco79@gmail.com", "Axel" },
                    { "Rodrigo51444", null, "Tapia", "kBsKp3cicP", null, 1, null, null, "Rodrigo_Tapia@corpfolder.com", "Rodrigo" },
                    { "Juana11445", null, "Valencia", "PGXiQjksHN", null, 1, null, null, "Juana68@gmail.com", "Juana" },
                    { "Lucas97446", null, "Kadar rodriguez", "UHgiFm67ai", null, 1, null, null, "Lucas_Kadarrodriguez@yahoo.com", "Lucas" },
                    { "Manuel.Tapia439", null, "Tapia", "QiCL3u19qD", null, 1, null, null, "Manuel.Tapia27@hotmail.com", "Manuel" },
                    { "Irene26466", null, "Madrid", "VcSmnepkoT", null, 1, null, null, "Irene.Madrid22@corpfolder.com", "Irene" },
                    { "Gloria_Xiana47390", null, "Xiana", "Yucw4ewPOn", null, 1, null, null, "Gloria6@yahoo.com", "Gloria" },
                    { "Magdalena97388", null, "Lerma", "jsjd0IQKVl", null, 1, null, null, "Magdalena.Lerma@nearbpo.com", "Magdalena" },
                    { "LuisAngel99334", null, "Verdugo", "TpVp6_8a9f", null, 1, null, null, "LuisAngel_Verdugo50@nearbpo.com", "Luis Ángel" },
                    { "Martin29335", null, "Muñiz", "jloGWv5Iak", null, 1, null, null, "Martin_Muniz@hotmail.com", "Martín" },
                    { "Olivia_Escobedo50336", null, "Escobedo", "ki2sFjoQKg", null, 1, null, null, "Olivia_Escobedo81@hotmail.com", "Olivia" },
                    { "Natalia_Corona65337", null, "Corona", "7VzVftBTj4", null, 1, null, null, "Natalia2@nearbpo.com", "Natalia" },
                    { "Israel26338", null, "Cardona", "dSmh5hRL7a", null, 1, null, null, "Israel.Cardona@gmail.com", "Israel" },
                    { "Evelyn_Blanco9339", null, "Blanco", "KMRMOvFZpf", null, 1, null, null, "Evelyn74@gmail.com", "Evelyn" },
                    { "Paola37340", null, "Kanea", "jOvOBxuR7E", null, 1, null, null, "Paola32@nearbpo.com", "Paola" },
                    { "Xochitl74341", null, "Gallegos", "KBeLxjgG7O", null, 1, null, null, "Xochitl_Gallegos87@hotmail.com", "Xochitl" },
                    { "Gabriela55342", null, "Ibarra", "3FVWrvhXZ6", null, 1, null, null, "Gabriela_Ibarra37@gmail.com", "Gabriela" },
                    { "Martin_Karem89343", null, "Karem", "KtxboS1j38", null, 1, null, null, "Martin_Karem@gmail.com", "Martín" },
                    { "JoseDaniel88344", null, "Xiana", "Iv0c6vLHsQ", null, 1, null, null, "JoseDaniel6@gmail.com", "Jose Daniel" },
                    { "Elisa.Chavarria345", null, "Chavarría", "2eZyFOIeNP", null, 1, null, null, "Elisa8@hotmail.com", "Elisa" },
                    { "Reina_Paz346", null, "Paz", "uyNdNke6rg", null, 1, null, null, "Reina_Paz@yahoo.com", "Reina" },
                    { "RosaMaria_Leiva347", null, "Leiva", "zwuJQf76tv", null, 1, null, null, "RosaMaria35@corpfolder.com", "Rosa María" },
                    { "Maricarmen_Aguilar348", null, "Águilar", "YL_s3rAQlw", null, 1, null, null, "Maricarmen_Aguilar@yahoo.com", "Maricarmen" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "JoseEmilio.Burgos333", null, "Burgos", "yAZFMYBFuK", null, 1, null, null, "JoseEmilio_Burgos90@hotmail.com", "José Emilio" },
                    { "Fernando.Arenas332", null, "Arenas", "mHy7MwrPaE", null, 1, null, null, "Fernando45@corpfolder.com", "Fernando" },
                    { "Emmanuel89331", null, "Jáquez", "wop3U19rmQ", null, 1, null, null, "Emmanuel.Jaquez52@yahoo.com", "Emmanuel" },
                    { "Berta_Barrientos77330", null, "Barrientos", "RYAcDOVedK", null, 1, null, null, "Berta_Barrientos@yahoo.com", "Berta" },
                    { "Camila_Delacruz314", null, "Delacrúz", "oFBnitWJ6Y", null, 1, null, null, "Camila.Delacruz@hotmail.com", "Camila" },
                    { "MariaElena_Aleman95315", null, "Alemán", "laqAZ53rUk", null, 1, null, null, "MariaElena88@corpfolder.com", "María Elena" },
                    { "Melissa57316", null, "Muñiz", "R_9SPenPuP", null, 1, null, null, "Melissa10@nearbpo.com", "Melissa" },
                    { "Yamileth.Palomo27317", null, "Palomo", "WpLunBInbW", null, 1, null, null, "Yamileth_Palomo40@hotmail.com", "Yamileth" },
                    { "Alexander.Moya98318", null, "Moya", "DPl9fU0avD", null, 1, null, null, "Alexander_Moya@corpfolder.com", "Alexander" },
                    { "Matias.Armijo64319", null, "Armijo", "VnFtFTfu9Q", null, 1, null, null, "Matias.Armijo@yahoo.com", "Matías" },
                    { "Victor.Guerrero5320", null, "Guerrero", "At8E7VendY", null, 1, null, null, "Victor28@corpfolder.com", "Víctor" },
                    { "Luisa_Najera349", null, "Nájera", "eff0koWdSf", null, 1, null, null, "Luisa_Najera73@corpfolder.com", "Luisa" },
                    { "RosaMaria36321", null, "Ordóñez", "mz8LPckwbw", null, 1, null, null, "RosaMaria.Ordonez34@hotmail.com", "Rosa María" },
                    { "Eva_Acevedo77323", null, "Acevedo", "lNIz5vW4s0", null, 1, null, null, "Eva_Acevedo@nearbpo.com", "Eva" },
                    { "Iker.Posada32324", null, "Posada", "07Td0UXwZO", null, 1, null, null, "Iker.Posada92@hotmail.com", "Iker" },
                    { "Julieta67325", null, "Madrid", "kD5NYEmJ5L", null, 1, null, null, "Julieta_Madrid@nearbpo.com", "Julieta" },
                    { "Elisa8326", null, "Tijerina", "4ApTcjBtiC", null, 1, null, null, "Elisa_Tijerina@corpfolder.com", "Elisa" },
                    { "Hugo.Betancourt5327", null, "Bétancourt", "iMoTYHtTea", null, 1, null, null, "Hugo_Betancourt56@gmail.com", "Hugo" },
                    { "Carla_Olvera45328", null, "Olvera", "Qo5Pjv1P0x", null, 1, null, null, "Carla_Olvera@gmail.com", "Carla" },
                    { "Claudia.Espinal64329", null, "Espinal", "G2xp_DK_sC", null, 1, null, null, "Claudia93@gmail.com", "Claudia" },
                    { "Anita43322", null, "Romo", "Go_fZgmJCi", null, 1, null, null, "Anita_Romo38@hotmail.com", "Anita" },
                    { "Santiago_Osorio27389", null, "Osorio", "r4Y0A5KxJr", null, 1, null, null, "Santiago_Osorio26@corpfolder.com", "Santiago" },
                    { "Elvira1350", null, "Estévez", "sud5MhLg2f", null, 1, null, null, "Elvira4@nearbpo.com", "Elvira" },
                    { "Sonia_Alaniz94352", null, "Alaniz", "H7kzLpGi9f", null, 1, null, null, "Sonia7@corpfolder.com", "Sonia" },
                    { "Elisa23373", null, "Sarabia", "wN7HVkY2py", null, 1, null, null, "Elisa10@yahoo.com", "Elisa" },
                    { "MariadelosAngeles.Anguiano25374", null, "Anguiano", "Bj83E92zow", null, 1, null, null, "MariadelosAngeles.Anguiano@yahoo.com", "María de los Ángeles" },
                    { "Anita21375", null, "Toro", "tI1Xq822LX", null, 1, null, null, "Anita_Toro55@yahoo.com", "Anita" },
                    { "Iker_Velez376", null, "Vélez", "hE1rVlc7vY", null, 1, null, null, "Iker.Velez83@nearbpo.com", "Iker" },
                    { "Salvador_Huixtlacatl377", null, "Huixtlacatl", "YwhZpW7ch7", null, 1, null, null, "Salvador88@gmail.com", "Salvador" },
                    { "Esmeralda.Guardado38378", null, "Guardado", "kQXc41bLMG", null, 1, null, null, "Esmeralda.Guardado48@nearbpo.com", "Esmeralda" },
                    { "JoseDaniel.Velez12379", null, "Vélez", "pf_E8Aq93X", null, 1, null, null, "JoseDaniel89@gmail.com", "Jose Daniel" },
                    { "Juana_Acosta97380", null, "Acosta", "iuMyqW4lvx", null, 1, null, null, "Juana.Acosta12@nearbpo.com", "Juana" },
                    { "Lola_Saucedo11381", null, "Saucedo", "ERA19gSYSZ", null, 1, null, null, "Lola63@nearbpo.com", "Lola" },
                    { "Mauricio.Mascarenas382", null, "Mascareñas", "FcQNDCyW_T", null, 1, null, null, "Mauricio.Mascarenas@nearbpo.com", "Mauricio" },
                    { "AnaSofia.Escobar383", null, "Escobar", "3VcZJJsppL", null, 1, null, null, "AnaSofia_Escobar@yahoo.com", "Ana Sofía" },
                    { "FranciscoJavier5384", null, "Hidalgo", "WnYwVC_nlQ", null, 1, null, null, "FranciscoJavier72@nearbpo.com", "Francisco Javier" },
                    { "Esmeralda.Gallardo75385", null, "Gallardo", "7nCqzpVsSR", null, 1, null, null, "Esmeralda_Gallardo55@gmail.com", "Esmeralda" },
                    { "MariaElena.Rael386", null, "Rael", "AAsBc0NsPW", null, 1, null, null, "MariaElena55@gmail.com", "María Elena" },
                    { "MiguelAngel27387", null, "Atencio", "4Sx5WkFBZC", null, 1, null, null, "MiguelAngel_Atencio86@yahoo.com", "Miguel Ángel" },
                    { "Paulina.Lira372", null, "Lira", "S6ClNn1qsn", null, 1, null, null, "Paulina.Lira@nearbpo.com", "Paulina" },
                    { "Salvador.Escamilla26371", null, "Escamilla", "UVzHMcK9Yo", null, 1, null, null, "Salvador_Escamilla@yahoo.com", "Salvador" },
                    { "JoseMiguel_Arroyo370", null, "Arroyo", "_fw1DgHFhV", null, 1, null, null, "JoseMiguel.Arroyo@gmail.com", "José Miguel" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Francisca.Casillas369", null, "Casillas", "DBW3QTNDut", null, 1, null, null, "Francisca89@yahoo.com", "Francisca" },
                    { "Virginia_Benavidez30353", null, "Benavídez", "JJPnvs8TzT", null, 1, null, null, "Virginia26@yahoo.com", "Virginia" },
                    { "Amalia.Sanches354", null, "Sanches", "h1yYcq7ewl", null, 1, null, null, "Amalia4@corpfolder.com", "Amalia" },
                    { "Martin_Karan355", null, "Karan", "ckgtiCNmKr", null, 1, null, null, "Martin9@hotmail.com", "Martín" },
                    { "Kevin57356", null, "Perales", "EItXy9gCn5", null, 1, null, null, "Kevin77@yahoo.com", "Kevin" },
                    { "JoseLuis.Casas38357", null, "Casas", "QgogXjrHdh", null, 1, null, null, "JoseLuis_Casas72@gmail.com", "José Luis" },
                    { "Luisa.Paez81358", null, "Páez", "3f1_AsEOso", null, 1, null, null, "Luisa_Paez@corpfolder.com", "Luisa" },
                    { "Matias_Ybarra359", null, "Ybarra", "PPP61BqGpF", null, 1, null, null, "Matias.Ybarra@gmail.com", "Matías" },
                    { "Esmeralda50351", null, "Vargas", "ik9ix4ZmaK", null, 1, null, null, "Esmeralda2@gmail.com", "Esmeralda" },
                    { "Patricio.Kanaria360", null, "Kanaria", "lhBLtX6Far", null, 1, null, null, "Patricio.Kanaria71@hotmail.com", "Patricio" },
                    { "MariaJose.Chacon362", null, "Chacón", "Vi6zUSQoY0", null, 1, null, null, "MariaJose.Chacon@hotmail.com", "María José" },
                    { "Carolina_Kindelan86363", null, "Kindelan", "Fy4CU2MLuC", null, 1, null, null, "Carolina.Kindelan82@gmail.com", "Carolina" },
                    { "Lucia84364", null, "Guzmán", "phXYznwZOw", null, 1, null, null, "Lucia60@hotmail.com", "Lucia" },
                    { "Lucas.Rojas92365", null, "Rojas", "XgSUZlJCYv", null, 1, null, null, "Lucas_Rojas42@nearbpo.com", "Lucas" },
                    { "Manuela.Contreras366", null, "Contreras", "jhOsC3vjVZ", null, 1, null, null, "Manuela.Contreras@gmail.com", "Manuela" },
                    { "Yaretzi31367", null, "Huixtlacatl", "4qljgm5a6Y", null, 1, null, null, "Yaretzi93@corpfolder.com", "Yaretzi" },
                    { "Carolina_Guerrero79368", null, "Guerrero", "E_CMeJrXVq", null, 1, null, null, "Carolina_Guerrero@nearbpo.com", "Carolina" },
                    { "Melany20361", null, "Mojica", "pMkcLmuD8i", null, 1, null, null, "Melany_Mojica4@corpfolder.com", "Melany" },
                    { "FernandoJavier84313", null, "Ramos", "xsuHyKi83u", null, 1, null, null, "FernandoJavier42@yahoo.com", "Fernando Javier" },
                    { "FranciscoJavier_Batista4467", null, "Batista", "2GcuaS1Y2_", null, 1, null, null, "FranciscoJavier.Batista@yahoo.com", "Francisco Javier" },
                    { "Israel.Barraza469", null, "Barraza", "kRY8UMBZBV", null, 1, null, null, "Israel87@corpfolder.com", "Israel" },
                    { "Diego_Rocha17568", null, "Rocha", "BkUW1j81HR", null, 1, null, null, "Diego_Rocha9@gmail.com", "Diego" },
                    { "Melany_Caraballo8569", null, "Caraballo", "iW6lv2u3rT", null, 1, null, null, "Melany_Caraballo@corpfolder.com", "Melany" },
                    { "Teresa_Resendez95570", null, "Reséndez", "5oa0ONRlDg", null, 1, null, null, "Teresa.Resendez88@yahoo.com", "Teresa" },
                    { "Guillermina21571", null, "Rodríquez", "hEuuuVW4By", null, 1, null, null, "Guillermina.Rodriquez42@yahoo.com", "Guillermina" },
                    { "Raquel.Montenegro572", null, "Montenegro", "KH6fWUTfvi", null, 1, null, null, "Raquel.Montenegro81@gmail.com", "Raquel" },
                    { "Reina.Aguilera64573", null, "Aguilera", "wkM3ETGSjI", null, 1, null, null, "Reina87@gmail.com", "Reina" },
                    { "Fernando45574", null, "Galván", "M_bli2EOKg", null, 1, null, null, "Fernando64@corpfolder.com", "Fernando" },
                    { "JoseLuis94575", null, "Meléndez", "UpnKa9EYGd", null, 1, null, null, "JoseLuis70@gmail.com", "José Luis" },
                    { "JoseAntonio44576", null, "Villegas", "48YDAmSFm4", null, 1, null, null, "JoseAntonio_Villegas@hotmail.com", "José Antonio" },
                    { "AngelDaniel50577", null, "Carranza", "TBm5wnQQNN", null, 1, null, null, "AngelDaniel85@gmail.com", "Ángel Daniel" },
                    { "Alberto91578", null, "Kano", "DdT5LFLcwL", null, 1, null, null, "Alberto78@hotmail.com", "Alberto" },
                    { "Abraham65579", null, "Nieto", "FHcsdSs33S", null, 1, null, null, "Abraham.Nieto21@hotmail.com", "Abraham" },
                    { "Elena57580", null, "Mendoza", "ch3aXNsbje", null, 1, null, null, "Elena.Mendoza@corpfolder.com", "Elena" },
                    { "Javier37581", null, "Guajardo", "Pw7WPwDuKJ", null, 1, null, null, "Javier67@corpfolder.com", "Javier" },
                    { "Mariana25582", null, "Solís", "466_KMP04V", null, 1, null, null, "Mariana_Solis@gmail.com", "Mariana" },
                    { "JoseMaria.Naranjo567", null, "Naranjo", "a3evSAOeq9", null, 1, null, null, "JoseMaria56@nearbpo.com", "José María" },
                    { "Jesus.Gaytan40566", null, "Gaytán", "Wf_qdJcE43", null, 1, null, null, "Jesus.Gaytan25@corpfolder.com", "Jesús" },
                    { "Cristobal_Yanez565", null, "Yáñez", "WYtzdns3rt", null, 1, null, null, "Cristobal_Yanez@hotmail.com", "Cristobal" },
                    { "Carlos_XairoBelmonte564", null, "Xairo Belmonte", "0eNuZCPshT", null, 1, null, null, "Carlos.XairoBelmonte@yahoo.com", "Carlos" },
                    { "AnaMaria45548", null, "Zambrano", "wKkqubL3px", null, 1, null, null, "AnaMaria.Zambrano53@gmail.com", "Ana María" },
                    { "Luis_Nieto99549", null, "Nieto", "lKAZj6OMUs", null, 1, null, null, "Luis7@hotmail.com", "Luis" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "MariadelCarmen.Chacon550", null, "Chacón", "jtBQn8Dvrr", null, 1, null, null, "MariadelCarmen.Chacon@yahoo.com", "María del Carmen" },
                    { "Cesar.Ortega551", null, "Ortega", "gcfJaeGw07", null, 1, null, null, "Cesar61@yahoo.com", "César" },
                    { "JoseDaniel.Covarrubias57552", null, "Covarrubias", "wrj14uW6my", null, 1, null, null, "JoseDaniel84@hotmail.com", "Jose Daniel" },
                    { "Sara13553", null, "Garica", "qBSGfVmlPQ", null, 1, null, null, "Sara.Garica43@nearbpo.com", "Sara" },
                    { "Barbara53554", null, "Hurtado", "0sg0ocL1LA", null, 1, null, null, "Barbara44@hotmail.com", "Barbara" },
                    { "Enrique.Leon45583", null, "León", "IxTefEj8kN", null, 1, null, null, "Enrique_Leon21@gmail.com", "Enrique" },
                    { "JuanManuel.Ferrer45555", null, "Ferrer", "78kp_8drG2", null, 1, null, null, "JuanManuel_Ferrer@hotmail.com", "Juan Manuel" },
                    { "Claudio.Tovar16557", null, "Tovar", "YuYomWyEMz", null, 1, null, null, "Claudio47@gmail.com", "Claudio" },
                    { "Isaias86558", null, "Espinosa", "NvZfNt45Wr", null, 1, null, null, "Isaias.Espinosa27@hotmail.com", "Isaias" },
                    { "MariaElena_Jaimes559", null, "Jaimes", "v9_4rufu_W", null, 1, null, null, "MariaElena10@gmail.com", "María Elena" },
                    { "Evelyn90560", null, "Yáñez", "7CoILJl0Wy", null, 1, null, null, "Evelyn_Yanez@yahoo.com", "Evelyn" },
                    { "Carmen_Ojeda47561", null, "Ojeda", "vmJIfjmAuC", null, 1, null, null, "Carmen_Ojeda78@gmail.com", "Carmen" },
                    { "Javier.Lara9562", null, "Lara", "Y8_XyBicCT", null, 1, null, null, "Javier.Lara@gmail.com", "Javier" },
                    { "Ramon_Cardona63563", null, "Cardona", "Q1pKUGhLP5", null, 1, null, null, "Ramon39@nearbpo.com", "Ramón" },
                    { "Jose_Grijalva556", null, "Grijalva", "nQ1dGzRV2v", null, 1, null, null, "Jose.Grijalva@corpfolder.com", "José" },
                    { "MariaTeresa93547", null, "Tovar", "TY3CMD3MmB", null, 1, null, null, "MariaTeresa.Tovar21@yahoo.com", "María Teresa" },
                    { "AngelDaniel38584", null, "Villalpando", "dXkLR825On", null, 1, null, null, "AngelDaniel17@yahoo.com", "Ángel Daniel" },
                    { "Ignacio69586", null, "Quintero de la cruz", "4zFIohWual", null, 1, null, null, "Ignacio29@gmail.com", "Ignacio" },
                    { "Juana_Segovia607", null, "Segovia", "Wa8D7JrlKW", null, 1, null, null, "Juana74@hotmail.com", "Juana" },
                    { "Ramona.Esquivel47608", null, "Esquivel", "w4BltumsF7", null, 1, null, null, "Ramona_Esquivel@corpfolder.com", "Ramona" },
                    { "Horacio_Bernal609", null, "Bernal", "poqQZx3i2B", null, 1, null, null, "Horacio.Bernal@gmail.com", "Horacio" },
                    { "Alfredo_Griego52610", null, "Griego", "l13d79lahO", null, 1, null, null, "Alfredo63@corpfolder.com", "Alfredo" },
                    { "Abraham28611", null, "Godínez", "c_Ctvi3nG6", null, 1, null, null, "Abraham86@corpfolder.com", "Abraham" },
                    { "Ana65612", null, "Guerrero", "iaB_Huxl6y", null, 1, null, null, "Ana89@nearbpo.com", "Ana" },
                    { "Andres_Karen613", null, "Karen", "ZWTQFZt4GR", null, 1, null, null, "Andres.Karen@yahoo.com", "Andrés" },
                    { "Luisa.Zayas18614", null, "Zayas", "oOze3vSM_f", null, 1, null, null, "Luisa_Zayas@yahoo.com", "Luisa" },
                    { "Mauricio.Meraz4615", null, "Meraz", "jQPhEiGfPA", null, 1, null, null, "Mauricio_Meraz52@corpfolder.com", "Mauricio" },
                    { "David2616", null, "Lozada", "1B4VxDxH5J", null, 1, null, null, "David_Lozada@hotmail.com", "David" },
                    { "Blanca.Robles0617", null, "Robles", "rbZbJhxSp9", null, 1, null, null, "Blanca_Robles82@hotmail.com", "Blanca" },
                    { "Rodrigo9618", null, "Godínez", "tVwAS7O9Ys", null, 1, null, null, "Rodrigo68@yahoo.com", "Rodrigo" },
                    { "Jazmin23619", null, "Vélez", "l7BwuyiNGf", null, 1, null, null, "Jazmin_Velez@yahoo.com", "Jazmin" },
                    { "Cesar_Esquivel9620", null, "Esquivel", "D04qfyh3A3", null, 1, null, null, "Cesar31@hotmail.com", "César" },
                    { "Antonia_Barrios79621", null, "Barrios", "onO9K4Mbke", null, 1, null, null, "Antonia.Barrios@corpfolder.com", "Antonia" },
                    { "Rocio39606", null, "Casillas", "BRNN2zQMRG", null, 1, null, null, "Rocio_Casillas98@yahoo.com", "Rocio" },
                    { "Emily_Zamudio30605", null, "Zamudio", "V_DxfrWPfN", null, 1, null, null, "Emily26@nearbpo.com", "Emily" },
                    { "Santiago_Lerma604", null, "Lerma", "lnjOrNQiTo", null, 1, null, null, "Santiago.Lerma79@nearbpo.com", "Santiago" },
                    { "VictorManuel_Posada603", null, "Posada", "UMWbtmpEu2", null, 1, null, null, "VictorManuel37@hotmail.com", "Victor Manuel" },
                    { "Pedro.Roque7587", null, "Roque", "cyiA9J09qF", null, 1, null, null, "Pedro.Roque@yahoo.com", "Pedro" },
                    { "Aaron.Mondragon34588", null, "Mondragón", "wJ36fM8CWE", null, 1, null, null, "Aaron_Mondragon33@hotmail.com", "Aarón" },
                    { "Tomas98589", null, "Navarrete", "VupIKVNQWO", null, 1, null, null, "Tomas_Navarrete@nearbpo.com", "Tomás" },
                    { "MariaCristina_Ocampo590", null, "Ocampo", "xj8J8zN7ou", null, 1, null, null, "MariaCristina_Ocampo57@yahoo.com", "María Cristina" },
                    { "Diego_Alvarado77591", null, "Alvarado", "n4TH1s5ML9", null, 1, null, null, "Diego41@yahoo.com", "Diego" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Ines37592", null, "Acevedo", "rC6nTanaE5", null, 1, null, null, "Ines.Acevedo@hotmail.com", "Inés" },
                    { "Regina88593", null, "Pabón", "efpjJHLAR2", null, 1, null, null, "Regina.Pabon@hotmail.com", "Regina" },
                    { "Yaretzi.Sanabria47585", null, "Sanabria", "_mhg3k4TO9", null, 1, null, null, "Yaretzi_Sanabria64@hotmail.com", "Yaretzi" },
                    { "Lucas94594", null, "Delrío", "mFuYMNhYcD", null, 1, null, null, "Lucas65@corpfolder.com", "Lucas" },
                    { "Pilar_Saenz596", null, "Sáenz", "TXuEaXNXvc", null, 1, null, null, "Pilar_Saenz@yahoo.com", "Pilar" },
                    { "Esperanza68597", null, "Gracia", "n_ZG0g9hBw", null, 1, null, null, "Esperanza17@gmail.com", "Esperanza" },
                    { "Emmanuel.Jaimes20598", null, "Jaimes", "7o0T0NQ1Hr", null, 1, null, null, "Emmanuel90@gmail.com", "Emmanuel" },
                    { "JuanCarlos_Galvez92599", null, "Gálvez", "tjWtV2Jx6o", null, 1, null, null, "JuanCarlos_Galvez22@yahoo.com", "Juan Carlos" },
                    { "Ana_Lovato600", null, "Lovato", "wXQINbP88B", null, 1, null, null, "Ana56@nearbpo.com", "Ana" },
                    { "Salvador_Armendariz4601", null, "Armendáriz", "GvlS6tQtnC", null, 1, null, null, "Salvador.Armendariz47@hotmail.com", "Salvador" },
                    { "Lourdes57602", null, "Villalobos", "3TG8f0atrl", null, 1, null, null, "Lourdes_Villalobos21@hotmail.com", "Lourdes" },
                    { "Silvia_deAnda6595", null, "de Anda", "CPksSHmhF5", null, 1, null, null, "Silvia.deAnda68@gmail.com", "Silvia" },
                    { "Federico.Kanimal73468", null, "Kanimal", "FbSA7M_DYH", null, 1, null, null, "Federico.Kanimal42@yahoo.com", "Federico" },
                    { "Marta_Lemus53546", null, "Lemus", "vKcNlpNa2x", null, 1, null, null, "Marta66@yahoo.com", "Marta" },
                    { "Norma.Mojica544", null, "Mojica", "3XRjcRpSrF", null, 1, null, null, "Norma30@nearbpo.com", "Norma" },
                    { "AnaSofia4490", null, "Anguiano", "L06ZPpdQBM", null, 1, null, null, "AnaSofia41@corpfolder.com", "Ana Sofía" },
                    { "Irene50491", null, "Quintanilla", "IMzWo9HydZ", null, 1, null, null, "Irene_Quintanilla24@gmail.com", "Irene" },
                    { "Javier.Yanes492", null, "Yanes", "I6F5fTz6y6", null, 1, null, null, "Javier.Yanes29@corpfolder.com", "Javier" },
                    { "Yamileth.Chacon493", null, "Chacón", "DHqwuREWfO", null, 1, null, null, "Yamileth.Chacon39@yahoo.com", "Yamileth" },
                    { "Antonio72494", null, "Briones", "vsDbDD6gOs", null, 1, null, null, "Antonio.Briones@corpfolder.com", "Antonio" },
                    { "Francisca80495", null, "Urrutia", "pTSNJzOesz", null, 1, null, null, "Francisca.Urrutia@corpfolder.com", "Francisca" },
                    { "Cristina_Agosto496", null, "Agosto", "jDU6I7vzwq", null, 1, null, null, "Cristina_Agosto@gmail.com", "Cristina" },
                    { "Sofia23497", null, "Leal", "73wt_zF260", null, 1, null, null, "Sofia29@gmail.com", "Sofia" },
                    { "Valeria_Covarrubias85498", null, "Covarrubias", "xDub1vQyHJ", null, 1, null, null, "Valeria_Covarrubias@corpfolder.com", "Valeria" },
                    { "Nicolas42499", null, "Mata", "oJPrZNzG8H", null, 1, null, null, "Nicolas.Mata35@gmail.com", "Nicolás" },
                    { "Mario.Pagan500", null, "Pagan", "bhTcRncT4M", null, 1, null, null, "Mario36@corpfolder.com", "Mario" },
                    { "Ariadna.Ocampo92501", null, "Ocampo", "RGUQrL44Ue", null, 1, null, null, "Ariadna8@corpfolder.com", "Ariadna" },
                    { "Ana90502", null, "Meraz", "jwdwJzA1Bx", null, 1, null, null, "Ana_Meraz29@hotmail.com", "Ana" },
                    { "Reina.Serrato503", null, "Serrato", "pKKJ0zMn5D", null, 1, null, null, "Reina.Serrato@gmail.com", "Reina" },
                    { "David.Esquivel93504", null, "Esquivel", "4TZ7XerKo4", null, 1, null, null, "David_Esquivel48@yahoo.com", "David" },
                    { "Camila.Cintron489", null, "Cintrón", "mbtPL8tzYz", null, 1, null, null, "Camila76@yahoo.com", "Camila" },
                    { "Emmanuel_Ulibarri4488", null, "Ulibarri", "bhnyHOJHUf", null, 1, null, null, "Emmanuel32@corpfolder.com", "Emmanuel" },
                    { "Adela29487", null, "Melgar", "eKlbbyMsaE", null, 1, null, null, "Adela64@yahoo.com", "Adela" },
                    { "Salvador_Mayorga35486", null, "Mayorga", "2a251PRGWt", null, 1, null, null, "Salvador52@nearbpo.com", "Salvador" },
                    { "Teresa_Esparza470", null, "Esparza", "QxK01Qe0QA", null, 1, null, null, "Teresa_Esparza82@nearbpo.com", "Teresa" },
                    { "Brayan.Altamirano14471", null, "Altamirano", "lUgXxJ7iig", null, 1, null, null, "Brayan95@yahoo.com", "Brayan" },
                    { "MarcoAntonio.Velazquez472", null, "Velázquez", "sNpy4h8gSa", null, 1, null, null, "MarcoAntonio12@gmail.com", "Marco Antonio" },
                    { "Leonor.Tello87473", null, "Tello", "NNWcgoxvK_", null, 1, null, null, "Leonor.Tello25@gmail.com", "Leonor" },
                    { "Manuela.Yanes474", null, "Yanes", "8pEGAYJT5H", null, 1, null, null, "Manuela.Yanes96@gmail.com", "Manuela" },
                    { "Elizabeth78475", null, "Páez", "qWDPP5_fbd", null, 1, null, null, "Elizabeth.Paez31@yahoo.com", "Elizabeth" },
                    { "Alexa79476", null, "Altamirano", "nobfhJr8_w", null, 1, null, null, "Alexa_Altamirano@hotmail.com", "Alexa" },
                    { "AnaSofia_Calvillo83505", null, "Calvillo", "effBovbesA", null, 1, null, null, "AnaSofia_Calvillo41@hotmail.com", "Ana Sofía" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Melissa65477", null, "Cedillo", "0lPTRP67GC", null, 1, null, null, "Melissa.Cedillo38@corpfolder.com", "Melissa" },
                    { "LuisMiguel58479", null, "Hernádez", "_SK2lSnZdb", null, 1, null, null, "LuisMiguel_Hernadez1@yahoo.com", "Luis Miguel" },
                    { "MariadelosAngeles_Olivares10480", null, "Olivares", "ASjo0x8L1R", null, 1, null, null, "MariadelosAngeles.Olivares73@nearbpo.com", "María de los Ángeles" },
                    { "Ignacio69481", null, "Macías", "PzQRFWlmo_", null, 1, null, null, "Ignacio_Macias@hotmail.com", "Ignacio" },
                    { "Lilia_Montanez78482", null, "Montañez", "hJRwbVbypR", null, 1, null, null, "Lilia66@corpfolder.com", "Lilia" },
                    { "Emilia_Alcala51483", null, "Alcala", "AKlHPKo7bA", null, 1, null, null, "Emilia_Alcala@nearbpo.com", "Emilia" },
                    { "MariaFernanda79484", null, "Verduzco", "HsSw9UeGP8", null, 1, null, null, "MariaFernanda_Verduzco33@hotmail.com", "María Fernanda" },
                    { "David24485", null, "Hurtado", "NX0d8PAilI", null, 1, null, null, "David.Hurtado@nearbpo.com", "David" },
                    { "Angela_Alanis478", null, "Alanis", "ilYlwotfq_", null, 1, null, null, "Angela.Alanis@nearbpo.com", "Ángela" },
                    { "Alexander52545", null, "Chapa", "ToKFIDQpnb", null, 1, null, null, "Alexander.Chapa30@corpfolder.com", "Alexander" },
                    { "Brandon.Alfaro506", null, "Alfaro", "Z9Wjh0F1Uc", null, 1, null, null, "Brandon63@gmail.com", "Brandon" },
                    { "Valentina_Velasquez508", null, "Velásquez", "n2zYbFZA4w", null, 1, null, null, "Valentina50@gmail.com", "Valentina" },
                    { "Sergio.Orta529", null, "Orta", "NR8W5bLrhG", null, 1, null, null, "Sergio10@gmail.com", "Sergio" },
                    { "Lucia.Barrera12530", null, "Barrera", "EXMl7W6aPn", null, 1, null, null, "Lucia.Barrera38@hotmail.com", "Lucia" },
                    { "Emilia25531", null, "Arroyo", "CtIYBYbk3n", null, 1, null, null, "Emilia_Arroyo@corpfolder.com", "Emilia" },
                    { "MariadeJesus55532", null, "Munguía", "dGJ0xSRd3I", null, 1, null, null, "MariadeJesus73@nearbpo.com", "María de Jesús" },
                    { "Veronica.Puga4533", null, "Puga", "rJ0A6RJ54w", null, 1, null, null, "Veronica98@nearbpo.com", "Verónica" },
                    { "Gabriel.Xiana534", null, "Xiana", "o8XhqPsgi9", null, 1, null, null, "Gabriel6@gmail.com", "Gabriel" },
                    { "Santiago_Delao57535", null, "Delao", "5wThbiw2VS", null, 1, null, null, "Santiago81@yahoo.com", "Santiago" },
                    { "FranciscoJavier.Gil536", null, "Gil", "LtS0FXhIaZ", null, 1, null, null, "FranciscoJavier.Gil@gmail.com", "Francisco Javier" },
                    { "Clara.Aranda537", null, "Aranda", "nfFao4xlph", null, 1, null, null, "Clara.Aranda91@hotmail.com", "Clara" },
                    { "Olivia52538", null, "Otero", "Egvj9HFmM2", null, 1, null, null, "Olivia.Otero@yahoo.com", "Olivia" },
                    { "Pedro_Saucedo539", null, "Saucedo", "ksuBkT_ee3", null, 1, null, null, "Pedro_Saucedo28@corpfolder.com", "Pedro" },
                    { "Carolina12540", null, "Saldivar", "FfN5mFsv7s", null, 1, null, null, "Carolina.Saldivar4@yahoo.com", "Carolina" },
                    { "Paulina.Aranda541", null, "Aranda", "1JkvkqEUX4", null, 1, null, null, "Paulina.Aranda7@nearbpo.com", "Paulina" },
                    { "Elsa91542", null, "Robles", "UARyvK0UuY", null, 1, null, null, "Elsa32@gmail.com", "Elsa" },
                    { "Alejandro.Sepulveda62543", null, "Sepúlveda", "_StxMLMOXY", null, 1, null, null, "Alejandro47@hotmail.com", "Alejandro" },
                    { "Joaquin59528", null, "Montes", "d462BRsVR8", null, 1, null, null, "Joaquin_Montes@gmail.com", "Joaquín" },
                    { "MariaFernanda5527", null, "Cruz", "TrXpiBuTFn", null, 1, null, null, "MariaFernanda61@hotmail.com", "María Fernanda" },
                    { "Leticia.Bustos526", null, "Bustos", "gOjztWLrMW", null, 1, null, null, "Leticia_Bustos48@yahoo.com", "Leticia" },
                    { "Esteban.Arteaga525", null, "Arteaga", "RjpfBM_nH3", null, 1, null, null, "Esteban.Arteaga@nearbpo.com", "Esteban" },
                    { "Micaela_Solorio5509", null, "Solorio", "9h9aCFM4Yb", null, 1, null, null, "Micaela.Solorio@hotmail.com", "Micaela" },
                    { "Roberto.Padilla510", null, "Padilla", "wcm30bNw2S", null, 1, null, null, "Roberto.Padilla0@gmail.com", "Roberto" },
                    { "LuisGabino60511", null, "Alva", "T70NEwT2H8", null, 1, null, null, "LuisGabino_Alva@corpfolder.com", "Luis Gabino" },
                    { "Damian_Cortez48512", null, "Cortez", "iQGBeTgpe3", null, 1, null, null, "Damian33@nearbpo.com", "Damián" },
                    { "Samuel.Borrego513", null, "Borrego", "ZiVpTGLeE8", null, 1, null, null, "Samuel_Borrego14@nearbpo.com", "Samuel" },
                    { "Teresa_Sanabria94514", null, "Sanabria", "aQpH24cAGS", null, 1, null, null, "Teresa46@nearbpo.com", "Teresa" },
                    { "Beatriz_Fernandez74515", null, "Fernández", "zx3A4ufmb0", null, 1, null, null, "Beatriz_Fernandez@yahoo.com", "Beatriz" },
                    { "Sofia48507", null, "Escalante", "8YvkoFTN4v", null, 1, null, null, "Sofia0@corpfolder.com", "Sofia" },
                    { "Dorotea_Casares516", null, "Casares", "SzCCxuNRU8", null, 1, null, null, "Dorotea.Casares@gmail.com", "Dorotea" },
                    { "Margarita.Valencia518", null, "Valencia", "n0B0VkcfqF", null, 1, null, null, "Margarita.Valencia49@corpfolder.com", "Margarita" },
                    { "Rosa_Bravo519", null, "Bravo", "qUXY_o0hEg", null, 1, null, null, "Rosa.Bravo31@nearbpo.com", "Rosa" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Rocio_Adorno4520", null, "Adorno", "oOU9KyIlwP", null, 1, null, null, "Rocio.Adorno66@gmail.com", "Rocio" },
                    { "Susana_Prado1521", null, "Prado", "e3aGE_eiDs", null, 1, null, null, "Susana.Prado54@hotmail.com", "Susana" },
                    { "Homero.Quintana34522", null, "Quintana", "78UGdKrsk4", null, 1, null, null, "Homero57@yahoo.com", "Homero" },
                    { "Leticia.Regalado523", null, "Regalado", "0SZv1JCqIm", null, 1, null, null, "Leticia_Regalado99@hotmail.com", "Leticia" },
                    { "Adan97524", null, "Corona", "sLGvt4KkPK", null, 1, null, null, "Adan_Corona97@gmail.com", "Adán" },
                    { "Jose59517", null, "Xiana", "KWUkHkZ_2b", null, 1, null, null, "Jose33@corpfolder.com", "José" },
                    { "Natalia.Montalvo312", null, "Montalvo", "vYDgL2xXfZ", null, 1, null, null, "Natalia_Montalvo@yahoo.com", "Natalia" },
                    { "LuisFernando.Curiel49311", null, "Curiel", "70wvJVoXCG", null, 1, null, null, "LuisFernando.Curiel@nearbpo.com", "Luis Fernando" },
                    { "Gabriela.Aragon310", null, "Aragón", "mUiRYgn2v7", null, 1, null, null, "Gabriela37@corpfolder.com", "Gabriela" },
                    { "Gonzalo.Sevilla7399", null, "Sevilla", "kL8dY4hL6m", null, 1, null, null, "Gonzalo8@yahoo.com", "Gonzalo" },
                    { "JoseLuis14100", null, "Mena", "WpdYKgtkPl", null, 1, null, null, "JoseLuis_Mena22@nearbpo.com", "José Luis" },
                    { "Pilar_Henriquez101", null, "Henríquez", "CbLgyCg_Vs", null, 1, null, null, "Pilar_Henriquez@yahoo.com", "Pilar" },
                    { "Salvador82102", null, "Zepeda", "me2KhweiZI", null, 1, null, null, "Salvador_Zepeda50@hotmail.com", "Salvador" },
                    { "Guadalupe.Kardachesoto90103", null, "Kardache soto", "qcuowCEGou", null, 1, null, null, "Guadalupe13@corpfolder.com", "Guadalupe" },
                    { "Isabel_Xenia104", null, "Xenia", "3X5zIY1edB", null, 1, null, null, "Isabel99@hotmail.com", "Isabel" },
                    { "Ivanna53105", null, "Urías", "jkdlpkyC9t", null, 1, null, null, "Ivanna.Urias@yahoo.com", "Ivanna" },
                    { "Josefina_Barrientos10106", null, "Barrientos", "v0YLYUtxAH", null, 1, null, null, "Josefina_Barrientos31@hotmail.com", "Josefina" },
                    { "Jacobo_Olivera15107", null, "Olivera", "7ZiTtSm7sk", null, 1, null, null, "Jacobo_Olivera83@nearbpo.com", "Jacobo" },
                    { "Catalina.Flores40108", null, "Flores", "uMeAOi8Hjs", null, 1, null, null, "Catalina_Flores1@gmail.com", "Catalina" },
                    { "Patricio_Chapa109", null, "Chapa", "9TP6f2XsoE", null, 1, null, null, "Patricio_Chapa@corpfolder.com", "Patricio" },
                    { "Elizabeth_Cavazos63110", null, "Cavazos", "Ssl12P1tx7", null, 1, null, null, "Elizabeth.Cavazos53@gmail.com", "Elizabeth" },
                    { "Soledad76111", null, "Reynoso", "FunzL0feQB", null, 1, null, null, "Soledad22@nearbpo.com", "Soledad" },
                    { "JorgeLuis_Mesa112", null, "Mesa", "yiCWsIcoNB", null, 1, null, null, "JorgeLuis69@gmail.com", "Jorge Luis" },
                    { "Luisa88113", null, "Quiñones", "eqE3231y2f", null, 1, null, null, "Luisa.Quinones88@gmail.com", "Luisa" },
                    { "German.Viera98", null, "Viera", "USvN2sG5QI", null, 1, null, null, "German2@hotmail.com", "Germán" },
                    { "Micaela1097", null, "Curiel", "2bz0lC6SWI", null, 1, null, null, "Micaela49@corpfolder.com", "Micaela" },
                    { "Victoria.Muro896", null, "Muro", "diFG56YNat", null, 1, null, null, "Victoria44@gmail.com", "Victoria" },
                    { "Ariadna.Zamora395", null, "Zamora", "7BzvoALjP4", null, 1, null, null, "Ariadna50@gmail.com", "Ariadna" },
                    { "LuisFernando_Padilla5279", null, "Padilla", "HsP_85iRsC", null, 1, null, null, "LuisFernando0@corpfolder.com", "Luis Fernando" },
                    { "Timoteo_Granados1980", null, "Granados", "BJX6Cvx4cH", null, 1, null, null, "Timoteo_Granados@corpfolder.com", "Timoteo" },
                    { "Alfonso.Lomeli1381", null, "Lomeli", "IXYWlYChuZ", null, 1, null, null, "Alfonso.Lomeli73@yahoo.com", "Alfonso" },
                    { "MariaElena7082", null, "Kamal", "ABBye7cW4m", null, 1, null, null, "MariaElena_Kamal66@yahoo.com", "María Elena" },
                    { "AnaMaria.Benitez83", null, "Benítez", "rUTi77mexh", null, 1, null, null, "AnaMaria13@yahoo.com", "Ana María" },
                    { "Ernesto7184", null, "Carreón", "O5Le3Nzb_a", null, 1, null, null, "Ernesto48@corpfolder.com", "Ernesto" },
                    { "Uriel_Gaytan85", null, "Gaytán", "Fo_4Mzn5vH", null, 1, null, null, "Uriel_Gaytan@nearbpo.com", "Uriel" },
                    { "Alfonso.Morales114", null, "Morales", "63W5ztXQ_R", null, 1, null, null, "Alfonso.Morales78@hotmail.com", "Alfonso" },
                    { "Lourdes1286", null, "Puente", "aC9IiZ6HHD", null, 1, null, null, "Lourdes.Puente@yahoo.com", "Lourdes" },
                    { "Susana.Caban7788", null, "Cabán", "XlgZ9INjAW", null, 1, null, null, "Susana.Caban@gmail.com", "Susana" },
                    { "Alan_Uribe89", null, "Uribe", "JXX5eL3wB_", null, 1, null, null, "Alan_Uribe13@corpfolder.com", "Alan" },
                    { "Yaretzi_Olivares6290", null, "Olivares", "jK7jsy8QZK", null, 1, null, null, "Yaretzi76@nearbpo.com", "Yaretzi" },
                    { "Alexa7091", null, "Oquendo", "FVHP5R2AAE", null, 1, null, null, "Alexa_Oquendo32@gmail.com", "Alexa" },
                    { "Rocio.Santillan92", null, "Santillán", "4YOowhKag3", null, 1, null, null, "Rocio8@corpfolder.com", "Rocio" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Alexis_Rangel93", null, "Rangel", "PP6BsfW3ku", null, 1, null, null, "Alexis.Rangel55@yahoo.com", "Alexis" },
                    { "Emiliano1994", null, "Valdés", "wu_XkYXDhk", null, 1, null, null, "Emiliano35@nearbpo.com", "Emiliano" },
                    { "Salvador_Haro5787", null, "Haro", "MgZFxtQ8Vl", null, 1, null, null, "Salvador_Haro@yahoo.com", "Salvador" },
                    { "LuisGabino_Castillo4978", null, "Castillo", "4uqxXyCEA9", null, 1, null, null, "LuisGabino.Castillo@nearbpo.com", "Luis Gabino" },
                    { "Lourdes.Concepcion115", null, "Concepción", "owASrFuyZs", null, 1, null, null, "Lourdes_Concepcion@corpfolder.com", "Lourdes" },
                    { "AngelGabriel.Gollum80117", null, "Gollum", "k7_ndnqmEM", null, 1, null, null, "AngelGabriel97@hotmail.com", "Ángel Gabriel" },
                    { "Daniel.Rios32138", null, "Ríos", "wLKywsdwm_", null, 1, null, null, "Daniel_Rios@nearbpo.com", "Daniel" },
                    { "Timoteo10139", null, "Véliz", "lfNcm9HZpo", null, 1, null, null, "Timoteo_Veliz62@gmail.com", "Timoteo" },
                    { "Oscar.Mendoza140", null, "Mendoza", "HSIrk4Y2_e", null, 1, null, null, "Oscar.Mendoza@gmail.com", "Óscar" },
                    { "Guillermina26141", null, "Regalado", "VD2WXLeV7R", null, 1, null, null, "Guillermina83@nearbpo.com", "Guillermina" },
                    { "Matias17142", null, "Olivera", "yfGGfT4GBa", null, 1, null, null, "Matias.Olivera@yahoo.com", "Matías" },
                    { "Rocio.Ocasio143", null, "Ocasio", "MXyhVVgx4t", null, 1, null, null, "Rocio_Ocasio21@yahoo.com", "Rocio" },
                    { "Sonia.Herrera85144", null, "Herrera", "bUednRY1Kd", null, 1, null, null, "Sonia10@gmail.com", "Sonia" },
                    { "Rafael98145", null, "Ledesma", "_HLebUsDrt", null, 1, null, null, "Rafael.Ledesma@hotmail.com", "Rafael" },
                    { "Pedro99146", null, "Hurtado", "BHtrYN9WFB", null, 1, null, null, "Pedro.Hurtado32@hotmail.com", "Pedro" },
                    { "JoseEmilio.Sierra22147", null, "Sierra", "rzKJIjW8kJ", null, 1, null, null, "JoseEmilio.Sierra9@gmail.com", "José Emilio" },
                    { "Amalia_Gaitan148", null, "Gaitán", "2MCXA8Q4w2", null, 1, null, null, "Amalia.Gaitan59@yahoo.com", "Amalia" },
                    { "Carla16149", null, "Ramos", "edgfLrkvru", null, 1, null, null, "Carla_Ramos81@nearbpo.com", "Carla" },
                    { "Sonia.Arguello150", null, "Arguello", "i8zXKiKLsC", null, 1, null, null, "Sonia.Arguello10@nearbpo.com", "Sonia" },
                    { "Eva.Rosario151", null, "Rosario", "v1fN9ClFUI", null, 1, null, null, "Eva31@corpfolder.com", "Eva" },
                    { "Maximiliano.Raya152", null, "Raya", "KlyaCkJqXn", null, 1, null, null, "Maximiliano_Raya@yahoo.com", "Maximiliano" },
                    { "Brandon.Marrero137", null, "Marrero", "ifoOT1mKJA", null, 1, null, null, "Brandon.Marrero@corpfolder.com", "Brandon" },
                    { "Jorge.Leiva17136", null, "Leiva", "9y7eI9hxwG", null, 1, null, null, "Jorge67@gmail.com", "Jorge" },
                    { "Alan.Kortahernandez135", null, "Korta hernandez", "8AYMe15Qqz", null, 1, null, null, "Alan.Kortahernandez@corpfolder.com", "Alan" },
                    { "Ariadna.Casillas58134", null, "Casillas", "tfHXpzAAsx", null, 1, null, null, "Ariadna_Casillas@gmail.com", "Ariadna" },
                    { "Margarita_Saavedra7118", null, "Saavedra", "tfzGUjYM8p", null, 1, null, null, "Margarita67@corpfolder.com", "Margarita" },
                    { "Lourdes_Robledo119", null, "Robledo", "cS69hkJeFT", null, 1, null, null, "Lourdes.Robledo71@gmail.com", "Lourdes" },
                    { "Francisco98120", null, "Guillen", "Y6KTlxJZMF", null, 1, null, null, "Francisco66@corpfolder.com", "Francisco" },
                    { "Nicole_Reyna121", null, "Reyna", "gqQDp0eaMu", null, 1, null, null, "Nicole.Reyna77@nearbpo.com", "Nicole" },
                    { "Monserrat.Quintanilla34122", null, "Quintanilla", "2X2AntW57T", null, 1, null, null, "Monserrat_Quintanilla92@hotmail.com", "Monserrat" },
                    { "Mario.Bermudez123", null, "Bermúdez", "_hhzwHrYxf", null, 1, null, null, "Mario47@nearbpo.com", "Mario" },
                    { "Berta.Molina33124", null, "Molina", "dL_Z72pdnP", null, 1, null, null, "Berta_Molina@yahoo.com", "Berta" },
                    { "Ivan57116", null, "Cabán", "OJOTskJseY", null, 1, null, null, "Ivan_Caban@yahoo.com", "Ivan" },
                    { "Jesus40125", null, "Hurtado", "lnUKJtfJN7", null, 1, null, null, "Jesus.Hurtado@gmail.com", "Jesús" },
                    { "Gilberto.Rolon68127", null, "Rolón", "MgaN3MOjBP", null, 1, null, null, "Gilberto.Rolon37@corpfolder.com", "Gilberto" },
                    { "MariaElena13128", null, "Alcántar", "YSc6fVhLiU", null, 1, null, null, "MariaElena_Alcantar@yahoo.com", "María Elena" },
                    { "Lorenzo_Montano43129", null, "Montaño", "ExYAj9BcPo", null, 1, null, null, "Lorenzo15@corpfolder.com", "Lorenzo" },
                    { "RosaMaria_Teran130", null, "Terán", "dEXKoxe3u7", null, 1, null, null, "RosaMaria_Teran63@corpfolder.com", "Rosa María" },
                    { "Joaquin67131", null, "Colón", "3LOYfh8eOb", null, 1, null, null, "Joaquin92@hotmail.com", "Joaquín" },
                    { "Martin.Cavazos132", null, "Cavazos", "Sh2LL9X2IS", null, 1, null, null, "Martin_Cavazos@yahoo.com", "Martín" },
                    { "JoseMiguel64133", null, "Blanco", "6DJvcO4GYr", null, 1, null, null, "JoseMiguel_Blanco@hotmail.com", "José Miguel" },
                    { "Carla.Jaime126", null, "Jaime", "jfsVBsHDcm", null, 1, null, null, "Carla.Jaime60@corpfolder.com", "Carla" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Berta95153", null, "Aparicio", "78yJ51T5tF", null, 1, null, null, "Berta_Aparicio@hotmail.com", "Berta" },
                    { "Luis.Zambrana9277", null, "Zambrana", "fVVtxLQDfa", null, 1, null, null, "Luis62@corpfolder.com", "Luis" },
                    { "Vicente6575", null, "Abeyta", "OTqdj30R2b", null, 1, null, null, "Vicente_Abeyta70@gmail.com", "Vicente" },
                    { "Estefania.Cepeda5321", null, "Cepeda", "VtF2ybB6zP", null, 1, null, null, "Estefania15@yahoo.com", "Estefanía" },
                    { "Antonia_Quintana2622", null, "Quintana", "nhrELbNpld", null, 1, null, null, "Antonia_Quintana65@nearbpo.com", "Antonia" },
                    { "Rafael6323", null, "Urbina", "FNrJ9hQORI", null, 1, null, null, "Rafael_Urbina@nearbpo.com", "Rafael" },
                    { "Debora_Elizondo24", null, "Elizondo", "1b0sdZLrZ7", null, 1, null, null, "Debora_Elizondo45@yahoo.com", "Débora" },
                    { "JoseLuis.Zelaya9425", null, "Zelaya", "NfnXlqDB4k", null, 1, null, null, "JoseLuis_Zelaya@corpfolder.com", "José Luis" },
                    { "MariaCristina.Delrio26", null, "Delrío", "VziAbXNR4G", null, 1, null, null, "MariaCristina_Delrio@corpfolder.com", "María Cristina" },
                    { "DulceMaria8127", null, "Amador", "47M_kusIbs", null, 1, null, null, "DulceMaria_Amador@gmail.com", "Dulce María" },
                    { "Concepcion328", null, "Polanco", "aVEAv9JAbM", null, 1, null, null, "Concepcion.Polanco5@corpfolder.com", "Concepción" },
                    { "Luisa.Valentin4229", null, "Valentín", "0VTmv2uJVq", null, 1, null, null, "Luisa_Valentin18@hotmail.com", "Luisa" },
                    { "Gerardo.Castillo30", null, "Castillo", "AgkR306TJS", null, 1, null, null, "Gerardo60@hotmail.com", "Gerardo" },
                    { "JulioCesar_Luevano4831", null, "Luevano", "HqbZUoL3hr", null, 1, null, null, "JulioCesar_Luevano@hotmail.com", "Julio César" },
                    { "Luis1032", null, "Montalvo", "d_nyYhH1C0", null, 1, null, null, "Luis27@hotmail.com", "Luis" },
                    { "JoseMiguel.Varela6833", null, "Varela", "1FQEtuj5bA", null, 1, null, null, "JoseMiguel_Varela48@nearbpo.com", "José Miguel" },
                    { "JoseDaniel_Cadena34", null, "Cadena", "bDWzfdZGw7", null, 1, null, null, "JoseDaniel_Cadena50@corpfolder.com", "Jose Daniel" },
                    { "Andres5835", null, "Echevarría", "FRcbP_yIpu", null, 1, null, null, "Andres22@corpfolder.com", "Andrés" },
                    { "AngelDaniel.Zambrano1520", null, "Zambrano", "lZXaWo9DyR", null, 1, null, null, "AngelDaniel_Zambrano73@hotmail.com", "Ángel Daniel" },
                    { "Miguel.Grijalva819", null, "Grijalva", "IANIBgPpJw", null, 1, null, null, "Miguel_Grijalva@yahoo.com", "Miguel" },
                    { "Gerardo_Baeza18", null, "Baeza", "OUxGXnHlRM", null, 1, null, null, "Gerardo96@yahoo.com", "Gerardo" },
                    { "Mariana_Cordova717", null, "Córdova", "iiPQrAn3UP", null, 1, null, null, "Mariana58@hotmail.com", "Mariana" },
                    { "Eloisa101", null, "Rosales", "unYKVk63qG", null, 1, null, null, "Eloisa65@gmail.com", "Eloisa" },
                    { "Matias22", null, "Miranda", "qYZyHJY1Qb", null, 1, null, null, "Matias.Miranda65@gmail.com", "Matías" },
                    { "Elena_Espinosa3", null, "Espinosa", "zB65sE17iw", null, 1, null, null, "Elena.Espinosa16@hotmail.com", "Elena" },
                    { "Esperanza304", null, "Xairo Belmonte", "4fqtBrYdjm", null, 1, null, null, "Esperanza_XairoBelmonte@gmail.com", "Esperanza" },
                    { "Julieta_Parra905", null, "Parra", "j5U394i1ZB", null, 1, null, null, "Julieta70@hotmail.com", "Julieta" },
                    { "Samuel.Melendez226", null, "Meléndez", "BW8VrFaIwX", null, 1, null, null, "Samuel.Melendez45@hotmail.com", "Samuel" },
                    { "Rodrigo657", null, "Gallardo", "CX2U8AUajo", null, 1, null, null, "Rodrigo_Gallardo14@hotmail.com", "Rodrigo" },
                    { "MariadelosAngeles_Mora2436", null, "Mora", "TfH7s0qPqZ", null, 1, null, null, "MariadelosAngeles.Mora7@nearbpo.com", "María de los Ángeles" },
                    { "Sebastian.Rivera618", null, "Rivera", "v9zaBqd8nO", null, 1, null, null, "Sebastian.Rivera36@nearbpo.com", "Sebastian" },
                    { "Carlos9410", null, "Delao", "x5DnQjOi6x", null, 1, null, null, "Carlos16@corpfolder.com", "Carlos" },
                    { "Julieta_Martinez11", null, "Martínez", "IV14l4aS44", null, 1, null, null, "Julieta8@gmail.com", "Julieta" },
                    { "DulceMaria.Olivas1512", null, "Olivas", "JJlz7EyXvq", null, 1, null, null, "DulceMaria_Olivas18@yahoo.com", "Dulce María" },
                    { "Luisa1513", null, "Urías", "pzKJAGhL4K", null, 1, null, null, "Luisa.Urias43@yahoo.com", "Luisa" },
                    { "German.Carrion7014", null, "Carrion", "9h8KnF8TZ6", null, 1, null, null, "German58@gmail.com", "Germán" },
                    { "Manuel_Alanis15", null, "Alanis", "RQb1_nNCB_", null, 1, null, null, "Manuel_Alanis@nearbpo.com", "Manuel" },
                    { "Monica9916", null, "Ortega", "wY4p08TZOS", null, 1, null, null, "Monica.Ortega60@nearbpo.com", "Mónica" },
                    { "Raul519", null, "Pizarro", "gV1vwleKY1", null, 1, null, null, "Raul12@corpfolder.com", "Raúl" },
                    { "Tomas.Candelaria76", null, "Candelaria", "7883yHY3eo", null, 1, null, null, "Tomas77@nearbpo.com", "Tomás" },
                    { "Ines_Alcantar37", null, "Alcántar", "YJ0s97Jjsw", null, 1, null, null, "Ines_Alcantar@yahoo.com", "Inés" },
                    { "Valeria.Cardona39", null, "Cardona", "_QMM2S6uPk", null, 1, null, null, "Valeria_Cardona15@hotmail.com", "Valeria" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "MariadelosAngeles_Vega8360", null, "Vega", "MGjP5DE_Ht", null, 1, null, null, "MariadelosAngeles91@gmail.com", "María de los Ángeles" },
                    { "Zoe.Ramon61", null, "Ramón", "7qTPBgLNHD", null, 1, null, null, "Zoe44@nearbpo.com", "Zoe" },
                    { "Emiliano6462", null, "Ochoa", "f8oR5ORjTi", null, 1, null, null, "Emiliano31@corpfolder.com", "Emiliano" },
                    { "Lorena.Nevarez1463", null, "Nevárez", "u6OsdcyOYd", null, 1, null, null, "Lorena_Nevarez@nearbpo.com", "Lorena" },
                    { "Barbara_Serna64", null, "Serna", "SYJGBgOpn_", null, 1, null, null, "Barbara.Serna50@corpfolder.com", "Barbara" },
                    { "Alexander.Gallegos8165", null, "Gallegos", "0i3qbysPjt", null, 1, null, null, "Alexander.Gallegos74@yahoo.com", "Alexander" },
                    { "Teodoro.Baez9666", null, "Báez", "WunmvZr9XJ", null, 1, null, null, "Teodoro.Baez@hotmail.com", "Teodoro" },
                    { "Leonardo_Sauceda1467", null, "Sauceda", "hKEFBPH6yN", null, 1, null, null, "Leonardo.Sauceda90@yahoo.com", "Leonardo" },
                    { "Esteban7968", null, "Verduzco", "KhQZIhIWyb", null, 1, null, null, "Esteban_Verduzco2@corpfolder.com", "Esteban" },
                    { "Estela5069", null, "Cortez", "ztr8L3e_0a", null, 1, null, null, "Estela.Cortez@nearbpo.com", "Estela" },
                    { "Camila_Delapaz70", null, "Delapaz", "mkXSQFPFUe", null, 1, null, null, "Camila_Delapaz99@nearbpo.com", "Camila" },
                    { "Elena1171", null, "Osorio", "MmdhWXE1hs", null, 1, null, null, "Elena.Osorio@nearbpo.com", "Elena" },
                    { "Leticia1672", null, "Moreno", "lR87TUZjyF", null, 1, null, null, "Leticia.Moreno@nearbpo.com", "Leticia" },
                    { "Julieta.Adorno73", null, "Adorno", "26IFa6ujrD", null, 1, null, null, "Julieta_Adorno@nearbpo.com", "Julieta" },
                    { "Carolina.Olivas9174", null, "Olivas", "w6gsOSKZ19", null, 1, null, null, "Carolina87@hotmail.com", "Carolina" },
                    { "Virginia.Kyra59", null, "Kyra", "PaHEbJwIG5", null, 1, null, null, "Virginia9@gmail.com", "Virginia" },
                    { "JuanPablo_Armendariz7758", null, "Armendáriz", "EokDjDjbyj", null, 1, null, null, "JuanPablo_Armendariz@nearbpo.com", "Juan Pablo" },
                    { "RosaMaria.Calderon5557", null, "Calderón", "zm8Ta_4v9e", null, 1, null, null, "RosaMaria_Calderon58@corpfolder.com", "Rosa María" },
                    { "Rosalia9156", null, "Granados", "hMuXIhA7GB", null, 1, null, null, "Rosalia_Granados70@corpfolder.com", "Rosalia" },
                    { "MiguelAngel.Contreras40", null, "Contreras", "rkg0YMxW1y", null, 1, null, null, "MiguelAngel_Contreras26@corpfolder.com", "Miguel Ángel" },
                    { "Miguel.deAnda841", null, "de Anda", "9PZBfacob4", null, 1, null, null, "Miguel68@gmail.com", "Miguel" },
                    { "Francisca_Batista42", null, "Batista", "hBCZHs3cka", null, 1, null, null, "Francisca.Batista@corpfolder.com", "Francisca" },
                    { "JoseEmilio.Carranza2443", null, "Carranza", "k5gvI6ruW6", null, 1, null, null, "JoseEmilio31@hotmail.com", "José Emilio" },
                    { "Manuel1244", null, "Villanueva", "yI6wT7gUFy", null, 1, null, null, "Manuel_Villanueva47@corpfolder.com", "Manuel" },
                    { "Isabela.Baez45", null, "Báez", "ZpxKUIHty2", null, 1, null, null, "Isabela.Baez@nearbpo.com", "Isabela" },
                    { "Rafael3546", null, "Narváez", "aEwWLIczyj", null, 1, null, null, "Rafael13@corpfolder.com", "Rafael" },
                    { "Elena838", null, "Yago", "hW8yGK7187", null, 1, null, null, "Elena.Yago42@hotmail.com", "Elena" },
                    { "Blanca6247", null, "Núñez", "sfTqw3K30l", null, 1, null, null, "Blanca.Nunez@hotmail.com", "Blanca" },
                    { "Kimberly_Rendon49", null, "Rendón", "M06MQuwwMN", null, 1, null, null, "Kimberly.Rendon@hotmail.com", "Kimberly" },
                    { "Lorenzo.Barrios50", null, "Barrios", "nYIp_AywDr", null, 1, null, null, "Lorenzo47@gmail.com", "Lorenzo" },
                    { "Ramon_Rodriguez1551", null, "Rodríguez", "24eamMcjNU", null, 1, null, null, "Ramon_Rodriguez@gmail.com", "Ramón" },
                    { "JoseEmilio_Almanza52", null, "Almanza", "sRXQzDXFEa", null, 1, null, null, "JoseEmilio34@gmail.com", "José Emilio" },
                    { "Victor953", null, "Apodaca", "Vruf7Edc4e", null, 1, null, null, "Victor.Apodaca@corpfolder.com", "Víctor" },
                    { "Mayte.Heredia3754", null, "Heredia", "3jUXGzi5Ce", null, 1, null, null, "Mayte94@gmail.com", "Mayte" },
                    { "Graciela_Olivas6455", null, "Olivas", "YfFs0qqRki", null, 1, null, null, "Graciela84@yahoo.com", "Graciela" },
                    { "Liliana1048", null, "Mendoza", "D4ImfYf820", null, 1, null, null, "Liliana.Mendoza90@yahoo.com", "Liliana" },
                    { "Nicole46154", null, "Carbajal", "LgYcmYpaC1", null, 1, null, null, "Nicole.Carbajal@hotmail.com", "Nicole" },
                    { "Marcela.Torres37155", null, "Torres", "hG21WaRuSi", null, 1, null, null, "Marcela_Torres@corpfolder.com", "Marcela" },
                    { "Angela_Huerta156", null, "Huerta", "2RzYxcYp2i", null, 1, null, null, "Angela_Huerta@hotmail.com", "Ángela" },
                    { "Carmen21256", null, "Longoria", "D4jRpVi16E", null, 1, null, null, "Carmen_Longoria@nearbpo.com", "Carmen" },
                    { "Maximiliano_Corral44257", null, "Corral", "XgP5kN6wow", null, 1, null, null, "Maximiliano.Corral60@hotmail.com", "Maximiliano" },
                    { "Rosa55258", null, "Villanueva", "KQlRNLNuwY", null, 1, null, null, "Rosa96@gmail.com", "Rosa" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Alexa_Acuna259", null, "Acuña", "Nk1OZC012c", null, 1, null, null, "Alexa_Acuna@nearbpo.com", "Alexa" },
                    { "Vanessa85260", null, "Xacon", "l_1JR97Hze", null, 1, null, null, "Vanessa_Xacon81@hotmail.com", "Vanessa" },
                    { "Raul.Esquibel68261", null, "Esquibel", "eEZvmTrTgW", null, 1, null, null, "Raul.Esquibel83@yahoo.com", "Raúl" },
                    { "Yaretzi10262", null, "Apodaca", "Sg5kTM75Or", null, 1, null, null, "Yaretzi76@yahoo.com", "Yaretzi" },
                    { "Clara.Cervantes263", null, "Cervantes", "PuT3YlvFVk", null, 1, null, null, "Clara.Cervantes@corpfolder.com", "Clara" },
                    { "MiguelAngel64264", null, "Castellanos", "rZ7mWCRgrJ", null, 1, null, null, "MiguelAngel.Castellanos0@corpfolder.com", "Miguel Ángel" },
                    { "Conchita_Aguirre265", null, "Aguirre", "F0FPyhznIj", null, 1, null, null, "Conchita_Aguirre@yahoo.com", "Conchita" },
                    { "Estefania.Cortez17266", null, "Cortez", "yhiapfGA8Y", null, 1, null, null, "Estefania74@hotmail.com", "Estefanía" },
                    { "Horacio.Arenas83267", null, "Arenas", "YTJ_XmDuuR", null, 1, null, null, "Horacio_Arenas18@gmail.com", "Horacio" },
                    { "Luis.Alaniz268", null, "Alaniz", "YQh_NgJL1r", null, 1, null, null, "Luis.Alaniz8@nearbpo.com", "Luis" },
                    { "Alejandra.Serna72269", null, "Serna", "nDXNMxCSpw", null, 1, null, null, "Alejandra44@yahoo.com", "Alejandra" },
                    { "Alicia17270", null, "Sánchez", "48rZls9TLJ", null, 1, null, null, "Alicia.Sanchez@nearbpo.com", "Alicia" },
                    { "Carolina.Ontiveros0255", null, "Ontiveros", "sYZsJTyaxs", null, 1, null, null, "Carolina_Ontiveros55@yahoo.com", "Carolina" },
                    { "Marcos_Baeza56254", null, "Baeza", "0HLWRyEsmW", null, 1, null, null, "Marcos71@gmail.com", "Marcos" },
                    { "Alejandra_Pineda14253", null, "Pineda", "TwlyzLKnwK", null, 1, null, null, "Alejandra.Pineda32@hotmail.com", "Alejandra" },
                    { "Gerardo32252", null, "Márquez", "TgcIxgHRh3", null, 1, null, null, "Gerardo_Marquez66@gmail.com", "Gerardo" },
                    { "Fernando_Miramontes236", null, "Miramontes", "pAQ7QmCuec", null, 1, null, null, "Fernando.Miramontes87@yahoo.com", "Fernando" },
                    { "Amalia.Ayala95237", null, "Ayala", "MPfc4h0wvg", null, 1, null, null, "Amalia8@yahoo.com", "Amalia" },
                    { "Carmen.Ramos37238", null, "Ramos", "NGqwhZu0Qg", null, 1, null, null, "Carmen_Ramos@hotmail.com", "Carmen" },
                    { "JoseMaria10239", null, "Murillo", "oPmyAmZWhf", null, 1, null, null, "JoseMaria.Murillo16@gmail.com", "José María" },
                    { "Jeronimo.Leon71240", null, "León", "9FMxejXN2c", null, 1, null, null, "Jeronimo.Leon14@corpfolder.com", "Jerónimo" },
                    { "FranciscoJavier_Bustamante241", null, "Bustamante", "XgEtbURM9S", null, 1, null, null, "FranciscoJavier.Bustamante80@corpfolder.com", "Francisco Javier" },
                    { "Carlota.Feliciano11242", null, "Feliciano", "EImWxcOdXk", null, 1, null, null, "Carlota.Feliciano34@corpfolder.com", "Carlota" },
                    { "Ximena64271", null, "Gutiérrez", "eS8Mu90zCp", null, 1, null, null, "Ximena98@corpfolder.com", "Ximena" },
                    { "Natalia_Jaime77243", null, "Jaime", "LPkJXtRWO3", null, 1, null, null, "Natalia.Jaime@corpfolder.com", "Natalia" },
                    { "Irene1245", null, "Soliz", "heuCHcBaCX", null, 1, null, null, "Irene.Soliz37@hotmail.com", "Irene" },
                    { "Martin.Sisneros18246", null, "Sisneros", "LL2ecXKb3S", null, 1, null, null, "Martin70@corpfolder.com", "Martín" },
                    { "Lola_Gaona247", null, "Gaona", "i4ROyMGy7W", null, 1, null, null, "Lola94@yahoo.com", "Lola" },
                    { "Soledad_Munguia90248", null, "Munguía", "tGoG7rSv70", null, 1, null, null, "Soledad.Munguia76@yahoo.com", "Soledad" },
                    { "Regina_Mascarenas29249", null, "Mascareñas", "zMcFs5WEVs", null, 1, null, null, "Regina.Mascarenas@hotmail.com", "Regina" },
                    { "Eduardo_Galvez250", null, "Gálvez", "P7DCo52OgV", null, 1, null, null, "Eduardo_Galvez37@hotmail.com", "Eduardo" },
                    { "Isaias13251", null, "Arias", "ZVhORQazf7", null, 1, null, null, "Isaias_Arias@gmail.com", "Isaias" },
                    { "AngelGabriel.Terrazas244", null, "Terrazas", "d7VoUkawUm", null, 1, null, null, "AngelGabriel80@gmail.com", "Ángel Gabriel" },
                    { "JuanPablo6235", null, "Espinoza", "khX8zuGegJ", null, 1, null, null, "JuanPablo28@gmail.com", "Juan Pablo" },
                    { "Virginia.Blanco36272", null, "Blanco", "Kxme_lFL9S", null, 1, null, null, "Virginia.Blanco17@nearbpo.com", "Virginia" },
                    { "Jaime.Paz58274", null, "Paz", "aaxKyyvmHS", null, 1, null, null, "Jaime_Paz84@corpfolder.com", "Jaime" },
                    { "Paola.Narvaez36295", null, "Narváez", "xvGwEEUQBT", null, 1, null, null, "Paola20@hotmail.com", "Paola" },
                    { "MariaElena.Pena296", null, "Peña", "dz8TcWw09n", null, 1, null, null, "MariaElena99@nearbpo.com", "María Elena" },
                    { "David_Ledesma97297", null, "Ledesma", "ssbt445C7E", null, 1, null, null, "David.Ledesma41@corpfolder.com", "David" },
                    { "Elsa_Delacruz298", null, "Delacrúz", "KCQnID2eoo", null, 1, null, null, "Elsa.Delacruz@hotmail.com", "Elsa" },
                    { "Dorotea77299", null, "Nava", "JqRHiqN5xE", null, 1, null, null, "Dorotea16@corpfolder.com", "Dorotea" },
                    { "Yamileth.Quesada51300", null, "Quesada", "8UXH3uhV2I", null, 1, null, null, "Yamileth.Quesada87@yahoo.com", "Yamileth" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Amalia70301", null, "Cruz", "QloUJ9kC2c", null, 1, null, null, "Amalia96@nearbpo.com", "Amalia" },
                    { "Dorotea.Hernandes302", null, "Hernandes", "i2T7WlXaLl", null, 1, null, null, "Dorotea.Hernandes31@hotmail.com", "Dorotea" },
                    { "MariaJose_Reyes83303", null, "Reyes", "GjkjhalFO3", null, 1, null, null, "MariaJose_Reyes@nearbpo.com", "María José" },
                    { "FernandoJavier_Arellano304", null, "Arellano", "3eqmfIlZur", null, 1, null, null, "FernandoJavier.Arellano54@yahoo.com", "Fernando Javier" },
                    { "Vanessa.Casares89305", null, "Casares", "KQXaOTwQsW", null, 1, null, null, "Vanessa.Casares19@gmail.com", "Vanessa" },
                    { "Emiliano_Delatorre86306", null, "Delatorre", "a0dloM9cK4", null, 1, null, null, "Emiliano_Delatorre@gmail.com", "Emiliano" },
                    { "Paola.Coronado307", null, "Coronado", "rwpcA5Ok4X", null, 1, null, null, "Paola1@hotmail.com", "Paola" },
                    { "Manuel.Badillo40308", null, "Badillo", "42YI6y57jM", null, 1, null, null, "Manuel_Badillo@gmail.com", "Manuel" },
                    { "Rebeca_Yunta309", null, "Yunta", "9Gae5wDCn6", null, 1, null, null, "Rebeca.Yunta91@yahoo.com", "Rebeca" },
                    { "JoseMaria_Barajas294", null, "Barajas", "31dfOr9s7d", null, 1, null, null, "JoseMaria_Barajas93@corpfolder.com", "José María" },
                    { "Laura50293", null, "Pichardo", "tKUuF58X7A", null, 1, null, null, "Laura_Pichardo@corpfolder.com", "Laura" },
                    { "Lorena38292", null, "Olmos", "msbZO6KLRs", null, 1, null, null, "Lorena_Olmos85@yahoo.com", "Lorena" },
                    { "Rodrigo96291", null, "Colón", "5ptGTe8GDz", null, 1, null, null, "Rodrigo.Colon@nearbpo.com", "Rodrigo" },
                    { "Natalia.Valdes275", null, "Valdés", "LqaQWkj5C5", null, 1, null, null, "Natalia_Valdes@yahoo.com", "Natalia" },
                    { "Miguel.Florez276", null, "Flórez", "0_jsX3pSky", null, 1, null, null, "Miguel.Florez@gmail.com", "Miguel" },
                    { "Abril_Cervantez277", null, "Cervántez", "d2D2ta_Urg", null, 1, null, null, "Abril_Cervantez49@nearbpo.com", "Abril" },
                    { "Benito64278", null, "Lerma", "QAjgdb_Ov2", null, 1, null, null, "Benito57@corpfolder.com", "Benito" },
                    { "MariaCristina_Rodriguez20279", null, "Rodríguez", "eHrWMbpgNz", null, 1, null, null, "MariaCristina_Rodriguez37@yahoo.com", "María Cristina" },
                    { "Antonia66280", null, "Karam", "CUAbPribgE", null, 1, null, null, "Antonia.Karam@corpfolder.com", "Antonia" },
                    { "Timoteo.Florez21281", null, "Flórez", "Kc_nduGg5i", null, 1, null, null, "Timoteo.Florez@corpfolder.com", "Timoteo" },
                    { "Carlota9273", null, "Yami", "l8um9Z8RPw", null, 1, null, null, "Carlota_Yami@nearbpo.com", "Carlota" },
                    { "Gustavo.Zabaleta92282", null, "Zabaleta", "5gDnVvkpas", null, 1, null, null, "Gustavo55@nearbpo.com", "Gustavo" },
                    { "Ivan.Quintairos284", null, "Quintairos", "TKSuJ7LF2v", null, 1, null, null, "Ivan17@gmail.com", "Ivan" },
                    { "Elvira.Bonilla31285", null, "Bonilla", "pIsZHWKEHS", null, 1, null, null, "Elvira.Bonilla@nearbpo.com", "Elvira" },
                    { "Silvia59286", null, "Aguilera", "AzOoHw5VLz", null, 1, null, null, "Silvia.Aguilera@yahoo.com", "Silvia" },
                    { "Ernesto49287", null, "Cintrón", "2cij848C5w", null, 1, null, null, "Ernesto.Cintron@gmail.com", "Ernesto" },
                    { "RosaMaria.Tijerina288", null, "Tijerina", "48rszSdKlu", null, 1, null, null, "RosaMaria52@gmail.com", "Rosa María" },
                    { "Tadeo17289", null, "Granados", "u7lVva6zFP", null, 1, null, null, "Tadeo_Granados@gmail.com", "Tadeo" },
                    { "Jazmin71290", null, "Laureano", "ypjgf6D3F9", null, 1, null, null, "Jazmin_Laureano35@hotmail.com", "Jazmin" },
                    { "Jaime_Mateo79283", null, "Mateo", "S4IjLHBY95", null, 1, null, null, "Jaime_Mateo46@yahoo.com", "Jaime" },
                    { "Catalina.Segovia99234", null, "Segovia", "lAeqionMnG", null, 1, null, null, "Catalina_Segovia49@gmail.com", "Catalina" },
                    { "Tomas60233", null, "Díaz", "1f93BL31TM", null, 1, null, null, "Tomas72@hotmail.com", "Tomás" },
                    { "Ivan.Casas21232", null, "Casas", "WUZZxU9l9I", null, 1, null, null, "Ivan94@corpfolder.com", "Ivan" },
                    { "Reina_Delapaz177", null, "Delapaz", "BtzIjAspQ4", null, 1, null, null, "Reina71@nearbpo.com", "Reina" },
                    { "Leonor_Montalvo178", null, "Montalvo", "KAEJv8l7s2", null, 1, null, null, "Leonor_Montalvo@corpfolder.com", "Leonor" },
                    { "Berta13179", null, "Villagómez", "pllKYge3Kx", null, 1, null, null, "Berta85@nearbpo.com", "Berta" },
                    { "Maricarmen_Medina180", null, "Medina", "3zLPi0nSN4", null, 1, null, null, "Maricarmen_Medina79@nearbpo.com", "Maricarmen" },
                    { "Claudia.Guillen181", null, "Guillen", "fCrEo1t5PY", null, 1, null, null, "Claudia67@gmail.com", "Claudia" },
                    { "Adela97182", null, "Zarate", "CvlXrNSQ3J", null, 1, null, null, "Adela89@hotmail.com", "Adela" },
                    { "Patricia84183", null, "Limón", "KOBTRQgBoV", null, 1, null, null, "Patricia.Limon@yahoo.com", "Patricia" },
                    { "JoseMaria_Godinez97184", null, "Godínez", "UuKRioSSBP", null, 1, null, null, "JoseMaria21@hotmail.com", "José María" },
                    { "Felipe19185", null, "Xairo Belmonte", "14BQB5aMFb", null, 1, null, null, "Felipe91@nearbpo.com", "Felipe" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Juana_Santillan90186", null, "Santillán", "xqYs_DjrDJ", null, 1, null, null, "Juana.Santillan20@nearbpo.com", "Juana" },
                    { "Maricarmen.Casas187", null, "Casas", "e8CGKKH5Hh", null, 1, null, null, "Maricarmen64@yahoo.com", "Maricarmen" },
                    { "Gabriela.Alvarez3188", null, "Alvarez", "9eTcCVnrZw", null, 1, null, null, "Gabriela.Alvarez@nearbpo.com", "Gabriela" },
                    { "Marta.Olmos189", null, "Olmos", "4Ie7Z2qEHt", null, 1, null, null, "Marta6@hotmail.com", "Marta" },
                    { "Zoe40190", null, "Cortez", "3RDB23_HoN", null, 1, null, null, "Zoe61@hotmail.com", "Zoe" },
                    { "Lourdes.Rivero191", null, "Rivero", "7Q4mQlhH51", null, 1, null, null, "Lourdes35@nearbpo.com", "Lourdes" },
                    { "Cristobal.Ortega60176", null, "Ortega", "ZD0lIpYgLL", null, 1, null, null, "Cristobal.Ortega@corpfolder.com", "Cristobal" },
                    { "Rosalia.Aguayo3175", null, "Aguayo", "wB9aqKUqvF", null, 1, null, null, "Rosalia14@corpfolder.com", "Rosalia" },
                    { "Araceli.Arriaga44174", null, "Arriaga", "hQM7u8nQhX", null, 1, null, null, "Araceli93@hotmail.com", "Araceli" },
                    { "Cesar62173", null, "Zelaya", "QBuQbzEZp9", null, 1, null, null, "Cesar_Zelaya@hotmail.com", "César" },
                    { "Angela.Villareal157", null, "Villareal", "tVoVHZUj_7", null, 1, null, null, "Angela_Villareal@nearbpo.com", "Ángela" },
                    { "Magdalena_Chavarria81158", null, "Chavarría", "k7WdwZI2XE", null, 1, null, null, "Magdalena.Chavarria@nearbpo.com", "Magdalena" },
                    { "Emilio.Marin75159", null, "Marín", "F79Ivpn5_i", null, 1, null, null, "Emilio_Marin73@corpfolder.com", "Emilio" },
                    { "Elsa.Lugo160", null, "Lugo", "C2KGhP0Z_A", null, 1, null, null, "Elsa.Lugo@corpfolder.com", "Elsa" },
                    { "Estela34161", null, "Esquivel", "ZSClPkZB4_", null, 1, null, null, "Estela.Esquivel@nearbpo.com", "Estela" },
                    { "Melissa.Kamal34162", null, "Kamal", "ldXjrHYa_U", null, 1, null, null, "Melissa32@nearbpo.com", "Melissa" },
                    { "Teodoro.Naranjo163", null, "Naranjo", "RTD8wzuLaU", null, 1, null, null, "Teodoro.Naranjo@yahoo.com", "Teodoro" },
                    { "Dolores.Rangel45192", null, "Rangel", "LwsCoRYETR", null, 1, null, null, "Dolores15@hotmail.com", "Dolores" },
                    { "JuanCarlos_Cedillo56164", null, "Cedillo", "j5Z3nvB904", null, 1, null, null, "JuanCarlos.Cedillo42@yahoo.com", "Juan Carlos" },
                    { "Martin60166", null, "Reséndez", "2b5moRaMuZ", null, 1, null, null, "Martin29@hotmail.com", "Martín" },
                    { "Lucia.Cisneros167", null, "Cisneros", "m4u0SGfu6X", null, 1, null, null, "Lucia3@gmail.com", "Lucia" },
                    { "Yolanda55168", null, "Cortez", "e0KqsM3vQA", null, 1, null, null, "Yolanda.Cortez99@nearbpo.com", "Yolanda" },
                    { "Federico_Aranda169", null, "Aranda", "2NzfW8t5En", null, 1, null, null, "Federico.Aranda@nearbpo.com", "Federico" },
                    { "JoseMaria27170", null, "Abeyta", "gXi3rvedlt", null, 1, null, null, "JoseMaria.Abeyta19@nearbpo.com", "José María" },
                    { "Ximena_Saldana8171", null, "Saldaña", "jvzMIuZDYh", null, 1, null, null, "Ximena.Saldana@yahoo.com", "Ximena" },
                    { "Emilio55172", null, "Duarte", "PYqymp7RpW", null, 1, null, null, "Emilio46@gmail.com", "Emilio" },
                    { "Carolina.Collazo46165", null, "Collazo", "gRXrn0MGjt", null, 1, null, null, "Carolina_Collazo@nearbpo.com", "Carolina" },
                    { "Ivanna.Zambrana193", null, "Zambrana", "PYHdxKktsw", null, 1, null, null, "Ivanna.Zambrana@nearbpo.com", "Ivanna" },
                    { "Emilio.Carrion194", null, "Carrion", "k3pyCNF99V", null, 1, null, null, "Emilio.Carrion67@gmail.com", "Emilio" },
                    { "Emiliano_Munguia32195", null, "Munguía", "E39U8IbdZq", null, 1, null, null, "Emiliano_Munguia49@hotmail.com", "Emiliano" },
                    { "Ernesto.Benavides216", null, "Benavides", "WAK0OWOTKU", null, 1, null, null, "Ernesto_Benavides@yahoo.com", "Ernesto" },
                    { "Lucas49217", null, "Gil", "rP7Wj4gMAE", null, 1, null, null, "Lucas74@gmail.com", "Lucas" },
                    { "Sergio54218", null, "Mascareñas", "bTa1zn4SMy", null, 1, null, null, "Sergio92@yahoo.com", "Sergio" },
                    { "Ximena_Vela219", null, "Vela", "7cTndRx3Wc", null, 1, null, null, "Ximena82@corpfolder.com", "Ximena" },
                    { "Monserrat_Sanches220", null, "Sanches", "BE8RyysKJY", null, 1, null, null, "Monserrat60@hotmail.com", "Monserrat" },
                    { "Elvira.Alonso221", null, "Alonso", "8aKtMnRC63", null, 1, null, null, "Elvira_Alonso@gmail.com", "Elvira" },
                    { "Homero_Sanchez222", null, "Sánchez", "9ZxUpBa5YM", null, 1, null, null, "Homero_Sanchez@gmail.com", "Homero" },
                    { "Sonia.Rios215", null, "Ríos", "iDccpcc2o7", null, 1, null, null, "Sonia9@corpfolder.com", "Sonia" },
                    { "David.Briseno223", null, "Briseño", "BUoD_LlDCU", null, 1, null, null, "David.Briseno@gmail.com", "David" },
                    { "Dolores62225", null, "Rodríguez", "oqz3gB_pVA", null, 1, null, null, "Dolores89@yahoo.com", "Dolores" },
                    { "Sofia32226", null, "Rivera", "6Wi7fjRpOq", null, 1, null, null, "Sofia_Rivera@corpfolder.com", "Sofia" },
                    { "Emily_Colunga9227", null, "Colunga", "xB1f6pa9cL", null, 1, null, null, "Emily.Colunga@gmail.com", "Emily" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Paola13228", null, "Gil", "KXmb6qhtTJ", null, 1, null, null, "Paola71@corpfolder.com", "Paola" },
                    { "Cristina_Rosario229", null, "Rosario", "9E_Zpe2CDQ", null, 1, null, null, "Cristina68@yahoo.com", "Cristina" },
                    { "Aaron_Nieves230", null, "Nieves", "WO7HIo1R6m", null, 1, null, null, "Aaron.Nieves68@corpfolder.com", "Aarón" },
                    { "Estefania48231", null, "Saavedra", "UgbgILPNdy", null, 1, null, null, "Estefania.Saavedra@hotmail.com", "Estefanía" },
                    { "Gustavo_Delarosa224", null, "Delarosa", "geSlXojjyR", null, 1, null, null, "Gustavo.Delarosa@corpfolder.com", "Gustavo" },
                    { "JuanPablo.Benavides622", null, "Benavides", "CBCfZcYFCI", null, 1, null, null, "JuanPablo19@gmail.com", "Juan Pablo" },
                    { "MariadeJesus54214", null, "Mendoza", "x0YC3i5jxs", null, 1, null, null, "MariadeJesus14@nearbpo.com", "María de Jesús" },
                    { "Evelyn_Nevarez212", null, "Nevárez", "NBVxyegBHh", null, 1, null, null, "Evelyn.Nevarez62@corpfolder.com", "Evelyn" },
                    { "Yamileth4196", null, "Partida", "Tx5PQvfQUm", null, 1, null, null, "Yamileth_Partida@hotmail.com", "Yamileth" },
                    { "Paulina.Melgar92197", null, "Melgar", "xGr8CMT8UK", null, 1, null, null, "Paulina.Melgar82@nearbpo.com", "Paulina" },
                    { "Gabriel_Jasso198", null, "Jasso", "f7bW1kU6eN", null, 1, null, null, "Gabriel.Jasso@gmail.com", "Gabriel" },
                    { "Silvia.Nevarez199", null, "Nevárez", "AMNFETbejX", null, 1, null, null, "Silvia5@corpfolder.com", "Silvia" },
                    { "Alejandro.Nino35200", null, "Niño", "Hb0IxX5M9B", null, 1, null, null, "Alejandro.Nino2@yahoo.com", "Alejandro" },
                    { "Esperanza.Arreola9201", null, "Arreola", "YFj8Za8HBP", null, 1, null, null, "Esperanza.Arreola79@gmail.com", "Esperanza" },
                    { "Emiliano_Tovar16202", null, "Tovar", "L8P6HRv9y6", null, 1, null, null, "Emiliano.Tovar95@corpfolder.com", "Emiliano" },
                    { "Lucia_Kortahernandez88213", null, "Korta hernandez", "9W1ei9fL14", null, 1, null, null, "Lucia.Kortahernandez@gmail.com", "Lucia" },
                    { "Debora_Alaniz91203", null, "Alaniz", "vpM2Ix5kzo", null, 1, null, null, "Debora90@yahoo.com", "Débora" },
                    { "Ramiro.Vigil205", null, "Vigil", "EHrfafNEXr", null, 1, null, null, "Ramiro_Vigil@hotmail.com", "Ramiro" },
                    { "Arturo.Miranda206", null, "Miranda", "y_t7YG8ANu", null, 1, null, null, "Arturo_Miranda63@gmail.com", "Arturo" },
                    { "Alfredo88207", null, "Chávez", "QLALwtYjx8", null, 1, null, null, "Alfredo_Chavez@corpfolder.com", "Alfredo" },
                    { "Homero83208", null, "Loya", "6C5BrMTSiC", null, 1, null, null, "Homero22@yahoo.com", "Homero" },
                    { "Mercedes4209", null, "Rosario", "7zaGA2sz7N", null, 1, null, null, "Mercedes10@corpfolder.com", "Mercedes" },
                    { "Miranda.Montoya210", null, "Montoya", "JH6dKLUR4q", null, 1, null, null, "Miranda_Montoya66@nearbpo.com", "Miranda" },
                    { "Jennifer68211", null, "Ávila", "x_ajRKJncb", null, 1, null, null, "Jennifer79@corpfolder.com", "Jennifer" },
                    { "Erick40204", null, "Bustamante", "iGKsvrMO3Y", null, 1, null, null, "Erick_Bustamante@corpfolder.com", "Erick" },
                    { "Luis77623", null, "Lucero", "LNnkweSLpV", null, 1, null, null, "Luis.Lucero@hotmail.com", "Luis" },
                    { "Estela2624", null, "Magaña", "gZWN64Awsn", null, 1, null, null, "Estela38@corpfolder.com", "Estela" },
                    { "Teresa_Preciado625", null, "Preciado", "TSTdrcpgmf", null, 1, null, null, "Teresa19@hotmail.com", "Teresa" },
                    { "Isabela.Carrillo1037", null, "Carrillo", "Rs5rnNk4_J", null, 1, null, null, "Isabela.Carrillo@nearbpo.com", "Isabela" },
                    { "Francisco381038", null, "Serrano", "W8zXlu3u5X", null, 1, null, null, "Francisco_Serrano31@yahoo.com", "Francisco" },
                    { "Maricarmen161039", null, "Gollum", "7_fGCl9wlD", null, 1, null, null, "Maricarmen_Gollum@yahoo.com", "Maricarmen" },
                    { "Ariadna.Adorno211040", null, "Adorno", "1fEXpbcMeN", null, 1, null, null, "Ariadna90@hotmail.com", "Ariadna" },
                    { "Homero71041", null, "Sevilla", "FMf3GtgLbo", null, 1, null, null, "Homero.Sevilla@corpfolder.com", "Homero" },
                    { "LuisMiguel.Delagarza1042", null, "Delagarza", "mwXZKKwBXy", null, 1, null, null, "LuisMiguel_Delagarza36@nearbpo.com", "Luis Miguel" },
                    { "Pilar_Kanaria151043", null, "Kanaria", "UkOrfpdoGf", null, 1, null, null, "Pilar.Kanaria51@yahoo.com", "Pilar" },
                    { "Francisco241044", null, "Porras", "afAUKF6KFy", null, 1, null, null, "Francisco.Porras14@nearbpo.com", "Francisco" },
                    { "Elsa_Vallejo591045", null, "Vallejo", "erPlK7RXRc", null, 1, null, null, "Elsa6@yahoo.com", "Elsa" },
                    { "Samuel341046", null, "Zamora", "D6NDrL6rHz", null, 1, null, null, "Samuel16@hotmail.com", "Samuel" },
                    { "Juan_Jaramillo641047", null, "Jaramillo", "bqr50xiZrN", null, 1, null, null, "Juan.Jaramillo@yahoo.com", "Juan" },
                    { "Pedro_Quintairos1048", null, "Quintairos", "2s0WIGa1pD", null, 1, null, null, "Pedro_Quintairos@corpfolder.com", "Pedro" },
                    { "Carlos_Roybal1049", null, "Roybal", "HV9XxIwjXh", null, 1, null, null, "Carlos.Roybal9@yahoo.com", "Carlos" },
                    { "Samuel_Xana281050", null, "Xana", "BxtMGX2w8N", null, 1, null, null, "Samuel75@nearbpo.com", "Samuel" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Monica.Espino831051", null, "Espino", "FocJmTeOak", null, 1, null, null, "Monica.Espino68@gmail.com", "Mónica" },
                    { "Leonor.Godoy1036", null, "Godoy", "vbl7OVsTK8", null, 1, null, null, "Leonor_Godoy@nearbpo.com", "Leonor" },
                    { "Lorena.Kyra301035", null, "Kyra", "jWzPsDTLZW", null, 1, null, null, "Lorena27@gmail.com", "Lorena" },
                    { "Josefina_Olvera371034", null, "Olvera", "D_4bHCf1zn", null, 1, null, null, "Josefina_Olvera@yahoo.com", "Josefina" },
                    { "Bernardo641033", null, "Cervántez", "wml_uQuSum", null, 1, null, null, "Bernardo85@yahoo.com", "Bernardo" },
                    { "Lizbeth.Salazar1017", null, "Salazar", "nVGjGIDz15", null, 1, null, null, "Lizbeth_Salazar33@yahoo.com", "Lizbeth" },
                    { "Jose921018", null, "Sarabia", "lSQAl1Tb7f", null, 1, null, null, "Jose.Sarabia@corpfolder.com", "José" },
                    { "JuanCarlos_Portillo1019", null, "Portillo", "98PPG2v7_g", null, 1, null, null, "JuanCarlos_Portillo@gmail.com", "Juan Carlos" },
                    { "Hernan381020", null, "Merino", "SfKoOu9g1a", null, 1, null, null, "Hernan_Merino@yahoo.com", "Hernán" },
                    { "Jeronimo.Karen331021", null, "Karen", "OHcOQNYmuh", null, 1, null, null, "Jeronimo.Karen@gmail.com", "Jerónimo" },
                    { "Clara_Segura1022", null, "Segura", "TBPfZoi2G0", null, 1, null, null, "Clara54@corpfolder.com", "Clara" },
                    { "LuisFernando.Fernandez11023", null, "Fernández", "exaZDJDzWQ", null, 1, null, null, "LuisFernando36@yahoo.com", "Luis Fernando" },
                    { "Benjamin_Espinal1052", null, "Espinal", "_Px2Pjjr7M", null, 1, null, null, "Benjamin.Espinal@nearbpo.com", "Benjamín" },
                    { "Adan_Razo851024", null, "Razo", "_6YxR6Gn5D", null, 1, null, null, "Adan57@corpfolder.com", "Adán" },
                    { "Ricardo.Aguilar1026", null, "Águilar", "L1ZhX2tJ2x", null, 1, null, null, "Ricardo85@yahoo.com", "Ricardo" },
                    { "Concepcion701027", null, "Olivas", "1b81S8Nt1S", null, 1, null, null, "Concepcion_Olivas@corpfolder.com", "Concepción" },
                    { "Mariana.Esquivel901028", null, "Esquivel", "upDBJ2NixI", null, 1, null, null, "Mariana94@yahoo.com", "Mariana" },
                    { "Lucia_Amador551029", null, "Amador", "yVPY1ljrGa", null, 1, null, null, "Lucia_Amador1@yahoo.com", "Lucia" },
                    { "Raquel241030", null, "Peres", "14qaDVPJUx", null, 1, null, null, "Raquel.Peres@corpfolder.com", "Raquel" },
                    { "Paola_Delgadillo201031", null, "Delgadillo", "IxVSFQhbiO", null, 1, null, null, "Paola.Delgadillo@yahoo.com", "Paola" },
                    { "Alexander.Kanzaki1032", null, "Kanzaki", "lgMT3mMhkY", null, 1, null, null, "Alexander46@yahoo.com", "Alexander" },
                    { "Leticia.Avila1025", null, "Ávila", "_I9OgjAUzo", null, 1, null, null, "Leticia4@corpfolder.com", "Leticia" },
                    { "Tomas_Serna51016", null, "Serna", "uKIdkGg9jL", null, 1, null, null, "Tomas.Serna34@corpfolder.com", "Tomás" },
                    { "Ramon301053", null, "Verduzco", "qbg9ZIRUti", null, 1, null, null, "Ramon_Verduzco@nearbpo.com", "Ramón" },
                    { "MiguelAngel_Kanea1055", null, "Kanea", "uAHSxTBDCE", null, 1, null, null, "MiguelAngel92@corpfolder.com", "Miguel Ángel" },
                    { "Alfonso_Miranda571076", null, "Miranda", "UjVTUEdNkz", null, 1, null, null, "Alfonso17@hotmail.com", "Alfonso" },
                    { "Reina_Moya1077", null, "Moya", "AdZ012wKx8", null, 1, null, null, "Reina_Moya72@yahoo.com", "Reina" },
                    { "JoseDaniel_Quezada851078", null, "Quezada", "6UsZbMajnr", null, 1, null, null, "JoseDaniel.Quezada7@hotmail.com", "Jose Daniel" },
                    { "Xochitl.Villarreal381079", null, "Villarreal", "qfkwtemf1V", null, 1, null, null, "Xochitl80@corpfolder.com", "Xochitl" },
                    { "Angela.Kara201080", null, "Kara", "KFsDmTmgcf", null, 1, null, null, "Angela.Kara95@hotmail.com", "Ángela" },
                    { "Regina201081", null, "Cantú", "35cB8cSBxb", null, 1, null, null, "Regina_Cantu@corpfolder.com", "Regina" },
                    { "Sara_Montez511082", null, "Montez", "_aF68loCT8", null, 1, null, null, "Sara.Montez65@hotmail.com", "Sara" },
                    { "German_Calvillo661083", null, "Calvillo", "ttDSY4_290", null, 1, null, null, "German_Calvillo54@yahoo.com", "Germán" },
                    { "Rosalia321084", null, "Frías", "mxLj07zr96", null, 1, null, null, "Rosalia_Frias@hotmail.com", "Rosalia" },
                    { "Abraham.Angulo1085", null, "Angulo", "XBZeBdZoih", null, 1, null, null, "Abraham26@corpfolder.com", "Abraham" },
                    { "Nicole231086", null, "Rubio", "B6ylTO4bDb", null, 1, null, null, "Nicole_Rubio26@gmail.com", "Nicole" },
                    { "Kimberly.Meza1087", null, "Meza", "mU14q6VXCd", null, 1, null, null, "Kimberly43@gmail.com", "Kimberly" },
                    { "Santiago_Delapaz1088", null, "Delapaz", "VbXTK1bOpK", null, 1, null, null, "Santiago26@nearbpo.com", "Santiago" },
                    { "Elias_Yanez1089", null, "Yáñez", "QyaINZeprZ", null, 1, null, null, "Elias.Yanez@gmail.com", "Elías" },
                    { "Margarita_Tejada1090", null, "Tejada", "G7wHnbrZWx", null, 1, null, null, "Margarita12@yahoo.com", "Margarita" },
                    { "RosaMaria_Rivas631075", null, "Rivas", "OM4FMG2LnV", null, 1, null, null, "RosaMaria_Rivas@nearbpo.com", "Rosa María" },
                    { "Olivia_Marrero831074", null, "Marrero", "dFXsHM4fDT", null, 1, null, null, "Olivia_Marrero@hotmail.com", "Olivia" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Samuel341073", null, "Navarro", "jyTTbImiPn", null, 1, null, null, "Samuel0@corpfolder.com", "Samuel" },
                    { "Yaretzi.Aguayo1072", null, "Aguayo", "HhmJBWh3jX", null, 1, null, null, "Yaretzi.Aguayo97@nearbpo.com", "Yaretzi" },
                    { "Gilberto401056", null, "Tovar", "AFsphrUCU0", null, 1, null, null, "Gilberto55@nearbpo.com", "Gilberto" },
                    { "Pedro661057", null, "Rojo", "H70vOs2N7Y", null, 1, null, null, "Pedro_Rojo82@hotmail.com", "Pedro" },
                    { "Sancho_Guzman1058", null, "Guzmán", "kafUrQVAK_", null, 1, null, null, "Sancho22@hotmail.com", "Sancho" },
                    { "Erick61059", null, "Montenegro", "tG9IOyyo15", null, 1, null, null, "Erick.Montenegro@yahoo.com", "Erick" },
                    { "Marta.Pichardo1060", null, "Pichardo", "1LLpPSw7uF", null, 1, null, null, "Marta.Pichardo58@nearbpo.com", "Marta" },
                    { "LuisMiguel_Acevedo1061", null, "Acevedo", "MdEpb0hb6m", null, 1, null, null, "LuisMiguel22@gmail.com", "Luis Miguel" },
                    { "Luz981062", null, "Jimínez", "ay0nIaGXpf", null, 1, null, null, "Luz81@hotmail.com", "Luz" },
                    { "LuisFernando_Velasco1054", null, "Velasco", "wNcQr84F36", null, 1, null, null, "LuisFernando.Velasco5@gmail.com", "Luis Fernando" },
                    { "Gilberto.Karen1063", null, "Karen", "w7c2d0HA5s", null, 1, null, null, "Gilberto_Karen95@corpfolder.com", "Gilberto" },
                    { "Ines_Rivera1065", null, "Rivera", "Jmu26kYx32", null, 1, null, null, "Ines_Rivera22@nearbpo.com", "Inés" },
                    { "Leonardo.Espinal441066", null, "Espinal", "uSQYPBvEAg", null, 1, null, null, "Leonardo30@yahoo.com", "Leonardo" },
                    { "Isaac.Kranzsans661067", null, "Kranz sans", "GCKYJHOwTj", null, 1, null, null, "Isaac31@hotmail.com", "Isaac" },
                    { "Kevin.Echevarria431068", null, "Echevarría", "hQJpyxijtJ", null, 1, null, null, "Kevin53@hotmail.com", "Kevin" },
                    { "Alicia_Rendon461069", null, "Rendón", "_jrmsYY7Z_", null, 1, null, null, "Alicia.Rendon83@gmail.com", "Alicia" },
                    { "Blanca.Menendez1070", null, "Menéndez", "o4GRteKoZH", null, 1, null, null, "Blanca_Menendez@corpfolder.com", "Blanca" },
                    { "Gerardo_Esparza441071", null, "Esparza", "7SmrOtzQkv", null, 1, null, null, "Gerardo6@yahoo.com", "Gerardo" },
                    { "Alan_Yami121064", null, "Yami", "Pjg2qfwOB7", null, 1, null, null, "Alan.Yami@nearbpo.com", "Alan" },
                    { "Melany_Muro951091", null, "Muro", "v45h7DiAxQ", null, 1, null, null, "Melany_Muro@gmail.com", "Melany" },
                    { "Francisco.Cotto1015", null, "Cotto", "HHeqO6SdmH", null, 1, null, null, "Francisco_Cotto32@yahoo.com", "Francisco" },
                    { "Jimena_Ferrer1013", null, "Ferrer", "Od_Inm250U", null, 1, null, null, "Jimena_Ferrer22@gmail.com", "Jimena" },
                    { "Florencia_Escalante50959", null, "Escalante", "7xEwdRvZAz", null, 1, null, null, "Florencia_Escalante@corpfolder.com", "Florencia" },
                    { "Luis.Leyva960", null, "Leyva", "tnCluCpO2E", null, 1, null, null, "Luis_Leyva72@nearbpo.com", "Luis" },
                    { "Teresa.Bahena0961", null, "Bahena", "GTYIJ6BwbE", null, 1, null, null, "Teresa.Bahena38@yahoo.com", "Teresa" },
                    { "Pilar_Chapa962", null, "Chapa", "hpgvFFHpGg", null, 1, null, null, "Pilar75@nearbpo.com", "Pilar" },
                    { "Aaron.Vanegas28963", null, "Vanegas", "rF9oLcKL5w", null, 1, null, null, "Aaron.Vanegas31@nearbpo.com", "Aarón" },
                    { "Guadalupe_Melgar964", null, "Melgar", "qXnYwjbyj9", null, 1, null, null, "Guadalupe2@nearbpo.com", "Guadalupe" },
                    { "Veronica_Toro965", null, "Toro", "bFIDyRvNQJ", null, 1, null, null, "Veronica_Toro@corpfolder.com", "Verónica" },
                    { "Leonor.Agosto23966", null, "Agosto", "aFzf1s8m7H", null, 1, null, null, "Leonor.Agosto@hotmail.com", "Leonor" },
                    { "Isaac84967", null, "Torres", "JcSn1rUtad", null, 1, null, null, "Isaac.Torres@hotmail.com", "Isaac" },
                    { "Patricio_Preciado968", null, "Preciado", "yZmcGWWUbr", null, 1, null, null, "Patricio_Preciado@corpfolder.com", "Patricio" },
                    { "Adriana_Escobar969", null, "Escobar", "sZo2BRPOqy", null, 1, null, null, "Adriana90@corpfolder.com", "Adriana" },
                    { "Elizabeth_Koenig83970", null, "Koenig", "WQ15GieaJ_", null, 1, null, null, "Elizabeth.Koenig97@nearbpo.com", "Elizabeth" },
                    { "Matias.Bahena971", null, "Bahena", "S4_pwspiHX", null, 1, null, null, "Matias_Bahena@gmail.com", "Matías" },
                    { "Josefina.Covarrubias37972", null, "Covarrubias", "ih6AFHj3tf", null, 1, null, null, "Josefina27@yahoo.com", "Josefina" },
                    { "DulceMaria.Godinez36973", null, "Godínez", "zbpgi9UNC7", null, 1, null, null, "DulceMaria.Godinez@yahoo.com", "Dulce María" },
                    { "Jazmin_Flores92958", null, "Flores", "7oTFoOK9xY", null, 1, null, null, "Jazmin29@nearbpo.com", "Jazmin" },
                    { "Ines_Riojas83957", null, "Riojas", "XD5Mhu6cuj", null, 1, null, null, "Ines.Riojas69@gmail.com", "Inés" },
                    { "Adriana.Urena956", null, "Ureña", "Rw5OInki_e", null, 1, null, null, "Adriana.Urena79@gmail.com", "Adriana" },
                    { "Francisco_Lomeli45955", null, "Lomeli", "wFwlgoITxF", null, 1, null, null, "Francisco.Lomeli68@gmail.com", "Francisco" },
                    { "Jennifer_Regalado939", null, "Regalado", "khP1Qe53s6", null, 1, null, null, "Jennifer_Regalado48@yahoo.com", "Jennifer" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Carlos35940", null, "Sarabia", "Zqg5LdhER5", null, 1, null, null, "Carlos28@gmail.com", "Carlos" },
                    { "Dorotea.Amador941", null, "Amador", "bP2JoNPbuN", null, 1, null, null, "Dorotea58@gmail.com", "Dorotea" },
                    { "Marta71942", null, "Angulo", "mAUq8iq3Y2", null, 1, null, null, "Marta_Angulo46@gmail.com", "Marta" },
                    { "Elvira52943", null, "Camacho", "QtHsjXrazJ", null, 1, null, null, "Elvira_Camacho2@nearbpo.com", "Elvira" },
                    { "Daniela_Caraballo62944", null, "Caraballo", "rT2SvWR0e8", null, 1, null, null, "Daniela_Caraballo88@yahoo.com", "Daniela" },
                    { "Cesar24945", null, "Kanzaki", "OcAxcV3Z9r", null, 1, null, null, "Cesar20@gmail.com", "César" },
                    { "Isaias_Corrales89974", null, "Corrales", "R9m4ROMVk5", null, 1, null, null, "Isaias.Corrales4@corpfolder.com", "Isaias" },
                    { "Magdalena.Madera95946", null, "Madera", "cJGj1HXsLB", null, 1, null, null, "Magdalena_Madera@yahoo.com", "Magdalena" },
                    { "Carla73948", null, "de Jesús", "ZWlUgzflZA", null, 1, null, null, "Carla.deJesus14@corpfolder.com", "Carla" },
                    { "Luz.Guzman22949", null, "Guzmán", "Z5SsDSSFEy", null, 1, null, null, "Luz67@nearbpo.com", "Luz" },
                    { "Ramon_Carrera57950", null, "Carrera", "D3WGxUyT1i", null, 1, null, null, "Ramon47@nearbpo.com", "Ramón" },
                    { "Alexa.Porras35951", null, "Porras", "QQ9nR4JuxO", null, 1, null, null, "Alexa.Porras@hotmail.com", "Alexa" },
                    { "Guillermo4952", null, "Haro", "Y5QMqT55qG", null, 1, null, null, "Guillermo_Haro7@yahoo.com", "Guillermo" },
                    { "Arturo_Patino953", null, "Patiño", "hwFcCPWr6J", null, 1, null, null, "Arturo3@nearbpo.com", "Arturo" },
                    { "Antonia_Cortes45954", null, "Cortés", "AK4_IPkDym", null, 1, null, null, "Antonia4@gmail.com", "Antonia" },
                    { "XimenaGuadalupe92947", null, "Sierra", "ZYmVf38kFv", null, 1, null, null, "XimenaGuadalupe_Sierra@gmail.com", "Ximena Guadalupe" },
                    { "LuisMiguel_Aviles1014", null, "Avilés", "Vf1bC01J1v", null, 1, null, null, "LuisMiguel.Aviles@yahoo.com", "Luis Miguel" },
                    { "Jose.Quinonez63975", null, "Quiñónez", "c4zzwJ_71V", null, 1, null, null, "Jose_Quinonez@corpfolder.com", "José" },
                    { "MariaTeresa.Prado977", null, "Prado", "5WwMbVpiqq", null, 1, null, null, "MariaTeresa.Prado@corpfolder.com", "María Teresa" },
                    { "FernandoJavier.Benavidez47998", null, "Benavídez", "DACe9uYVl0", null, 1, null, null, "FernandoJavier_Benavidez@gmail.com", "Fernando Javier" },
                    { "Lorenzo87999", null, "Paredes", "LNN4OCZBn2", null, 1, null, null, "Lorenzo_Paredes@yahoo.com", "Lorenzo" },
                    { "Paulina_Banda641000", null, "Banda", "WWlRC8iNoK", null, 1, null, null, "Paulina21@yahoo.com", "Paulina" },
                    { "Alberto451001", null, "Ramón", "2MiQp0hIvt", null, 1, null, null, "Alberto_Ramon11@nearbpo.com", "Alberto" },
                    { "Jimena.Barreto1002", null, "Barreto", "haqHL9GNvy", null, 1, null, null, "Jimena79@hotmail.com", "Jimena" },
                    { "Elena_Matias461003", null, "Matías", "t0AZmNWySu", null, 1, null, null, "Elena7@nearbpo.com", "Elena" },
                    { "Gilberto.Sanches951004", null, "Sanches", "XOA9mrfJ6E", null, 1, null, null, "Gilberto.Sanches@nearbpo.com", "Gilberto" },
                    { "Elvira.Mejia1005", null, "Mejía", "tsXfXsK9ND", null, 1, null, null, "Elvira92@gmail.com", "Elvira" },
                    { "Claudia791006", null, "Samaniego", "VyHDyAb16h", null, 1, null, null, "Claudia_Samaniego85@corpfolder.com", "Claudia" },
                    { "Carmen701007", null, "Pérez", "rv3l1DKjkb", null, 1, null, null, "Carmen40@gmail.com", "Carmen" },
                    { "Isaias_Badillo1008", null, "Badillo", "j3UnbP1zQ3", null, 1, null, null, "Isaias13@nearbpo.com", "Isaias" },
                    { "Monserrat.Feliciano741009", null, "Feliciano", "dcnahh1Gn2", null, 1, null, null, "Monserrat.Feliciano60@nearbpo.com", "Monserrat" },
                    { "Alfonso721010", null, "Bustamante", "MrnJRD18g6", null, 1, null, null, "Alfonso.Bustamante46@nearbpo.com", "Alfonso" },
                    { "Daniela.Roybal81011", null, "Roybal", "kKYVh_QnKy", null, 1, null, null, "Daniela_Roybal@yahoo.com", "Daniela" },
                    { "Benjamin.Rosado101012", null, "Rosado", "lptNeC5EQs", null, 1, null, null, "Benjamin67@gmail.com", "Benjamín" },
                    { "Esteban_Bahena33997", null, "Bahena", "kv3JoKzog8", null, 1, null, null, "Esteban_Bahena@yahoo.com", "Esteban" },
                    { "Norma_Granado82996", null, "Granado", "5NzbzjKZ4W", null, 1, null, null, "Norma.Granado@gmail.com", "Norma" },
                    { "Eloisa_Muniz46995", null, "Muñiz", "cow3xWDHYU", null, 1, null, null, "Eloisa.Muniz@hotmail.com", "Eloisa" },
                    { "Josefina.Matos994", null, "Matos", "XUVVwlKz7a", null, 1, null, null, "Josefina_Matos@gmail.com", "Josefina" },
                    { "Pedro.Polanco5978", null, "Polanco", "ISIlb9tjrY", null, 1, null, null, "Pedro.Polanco@corpfolder.com", "Pedro" },
                    { "Valentina_Robles979", null, "Robles", "RmaHpC66mr", null, 1, null, null, "Valentina51@nearbpo.com", "Valentina" },
                    { "AngelDaniel_Otero58980", null, "Otero", "8FxIFaregT", null, 1, null, null, "AngelDaniel95@nearbpo.com", "Ángel Daniel" },
                    { "Naomi.Ontiveros77981", null, "Ontiveros", "jebidp61na", null, 1, null, null, "Naomi_Ontiveros@hotmail.com", "Naomi" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Daniel.Munoz982", null, "Muñoz", "SB2WuEey0R", null, 1, null, null, "Daniel_Munoz@nearbpo.com", "Daniel" },
                    { "Oscar.Montenegro983", null, "Montenegro", "EuJA5UPDXQ", null, 1, null, null, "Oscar_Montenegro43@yahoo.com", "Óscar" },
                    { "Samuel.Saavedra984", null, "Saavedra", "QA6uZOUlMG", null, 1, null, null, "Samuel.Saavedra1@nearbpo.com", "Samuel" },
                    { "Estela.Delao976", null, "Delao", "C0YWAJV4WT", null, 1, null, null, "Estela_Delao13@corpfolder.com", "Estela" },
                    { "Teresa_Viera985", null, "Viera", "1sijyM3308", null, 1, null, null, "Teresa_Viera@nearbpo.com", "Teresa" },
                    { "Esteban.Escalante987", null, "Escalante", "ir2iejE_eX", null, 1, null, null, "Esteban_Escalante@hotmail.com", "Esteban" },
                    { "Ximena_Arce988", null, "Arce", "7_2sHdNdx8", null, 1, null, null, "Ximena.Arce88@hotmail.com", "Ximena" },
                    { "Homero_Cadena97989", null, "Cadena", "rGMAH86Y8p", null, 1, null, null, "Homero_Cadena8@gmail.com", "Homero" },
                    { "Benito61990", null, "Mota", "LEn5reIh2l", null, 1, null, null, "Benito_Mota94@nearbpo.com", "Benito" },
                    { "Oscar_Correa99991", null, "Correa", "UyjsNwEHsB", null, 1, null, null, "Oscar8@hotmail.com", "Óscar" },
                    { "Santiago.Chapa992", null, "Chapa", "rVZDgnJPIk", null, 1, null, null, "Santiago_Chapa@hotmail.com", "Santiago" },
                    { "Yolanda.Verdugo993", null, "Verdugo", "63eM6Np3sG", null, 1, null, null, "Yolanda_Verdugo@hotmail.com", "Yolanda" },
                    { "Cristobal_Navarrete23986", null, "Navarrete", "QjIrmX7VJz", null, 1, null, null, "Cristobal_Navarrete68@nearbpo.com", "Cristobal" },
                    { "Marilu_Ballesteros761092", null, "Ballesteros", "5x0Qf325V9", null, 1, null, null, "Marilu_Ballesteros@gmail.com", "Marilu" },
                    { "Laura491093", null, "Iglesias", "scTd0F6ueN", null, 1, null, null, "Laura18@gmail.com", "Laura" },
                    { "Rosalia711094", null, "Delgadillo", "NYCIF7ruVV", null, 1, null, null, "Rosalia.Delgadillo51@gmail.com", "Rosalia" },
                    { "Marcela771194", null, "Ballesteros", "TLxDmmEuHf", null, 1, null, null, "Marcela80@corpfolder.com", "Marcela" },
                    { "Daniel.Gurule311195", null, "Gurule", "Yrb3dmKO4b", null, 1, null, null, "Daniel48@yahoo.com", "Daniel" },
                    { "Elena561196", null, "Gaona", "uWDPBYBDzN", null, 1, null, null, "Elena.Gaona@hotmail.com", "Elena" },
                    { "Jacobo.Karan1197", null, "Karan", "WJO3E0g7Us", null, 1, null, null, "Jacobo_Karan61@hotmail.com", "Jacobo" },
                    { "Xochitl.Barreto351198", null, "Barreto", "_H7WnDF420", null, 1, null, null, "Xochitl85@nearbpo.com", "Xochitl" },
                    { "Pedro.Navarro1199", null, "Navarro", "NhHsN3hZSU", null, 1, null, null, "Pedro16@hotmail.com", "Pedro" },
                    { "Axel_Lara811200", null, "Lara", "BdFZwWpL6Q", null, 1, null, null, "Axel_Lara@yahoo.com", "Axel" },
                    { "Benjamin861201", null, "Xacon", "RQnTvSinrY", null, 1, null, null, "Benjamin_Xacon@hotmail.com", "Benjamín" },
                    { "Daniel.Aparicio161202", null, "Aparicio", "KwPZulQmPo", null, 1, null, null, "Daniel.Aparicio@gmail.com", "Daniel" },
                    { "Micaela_Gil711203", null, "Gil", "CvuVBJCpaY", null, 1, null, null, "Micaela_Gil64@yahoo.com", "Micaela" },
                    { "Octavio_Figueroa391204", null, "Figueroa", "AkX5x95spG", null, 1, null, null, "Octavio.Figueroa2@corpfolder.com", "Octavio" },
                    { "Beatriz31205", null, "Venegas", "wAm5EKyLZC", null, 1, null, null, "Beatriz33@nearbpo.com", "Beatriz" },
                    { "Luisa.Ceballos1206", null, "Ceballos", "2qDQkZS_2n", null, 1, null, null, "Luisa.Ceballos@yahoo.com", "Luisa" },
                    { "Natalia_Abrego151207", null, "Abrego", "cztvwaniRL", null, 1, null, null, "Natalia.Abrego@corpfolder.com", "Natalia" },
                    { "Pilar.Maldonado331208", null, "Maldonado", "OgyxZ7LrsP", null, 1, null, null, "Pilar.Maldonado60@corpfolder.com", "Pilar" },
                    { "Rebeca881193", null, "Hernandes", "iPQTr8NHPj", null, 1, null, null, "Rebeca.Hernandes@hotmail.com", "Rebeca" },
                    { "Ivanna_Zayas681192", null, "Zayas", "1278Gv6VZD", null, 1, null, null, "Ivanna_Zayas34@gmail.com", "Ivanna" },
                    { "Sancho331191", null, "Espinosa", "nYlyBVa4Cj", null, 1, null, null, "Sancho_Espinosa@hotmail.com", "Sancho" },
                    { "Vanessa671190", null, "Benítez", "UYXl2iK9xy", null, 1, null, null, "Vanessa56@nearbpo.com", "Vanessa" },
                    { "Brayan601174", null, "Candelaria", "3QI40OygrK", null, 1, null, null, "Brayan_Candelaria34@hotmail.com", "Brayan" },
                    { "Ariadna_Arredondo1175", null, "Arredondo", "Y8fCVDQzZZ", null, 1, null, null, "Ariadna.Arredondo@nearbpo.com", "Ariadna" },
                    { "Olivia91176", null, "Maldonado", "3YbKxFgiVh", null, 1, null, null, "Olivia11@nearbpo.com", "Olivia" },
                    { "Julio501177", null, "Orta", "IEzEsYzZ6A", null, 1, null, null, "Julio_Orta@corpfolder.com", "Julio" },
                    { "Caridad.Alaniz1178", null, "Alaniz", "hAwML04FWC", null, 1, null, null, "Caridad_Alaniz@nearbpo.com", "Caridad" },
                    { "Felipe331179", null, "Guevara", "ZMC8sME1jE", null, 1, null, null, "Felipe29@hotmail.com", "Felipe" },
                    { "Sonia701180", null, "Prieto", "2GCptf1qky", null, 1, null, null, "Sonia39@gmail.com", "Sonia" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Abigail_Esparza1209", null, "Esparza", "6SYyf6Xxsm", null, 1, null, null, "Abigail_Esparza16@corpfolder.com", "Abigail" },
                    { "Federico_Agosto461181", null, "Agosto", "YgPhWIIiQK", null, 1, null, null, "Federico.Agosto17@hotmail.com", "Federico" },
                    { "Alejandra771183", null, "Velázquez", "XHcmvPGahs", null, 1, null, null, "Alejandra.Velazquez66@gmail.com", "Alejandra" },
                    { "Estela_Puga851184", null, "Puga", "tyDW4Mc8Zu", null, 1, null, null, "Estela.Puga@yahoo.com", "Estela" },
                    { "David.Canales1185", null, "Canales", "Zk4sksimTc", null, 1, null, null, "David93@yahoo.com", "David" },
                    { "Angela_Parra201186", null, "Parra", "0dz8Kkxpz6", null, 1, null, null, "Angela.Parra@corpfolder.com", "Ángela" },
                    { "Sofia_Luevano1187", null, "Luevano", "JOQvGHEnPl", null, 1, null, null, "Sofia93@yahoo.com", "Sofia" },
                    { "Leticia.Kaplan1188", null, "Kaplan", "btMcgIyby6", null, 1, null, null, "Leticia.Kaplan62@gmail.com", "Leticia" },
                    { "Emily141189", null, "Montaño", "tjhDczUl8J", null, 1, null, null, "Emily.Montano79@hotmail.com", "Emily" },
                    { "JoseAntonio751182", null, "Salas", "mIShzbNFx_", null, 1, null, null, "JoseAntonio32@nearbpo.com", "José Antonio" },
                    { "Uriel.Miramontes301173", null, "Miramontes", "UjvnzllIpr", null, 1, null, null, "Uriel.Miramontes50@corpfolder.com", "Uriel" },
                    { "MariaJose_Garcia1210", null, "García", "wSFGYbP90s", null, 1, null, null, "MariaJose84@hotmail.com", "María José" },
                    { "Israel771212", null, "Hidalgo", "JS8GZpHRkG", null, 1, null, null, "Israel_Hidalgo@hotmail.com", "Israel" },
                    { "Lorena.Nava1233", null, "Nava", "yx2YfR98RA", null, 1, null, null, "Lorena_Nava@nearbpo.com", "Lorena" },
                    { "Ramiro981234", null, "Jiménez", "_Q_qcWCeqe", null, 1, null, null, "Ramiro.Jimenez@corpfolder.com", "Ramiro" },
                    { "Isaac811235", null, "Nájera", "DzGQ4Uyh8A", null, 1, null, null, "Isaac97@hotmail.com", "Isaac" },
                    { "Alexander_Villagomez221236", null, "Villagómez", "2LHdEbckJX", null, 1, null, null, "Alexander79@nearbpo.com", "Alexander" },
                    { "Liliana.Gamez621237", null, "Gamez", "p9xZBu4vGx", null, 1, null, null, "Liliana.Gamez@yahoo.com", "Liliana" },
                    { "Gustavo161238", null, "Navarro", "mKuHSmw0r5", null, 1, null, null, "Gustavo0@hotmail.com", "Gustavo" },
                    { "MariaJose791239", null, "Noriega", "y3qis_ffF3", null, 1, null, null, "MariaJose_Noriega@nearbpo.com", "María José" },
                    { "Armando.Meza951240", null, "Meza", "SB22VJPEPK", null, 1, null, null, "Armando_Meza98@hotmail.com", "Armando" },
                    { "Paola_Medina1241", null, "Medina", "Fkm_wW3FeF", null, 1, null, null, "Paola80@nearbpo.com", "Paola" },
                    { "Emiliano_Loera841242", null, "Loera", "ufSOAGtpbe", null, 1, null, null, "Emiliano29@hotmail.com", "Emiliano" },
                    { "Lourdes231243", null, "Montenegro", "70iMmfPPp9", null, 1, null, null, "Lourdes98@hotmail.com", "Lourdes" },
                    { "Gerardo_Molina1244", null, "Molina", "IvX21dFJhp", null, 1, null, null, "Gerardo24@hotmail.com", "Gerardo" },
                    { "Alejandro.Munoz1245", null, "Muñoz", "R5AcLKeHgt", null, 1, null, null, "Alejandro_Munoz21@corpfolder.com", "Alejandro" },
                    { "Diana711246", null, "Caraballo", "FPSw2FCIKD", null, 1, null, null, "Diana.Caraballo79@gmail.com", "Diana" },
                    { "Samuel.Olivera711247", null, "Olivera", "rHhgCtmKS8", null, 1, null, null, "Samuel.Olivera1@hotmail.com", "Samuel" },
                    { "Horacio.Delarosa1232", null, "Delarosa", "E_jxmQJsM6", null, 1, null, null, "Horacio51@yahoo.com", "Horacio" },
                    { "Angela.Valentin281231", null, "Valentín", "xrKyer4B36", null, 1, null, null, "Angela65@corpfolder.com", "Ángela" },
                    { "Abraham_Giron271230", null, "Girón", "YMVZM_sEf9", null, 1, null, null, "Abraham_Giron@gmail.com", "Abraham" },
                    { "Melissa_Ayala1229", null, "Ayala", "lgSotf1nTt", null, 1, null, null, "Melissa66@nearbpo.com", "Melissa" },
                    { "Gabriela.Negrete891213", null, "Negrete", "JHzMr7NVUB", null, 1, null, null, "Gabriela_Negrete@gmail.com", "Gabriela" },
                    { "Cristobal_Otero1214", null, "Otero", "9sEjrHER1a", null, 1, null, null, "Cristobal.Otero13@gmail.com", "Cristobal" },
                    { "Nicolas61215", null, "Ibarra", "gwhkWPwH0T", null, 1, null, null, "Nicolas40@gmail.com", "Nicolás" },
                    { "Victoria91216", null, "Ávalos", "TDXnzMBM0m", null, 1, null, null, "Victoria.Avalos@gmail.com", "Victoria" },
                    { "Micaela_Ledesma1217", null, "Ledesma", "zF9jrT2vnF", null, 1, null, null, "Micaela_Ledesma@nearbpo.com", "Micaela" },
                    { "Ester481218", null, "Becerra", "xHBNH6hSOr", null, 1, null, null, "Ester3@nearbpo.com", "Ester" },
                    { "Axel201219", null, "Olvera", "OuxP3_UBSu", null, 1, null, null, "Axel.Olvera@hotmail.com", "Axel" },
                    { "Brayan.Aguirre1211", null, "Aguirre", "vxHelQT3Yo", null, 1, null, null, "Brayan_Aguirre63@yahoo.com", "Brayan" },
                    { "JulioCesar_Kanea1220", null, "Kanea", "Arv_Rx9QI5", null, 1, null, null, "JulioCesar_Kanea@gmail.com", "Julio César" },
                    { "Vicente_Ozuna1222", null, "Ozuna", "4KbfMyEOUo", null, 1, null, null, "Vicente.Ozuna47@gmail.com", "Vicente" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Manuela841223", null, "Sarabia", "LddYyjPoQy", null, 1, null, null, "Manuela_Sarabia36@yahoo.com", "Manuela" },
                    { "Octavio531224", null, "León", "nnwazmepm5", null, 1, null, null, "Octavio14@corpfolder.com", "Octavio" },
                    { "Alejandro_Riojas971225", null, "Riojas", "es0mupAJnc", null, 1, null, null, "Alejandro_Riojas@yahoo.com", "Alejandro" },
                    { "Martin.Montez681226", null, "Montez", "26bi1H0Gyg", null, 1, null, null, "Martin_Montez69@nearbpo.com", "Martín" },
                    { "Alexa971227", null, "Abeyta", "tIqhoAHiRH", null, 1, null, null, "Alexa1@yahoo.com", "Alexa" },
                    { "Mercedes921228", null, "Leal", "D4e6xgyjdv", null, 1, null, null, "Mercedes.Leal@nearbpo.com", "Mercedes" },
                    { "Naomi.Baca1221", null, "Baca", "VR0coHXFqb", null, 1, null, null, "Naomi81@nearbpo.com", "Naomi" },
                    { "Amalia_Ballesteros451172", null, "Ballesteros", "aAkpvzYOcK", null, 1, null, null, "Amalia.Ballesteros@nearbpo.com", "Amalia" },
                    { "Roberto.Esparza1171", null, "Esparza", "SBaIYAzdqt", null, 1, null, null, "Roberto.Esparza@hotmail.com", "Roberto" },
                    { "Alexa_Sierra01170", null, "Sierra", "B_52yAh4Fx", null, 1, null, null, "Alexa9@corpfolder.com", "Alexa" },
                    { "Luis_Ybarra1115", null, "Ybarra", "qL4S4tAXkg", null, 1, null, null, "Luis.Ybarra@nearbpo.com", "Luis" },
                    { "Felipe.Esquibel1116", null, "Esquibel", "_9F4bAjT6B", null, 1, null, null, "Felipe.Esquibel78@hotmail.com", "Felipe" },
                    { "Andrea.Duran821117", null, "Duran", "tQ5N63ST1u", null, 1, null, null, "Andrea.Duran@hotmail.com", "Andrea" },
                    { "Concepcion901118", null, "Montalvo", "72vyiV92of", null, 1, null, null, "Concepcion.Montalvo@gmail.com", "Concepción" },
                    { "Federico.Badillo981119", null, "Badillo", "Cw4Wf64wJE", null, 1, null, null, "Federico_Badillo11@hotmail.com", "Federico" },
                    { "Alejandro.Moreno1120", null, "Moreno", "_FM8lrHPne", null, 1, null, null, "Alejandro.Moreno27@gmail.com", "Alejandro" },
                    { "Vicente.Fajardo1121", null, "Fajardo", "g1fjoE7wHh", null, 1, null, null, "Vicente_Fajardo84@yahoo.com", "Vicente" },
                    { "Nicole261122", null, "Batista", "2Xfo6w5JFB", null, 1, null, null, "Nicole37@hotmail.com", "Nicole" },
                    { "Carlota181123", null, "Haro", "iE5K8CsWPl", null, 1, null, null, "Carlota_Haro2@hotmail.com", "Carlota" },
                    { "Gilberto101124", null, "Valle", "Btxf0v2hqm", null, 1, null, null, "Gilberto_Valle@hotmail.com", "Gilberto" },
                    { "MariaElena_Soto1125", null, "Soto", "9QNyX9AGP0", null, 1, null, null, "MariaElena_Soto16@nearbpo.com", "María Elena" },
                    { "Carmen41126", null, "Marrero", "L4D59GoFYe", null, 1, null, null, "Carmen73@gmail.com", "Carmen" },
                    { "Elisa.Suarez221127", null, "Suárez", "2Q7AFgA7Wt", null, 1, null, null, "Elisa56@hotmail.com", "Elisa" },
                    { "Rodrigo_Alvarado1128", null, "Alvarado", "wkS18Pn8br", null, 1, null, null, "Rodrigo5@hotmail.com", "Rodrigo" },
                    { "JoseDaniel431129", null, "Cervántez", "CsXmHbLLTO", null, 1, null, null, "JoseDaniel_Cervantez@nearbpo.com", "Jose Daniel" },
                    { "Debora901114", null, "Yebra", "QcVObSyUmw", null, 1, null, null, "Debora.Yebra47@gmail.com", "Débora" },
                    { "Gregorio.Castaneda1113", null, "Castañeda", "9qtSpB7ect", null, 1, null, null, "Gregorio66@yahoo.com", "Gregorio" },
                    { "MariaTeresa891112", null, "Ledesma", "7OOFE4ta11", null, 1, null, null, "MariaTeresa.Ledesma@corpfolder.com", "María Teresa" },
                    { "Yaretzi.Negrete381111", null, "Negrete", "8_rq34uaas", null, 1, null, null, "Yaretzi_Negrete@hotmail.com", "Yaretzi" },
                    { "Timoteo.Munoz251095", null, "Muñoz", "YbonV2Acmn", null, 1, null, null, "Timoteo59@gmail.com", "Timoteo" },
                    { "Margarita701096", null, "Valverde", "rdhffVGblF", null, 1, null, null, "Margarita5@nearbpo.com", "Margarita" },
                    { "Patricio.Montemayor1097", null, "Montemayor", "81iOvj6Gph", null, 1, null, null, "Patricio97@yahoo.com", "Patricio" },
                    { "Alfonso_Godinez1098", null, "Godínez", "JqSX2Gsmtu", null, 1, null, null, "Alfonso_Godinez@yahoo.com", "Alfonso" },
                    { "FernandoJavier221099", null, "de Anda", "BuVRlN8YoZ", null, 1, null, null, "FernandoJavier_deAnda44@corpfolder.com", "Fernando Javier" },
                    { "Emilia_Valle1100", null, "Valle", "7QbOjfh3kz", null, 1, null, null, "Emilia_Valle@yahoo.com", "Emilia" },
                    { "Vicente781101", null, "Espinoza", "US_g6cPeN6", null, 1, null, null, "Vicente.Espinoza@nearbpo.com", "Vicente" },
                    { "Adela.Sarabia811130", null, "Sarabia", "AgRjSLWH3v", null, 1, null, null, "Adela95@nearbpo.com", "Adela" },
                    { "Amalia701102", null, "Sauceda", "qFlz5i63xa", null, 1, null, null, "Amalia.Sauceda83@corpfolder.com", "Amalia" },
                    { "Esteban_Tamez1104", null, "Tamez", "RT1L7LExEx", null, 1, null, null, "Esteban.Tamez@corpfolder.com", "Esteban" },
                    { "Ariadna.Ortega41105", null, "Ortega", "YCX7VnH1yg", null, 1, null, null, "Ariadna62@yahoo.com", "Ariadna" },
                    { "Martin_Almanza01106", null, "Almanza", "Dl3BeyKIuy", null, 1, null, null, "Martin92@nearbpo.com", "Martín" },
                    { "Elvira_Munoz501107", null, "Muñoz", "a4ghSMR7Jl", null, 1, null, null, "Elvira_Munoz11@gmail.com", "Elvira" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Florencia.Garica381108", null, "Garica", "lgJpOX9X4Z", null, 1, null, null, "Florencia3@hotmail.com", "Florencia" },
                    { "Sancho_Carmona691109", null, "Carmona", "Yqtmce7zyT", null, 1, null, null, "Sancho.Carmona@hotmail.com", "Sancho" },
                    { "LuisGabino_Nazario881110", null, "Nazario", "YqWxRMgVSd", null, 1, null, null, "LuisGabino_Nazario@yahoo.com", "Luis Gabino" },
                    { "Antonio831103", null, "Khalid", "cKL4o1LVK3", null, 1, null, null, "Antonio_Khalid@hotmail.com", "Antonio" },
                    { "Patricio.Alvarado571131", null, "Alvarado", "mgAO_EqDQo", null, 1, null, null, "Patricio.Alvarado22@yahoo.com", "Patricio" },
                    { "JuanManuel.Olvera1132", null, "Olvera", "zJdUFsy4mL", null, 1, null, null, "JuanManuel_Olvera@yahoo.com", "Juan Manuel" },
                    { "Bernardo.Vargas1133", null, "Vargas", "Fi6NVl1LFz", null, 1, null, null, "Bernardo_Vargas21@corpfolder.com", "Bernardo" },
                    { "Ivan651154", null, "Atencio", "YfnN2XKVaL", null, 1, null, null, "Ivan.Atencio72@nearbpo.com", "Ivan" },
                    { "Catalina_Cruz691155", null, "Cruz", "AFfdwcS3es", null, 1, null, null, "Catalina_Cruz@hotmail.com", "Catalina" },
                    { "Antonio.Montemayor1156", null, "Montemayor", "RsAptqHbI7", null, 1, null, null, "Antonio_Montemayor55@hotmail.com", "Antonio" },
                    { "Ernesto_Vera531157", null, "Vera", "WK132tYOYs", null, 1, null, null, "Ernesto_Vera@corpfolder.com", "Ernesto" },
                    { "Francisco881158", null, "Véliz", "aw2rE05NO9", null, 1, null, null, "Francisco90@gmail.com", "Francisco" },
                    { "Alejandra.Krauelnatera1159", null, "Krauel natera", "e7mkw68kjH", null, 1, null, null, "Alejandra.Krauelnatera76@nearbpo.com", "Alejandra" },
                    { "JuanCarlos_Barrera1160", null, "Barrera", "rww2bFpTAH", null, 1, null, null, "JuanCarlos.Barrera@hotmail.com", "Juan Carlos" },
                    { "Antonia_Rios621153", null, "Ríos", "zqi6xLOdv1", null, 1, null, null, "Antonia23@nearbpo.com", "Antonia" },
                    { "Abril_Sanchez1161", null, "Sánchez", "ZYIBrDpJTz", null, 1, null, null, "Abril24@yahoo.com", "Abril" },
                    { "Graciela.Quintairos1163", null, "Quintairos", "RKctNF3eaF", null, 1, null, null, "Graciela.Quintairos12@corpfolder.com", "Graciela" },
                    { "Silvia231164", null, "Zamora", "s3ft3gU7_s", null, 1, null, null, "Silvia.Zamora83@hotmail.com", "Silvia" },
                    { "Arturo231165", null, "Lozano", "SNbnE5Zno6", null, 1, null, null, "Arturo_Lozano@nearbpo.com", "Arturo" },
                    { "Ivanna841166", null, "Rojo", "fHV_mAoAHf", null, 1, null, null, "Ivanna_Rojo64@hotmail.com", "Ivanna" },
                    { "Pilar371167", null, "Garza", "dWdxE4GE_k", null, 1, null, null, "Pilar.Garza24@nearbpo.com", "Pilar" },
                    { "Bernardo191168", null, "Prado", "2MKdlwXfPO", null, 1, null, null, "Bernardo_Prado@nearbpo.com", "Bernardo" },
                    { "Margarita_Almonte521169", null, "Almonte", "Ghzd10vI6O", null, 1, null, null, "Margarita.Almonte13@gmail.com", "Margarita" },
                    { "Victor.Pacheco771162", null, "Pacheco", "4jKeq8TTDA", null, 1, null, null, "Victor59@hotmail.com", "Víctor" },
                    { "MariaGuadalupe_Dominguez14938", null, "Domínguez", "qascTqHGHt", null, 1, null, null, "MariaGuadalupe.Dominguez98@corpfolder.com", "María Guadalupe" },
                    { "Margarita_Teran371152", null, "Terán", "3kUOY5qJ8V", null, 1, null, null, "Margarita.Teran42@nearbpo.com", "Margarita" },
                    { "Natalia.Benavides1150", null, "Benavides", "lOrPSEAqxl", null, 1, null, null, "Natalia.Benavides@yahoo.com", "Natalia" },
                    { "Teresa.Cortes251134", null, "Cortés", "YbrTRkLXPR", null, 1, null, null, "Teresa_Cortes@corpfolder.com", "Teresa" },
                    { "Ramona561135", null, "Blanco", "_iVKBCECKJ", null, 1, null, null, "Ramona_Blanco22@hotmail.com", "Ramona" },
                    { "Luz_Negron1136", null, "Negrón", "gAht1mMePP", null, 1, null, null, "Luz_Negron@nearbpo.com", "Luz" },
                    { "Sancho_Tafoya1137", null, "Tafoya", "S1TzdpU9bP", null, 1, null, null, "Sancho.Tafoya@gmail.com", "Sancho" },
                    { "MariaElena.Banda1138", null, "Banda", "Yo2tEM8Wj6", null, 1, null, null, "MariaElena.Banda85@yahoo.com", "María Elena" },
                    { "Elena.Beltran291139", null, "Beltrán", "NglwKZ3m_w", null, 1, null, null, "Elena.Beltran@nearbpo.com", "Elena" },
                    { "Manuel_Longoria1140", null, "Longoria", "mIvpyX1Bj2", null, 1, null, null, "Manuel_Longoria64@nearbpo.com", "Manuel" },
                    { "Melany931151", null, "Aguilera", "ZbnwDjBA9t", null, 1, null, null, "Melany_Aguilera@corpfolder.com", "Melany" },
                    { "Elisa841141", null, "Sotelo", "CL7XzXbpit", null, 1, null, null, "Elisa.Sotelo@hotmail.com", "Elisa" },
                    { "Veronica_Gutierrez81143", null, "Gutiérrez", "c53kdMona9", null, 1, null, null, "Veronica.Gutierrez@yahoo.com", "Verónica" },
                    { "Clemente.Xenia731144", null, "Xenia", "iDFfKwyr4C", null, 1, null, null, "Clemente_Xenia54@hotmail.com", "Clemente" },
                    { "Dolores.Corrales1145", null, "Corrales", "_TmDHjGk7c", null, 1, null, null, "Dolores_Corrales1@hotmail.com", "Dolores" },
                    { "MariaTeresa_Granado151146", null, "Granado", "X56ynWaTPy", null, 1, null, null, "MariaTeresa5@nearbpo.com", "María Teresa" },
                    { "Lucas_Karen1147", null, "Karen", "f1fqwIhj_a", null, 1, null, null, "Lucas91@yahoo.com", "Lucas" },
                    { "Rodrigo301148", null, "Carrasco", "A4I_w3TX31", null, 1, null, null, "Rodrigo50@gmail.com", "Rodrigo" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Horacio_Guzman291149", null, "Guzmán", "9K4FZWtcDM", null, 1, null, null, "Horacio.Guzman90@yahoo.com", "Horacio" },
                    { "Ariadna291142", null, "Huerta", "vNrlIOlSaU", null, 1, null, null, "Ariadna18@hotmail.com", "Ariadna" },
                    { "Pilar_Arce2498", null, "Arce", "tQhh0zWfIv", null, 1, null, null, "Pilar_Arce@yahoo.com", "Pilar" },
                    { "AngelGabriel15937", null, "Alvarez", "KOXw26S3Qb", null, 1, null, null, "AngelGabriel3@hotmail.com", "Ángel Gabriel" },
                    { "Antonia.Arana935", null, "Araña", "DKjNV8nsra", null, 1, null, null, "Antonia_Arana98@yahoo.com", "Antonia" },
                    { "Patricio_Ordonez44724", null, "Ordóñez", "9lbTRZ0sEa", null, 1, null, null, "Patricio37@hotmail.com", "Patricio" },
                    { "Graciela_Arevalo725", null, "Arevalo", "9Iu43rkIx9", null, 1, null, null, "Graciela_Arevalo@nearbpo.com", "Graciela" },
                    { "Ivan_Mondragon38726", null, "Mondragón", "ieEQgV5at9", null, 1, null, null, "Ivan6@corpfolder.com", "Ivan" },
                    { "Elena.Valdez727", null, "Valdez", "CJLfKc9kQq", null, 1, null, null, "Elena31@yahoo.com", "Elena" },
                    { "Anita.Verduzco82728", null, "Verduzco", "efGvVavKa2", null, 1, null, null, "Anita.Verduzco@nearbpo.com", "Anita" },
                    { "JoseDaniel70729", null, "Pabón", "tB7Zjegsq6", null, 1, null, null, "JoseDaniel_Pabon@hotmail.com", "Jose Daniel" },
                    { "Isabel_Posada730", null, "Posada", "B4oz8YvVfl", null, 1, null, null, "Isabel_Posada70@yahoo.com", "Isabel" },
                    { "Diana_Velez90731", null, "Vélez", "7mm4Nncyol", null, 1, null, null, "Diana_Velez28@hotmail.com", "Diana" },
                    { "Teodoro.Parra732", null, "Parra", "mN1cpgaqkH", null, 1, null, null, "Teodoro17@hotmail.com", "Teodoro" },
                    { "Elias90733", null, "Huerta", "rlgN1YvtKK", null, 1, null, null, "Elias11@corpfolder.com", "Elías" },
                    { "Mayte_Olivera53734", null, "Olivera", "DpmD9PDgqf", null, 1, null, null, "Mayte.Olivera@yahoo.com", "Mayte" },
                    { "Raul9735", null, "Feliciano", "ZzuUAiwsMc", null, 1, null, null, "Raul67@corpfolder.com", "Raúl" },
                    { "Alberto36736", null, "Padilla", "EdBAtZKt77", null, 1, null, null, "Alberto_Padilla21@gmail.com", "Alberto" },
                    { "Saul.Yami737", null, "Yami", "XeayThqls0", null, 1, null, null, "Saul_Yami@hotmail.com", "Saúl" },
                    { "Jesus_Zayas738", null, "Zayas", "TFGvy2HKha", null, 1, null, null, "Jesus_Zayas51@gmail.com", "Jesús" },
                    { "Eloisa52723", null, "Macías", "YodQSE6QF3", null, 1, null, null, "Eloisa.Macias@corpfolder.com", "Eloisa" },
                    { "Beatriz50722", null, "Amaya", "RiahgLAg6C", null, 1, null, null, "Beatriz.Amaya92@corpfolder.com", "Beatriz" },
                    { "Irene_Gaona41721", null, "Gaona", "0wscNpd3Ld", null, 1, null, null, "Irene_Gaona@hotmail.com", "Irene" },
                    { "Lilia.Vargas90720", null, "Vargas", "n7vrH5BXrA", null, 1, null, null, "Lilia_Vargas62@gmail.com", "Lilia" },
                    { "Emilio13704", null, "Cuellar", "7IxfvEcQlW", null, 1, null, null, "Emilio_Cuellar@yahoo.com", "Emilio" },
                    { "Abril19705", null, "Vergara", "e8ToiKo9tT", null, 1, null, null, "Abril28@hotmail.com", "Abril" },
                    { "Ramiro93706", null, "Palomino", "bIpgtw9xyA", null, 1, null, null, "Ramiro_Palomino90@nearbpo.com", "Ramiro" },
                    { "AnaMaria37707", null, "Magaña", "u7K70722h4", null, 1, null, null, "AnaMaria_Magana76@corpfolder.com", "Ana María" },
                    { "Anita.Ojeda708", null, "Ojeda", "zHBKuRsNly", null, 1, null, null, "Anita_Ojeda33@gmail.com", "Anita" },
                    { "Rosa0709", null, "Chavarría", "eTxJuMA_zF", null, 1, null, null, "Rosa_Chavarria57@hotmail.com", "Rosa" },
                    { "Teodoro_Vera710", null, "Vera", "b9aFGBXpha", null, 1, null, null, "Teodoro31@nearbpo.com", "Teodoro" },
                    { "AngelDaniel_Saiz1739", null, "Saiz", "3LJB11Hk60", null, 1, null, null, "AngelDaniel.Saiz7@nearbpo.com", "Ángel Daniel" },
                    { "JuanPablo.Valenzuela711", null, "Valenzuela", "EpUPH_wJFB", null, 1, null, null, "JuanPablo_Valenzuela@gmail.com", "Juan Pablo" },
                    { "Manuel.Rosales41713", null, "Rosales", "web4PZUD4P", null, 1, null, null, "Manuel_Rosales28@hotmail.com", "Manuel" },
                    { "Andres74714", null, "Villarreal", "kg_wWayli0", null, 1, null, null, "Andres48@corpfolder.com", "Andrés" },
                    { "Horacio.Cavazos82715", null, "Cavazos", "z9YbhaxkVi", null, 1, null, null, "Horacio40@corpfolder.com", "Horacio" },
                    { "Berta70716", null, "Krasnova", "IKnxw5pMsG", null, 1, null, null, "Berta.Krasnova@hotmail.com", "Berta" },
                    { "Gilberto43717", null, "Partida", "hZFdbHn27x", null, 1, null, null, "Gilberto37@gmail.com", "Gilberto" },
                    { "Zoe_Bueno40718", null, "Bueno", "MP462CYODG", null, 1, null, null, "Zoe8@nearbpo.com", "Zoe" },
                    { "Leonor63719", null, "Rolón", "r_5fkSgaAZ", null, 1, null, null, "Leonor67@hotmail.com", "Leonor" },
                    { "Elsa_Pabon47712", null, "Pabón", "uKRTw5wVoo", null, 1, null, null, "Elsa_Pabon56@nearbpo.com", "Elsa" },
                    { "Estefania_Mata3703", null, "Mata", "Jb3WFeBmaP", null, 1, null, null, "Estefania_Mata50@nearbpo.com", "Estefanía" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "JuanCarlos3740", null, "Carbajal", "oC7JZ_zog5", null, 1, null, null, "JuanCarlos.Carbajal52@nearbpo.com", "Juan Carlos" },
                    { "Laura.Moreno17742", null, "Moreno", "23qz7i5IwY", null, 1, null, null, "Laura.Moreno32@hotmail.com", "Laura" },
                    { "Cristina_Tejada763", null, "Tejada", "Kqv7tUfNNz", null, 1, null, null, "Cristina_Tejada@nearbpo.com", "Cristina" },
                    { "Alejandra_Delvalle764", null, "Delvalle", "Qm6ShxPbRZ", null, 1, null, null, "Alejandra_Delvalle@yahoo.com", "Alejandra" },
                    { "Ramiro.Olivo45765", null, "Olivo", "3KD_2B0gzo", null, 1, null, null, "Ramiro_Olivo35@hotmail.com", "Ramiro" },
                    { "Lourdes_Munguia766", null, "Munguía", "3zIfmvQYjf", null, 1, null, null, "Lourdes5@gmail.com", "Lourdes" },
                    { "Esteban23767", null, "Mascareñas", "lVKAIdf5Iy", null, 1, null, null, "Esteban_Mascarenas@corpfolder.com", "Esteban" },
                    { "Jaime.Urias768", null, "Urías", "QajpoIrYHe", null, 1, null, null, "Jaime_Urias76@yahoo.com", "Jaime" },
                    { "Norma_Olivarez769", null, "Olivárez", "D4AVF5YBcy", null, 1, null, null, "Norma85@yahoo.com", "Norma" },
                    { "Carolina91770", null, "Almaraz", "YwEjYCLbYW", null, 1, null, null, "Carolina87@nearbpo.com", "Carolina" },
                    { "Ariadna_Quinones771", null, "Quiñones", "Idq6eU4mS1", null, 1, null, null, "Ariadna46@yahoo.com", "Ariadna" },
                    { "Nicolas78772", null, "Nieves", "yRj34xi0tX", null, 1, null, null, "Nicolas94@corpfolder.com", "Nicolás" },
                    { "Daniela81773", null, "Aponte", "8sLzT4Aj61", null, 1, null, null, "Daniela73@corpfolder.com", "Daniela" },
                    { "Carmen48774", null, "Valdivia", "FyJ7vWSsaQ", null, 1, null, null, "Carmen96@yahoo.com", "Carmen" },
                    { "Ariadna_Cortes775", null, "Cortés", "e9exAJWoPr", null, 1, null, null, "Ariadna.Cortes54@nearbpo.com", "Ariadna" },
                    { "Adan_Cuellar96776", null, "Cuellar", "J_ca7BfTZG", null, 1, null, null, "Adan61@hotmail.com", "Adán" },
                    { "Lorena56777", null, "Partida", "5cn6FqhOm4", null, 1, null, null, "Lorena_Partida@hotmail.com", "Lorena" },
                    { "Rafael28762", null, "Muñiz", "EXtDbH78Kb", null, 1, null, null, "Rafael.Muniz@nearbpo.com", "Rafael" },
                    { "Eva_Calderon62761", null, "Calderón", "TsSMUDrPkG", null, 1, null, null, "Eva.Calderon89@hotmail.com", "Eva" },
                    { "Oscar_Cantu78760", null, "Cantú", "XxvAhf4tp8", null, 1, null, null, "Oscar_Cantu44@yahoo.com", "Óscar" },
                    { "Daniel_Sanabria43759", null, "Sanabria", "3mxFuiUuTe", null, 1, null, null, "Daniel.Sanabria21@nearbpo.com", "Daniel" },
                    { "Veronica43743", null, "Cabrera", "QmUlDc6zdc", null, 1, null, null, "Veronica61@hotmail.com", "Verónica" },
                    { "JoseAntonio_Quintana744", null, "Quintana", "OPe2ycrkPk", null, 1, null, null, "JoseAntonio_Quintana73@corpfolder.com", "José Antonio" },
                    { "Maria_Prieto58745", null, "Prieto", "QKomjbZiAV", null, 1, null, null, "Maria_Prieto@hotmail.com", "María" },
                    { "Juana_Mena746", null, "Mena", "AksLhJmN_e", null, 1, null, null, "Juana.Mena70@corpfolder.com", "Juana" },
                    { "Leticia.Zepeda32747", null, "Zepeda", "axO7jg9dPz", null, 1, null, null, "Leticia81@hotmail.com", "Leticia" },
                    { "MariaLuisa25748", null, "Sotelo", "vvlJgF9rCo", null, 1, null, null, "MariaLuisa.Sotelo68@corpfolder.com", "María Luisa" },
                    { "Adriana.Zabaleta749", null, "Zabaleta", "A69XaUrm4A", null, 1, null, null, "Adriana.Zabaleta62@gmail.com", "Adriana" },
                    { "Ramiro89741", null, "Delgadillo", "oJwJ6ryRby", null, 1, null, null, "Ramiro_Delgadillo39@corpfolder.com", "Ramiro" },
                    { "Blanca45750", null, "Polanco", "EolfHUCVpX", null, 1, null, null, "Blanca_Polanco@nearbpo.com", "Blanca" },
                    { "Margarita_Duran6752", null, "Duran", "RhwJhhpMGE", null, 1, null, null, "Margarita54@hotmail.com", "Margarita" },
                    { "Alexis_Carvajal753", null, "Carvajal", "QTAkIJoUft", null, 1, null, null, "Alexis.Carvajal36@corpfolder.com", "Alexis" },
                    { "Mateo.Carmona754", null, "Carmona", "Va3UKeFz2_", null, 1, null, null, "Mateo.Carmona30@yahoo.com", "Mateo" },
                    { "Gonzalo62755", null, "Curiel", "iqcqhnsvTm", null, 1, null, null, "Gonzalo_Curiel85@yahoo.com", "Gonzalo" },
                    { "Lorenzo.Robles756", null, "Robles", "utEDprJGzc", null, 1, null, null, "Lorenzo.Robles65@gmail.com", "Lorenzo" },
                    { "Leonardo.Carranza18757", null, "Carranza", "tzmuOAXCIs", null, 1, null, null, "Leonardo16@yahoo.com", "Leonardo" },
                    { "Arturo_Pena758", null, "Peña", "MbJqV65kJV", null, 1, null, null, "Arturo_Pena@yahoo.com", "Arturo" },
                    { "Marisol98751", null, "Sisneros", "Bp3hOtwnXa", null, 1, null, null, "Marisol.Sisneros@yahoo.com", "Marisol" },
                    { "Melissa8778", null, "Aranda", "27BrmRDpao", null, 1, null, null, "Melissa.Aranda@corpfolder.com", "Melissa" },
                    { "AnaMaria.Avila702", null, "Ávila", "hcK9V50Lrw", null, 1, null, null, "AnaMaria_Avila27@hotmail.com", "Ana María" },
                    { "Santiago61700", null, "Dueñas", "708P1CXlHW", null, 1, null, null, "Santiago.Duenas68@yahoo.com", "Santiago" },
                    { "Pablo.Alaniz646", null, "Alaniz", "lVjoLrlew6", null, 1, null, null, "Pablo33@gmail.com", "Pablo" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Micaela_Resendez95647", null, "Reséndez", "yvS1qlc1e4", null, 1, null, null, "Micaela19@yahoo.com", "Micaela" },
                    { "Barbara38648", null, "Ruiz", "JniB4F1yhi", null, 1, null, null, "Barbara59@gmail.com", "Barbara" },
                    { "Adan.Barreto649", null, "Barreto", "mvz3I8hzzE", null, 1, null, null, "Adan56@hotmail.com", "Adán" },
                    { "Guadalupe.Galarza650", null, "Galarza", "SaIOfmRPni", null, 1, null, null, "Guadalupe_Galarza@gmail.com", "Guadalupe" },
                    { "Felipe_Gaitan651", null, "Gaitán", "jV8TjBmuSy", null, 1, null, null, "Felipe.Gaitan38@yahoo.com", "Felipe" },
                    { "Elizabeth.Tovar652", null, "Tovar", "nWPdnfwNuY", null, 1, null, null, "Elizabeth_Tovar9@corpfolder.com", "Elizabeth" },
                    { "Marilu.Jaquez653", null, "Jáquez", "8oUJ6tlzT6", null, 1, null, null, "Marilu87@gmail.com", "Marilu" },
                    { "Marilu83654", null, "Sedillo", "NnauS_HwzW", null, 1, null, null, "Marilu_Sedillo41@yahoo.com", "Marilu" },
                    { "Cesar.Haro37655", null, "Haro", "X7nzP_Xxot", null, 1, null, null, "Cesar68@gmail.com", "César" },
                    { "Gerardo_Duenas21656", null, "Dueñas", "AyKj3n6e50", null, 1, null, null, "Gerardo_Duenas@yahoo.com", "Gerardo" },
                    { "Javier.Verdugo657", null, "Verdugo", "hr13pDCsKz", null, 1, null, null, "Javier.Verdugo24@corpfolder.com", "Javier" },
                    { "Clemente65658", null, "Godoy", "vEyOh8COvX", null, 1, null, null, "Clemente_Godoy18@gmail.com", "Clemente" },
                    { "Brayan25659", null, "Valdés", "BRjmwT8kT5", null, 1, null, null, "Brayan44@hotmail.com", "Brayan" },
                    { "Octavio26660", null, "Sosa", "ZxWKdVYViV", null, 1, null, null, "Octavio.Sosa72@nearbpo.com", "Octavio" },
                    { "Guadalupe.Perea645", null, "Perea", "JIktXz2MqJ", null, 1, null, null, "Guadalupe92@hotmail.com", "Guadalupe" },
                    { "Benito_Pantoja644", null, "Pantoja", "3E66wFtFwb", null, 1, null, null, "Benito_Pantoja@nearbpo.com", "Benito" },
                    { "Raquel38643", null, "Sepúlveda", "yc5HgNjFb9", null, 1, null, null, "Raquel_Sepulveda@hotmail.com", "Raquel" },
                    { "Cecilia22642", null, "Roque", "r_4yBugcR9", null, 1, null, null, "Cecilia44@nearbpo.com", "Cecilia" },
                    { "Ignacio.Quezada626", null, "Quezada", "doetUYtfRY", null, 1, null, null, "Ignacio85@gmail.com", "Ignacio" },
                    { "MariadelCarmen37627", null, "Rojo", "qpqGbuEWsm", null, 1, null, null, "MariadelCarmen56@hotmail.com", "María del Carmen" },
                    { "Alejandro4628", null, "Carrillo", "1HMrFcxZlb", null, 1, null, null, "Alejandro71@hotmail.com", "Alejandro" },
                    { "Ariadna40629", null, "Reynoso", "V51F54sqH5", null, 1, null, null, "Ariadna_Reynoso72@yahoo.com", "Ariadna" },
                    { "Norma90630", null, "Marroquín", "NS_uFJ68pg", null, 1, null, null, "Norma.Marroquin38@hotmail.com", "Norma" },
                    { "JuanPablo.Quintairos631", null, "Quintairos", "Fnmuu1Iimn", null, 1, null, null, "JuanPablo_Quintairos@yahoo.com", "Juan Pablo" },
                    { "Rosa.Varela72632", null, "Varela", "ZoRxtwT6dh", null, 1, null, null, "Rosa_Varela42@gmail.com", "Rosa" },
                    { "Alfonso_Leyva661", null, "Leyva", "34y44sPQdf", null, 1, null, null, "Alfonso.Leyva@yahoo.com", "Alfonso" },
                    { "Aaron.Batista46633", null, "Batista", "MkziZEd4B4", null, 1, null, null, "Aaron.Batista92@hotmail.com", "Aarón" },
                    { "Uriel.Crespo93635", null, "Crespo", "PJfFjrXZ0V", null, 1, null, null, "Uriel.Crespo@nearbpo.com", "Uriel" },
                    { "Angela_Balderas98636", null, "Balderas", "hoLlcOKm4y", null, 1, null, null, "Angela_Balderas69@gmail.com", "Ángela" },
                    { "Alberto.Gomez637", null, "Gómez", "Rdz4fFvLup", null, 1, null, null, "Alberto_Gomez@corpfolder.com", "Alberto" },
                    { "Bernardo_Guevara638", null, "Guevara", "OH9n9FDE6F", null, 1, null, null, "Bernardo_Guevara94@nearbpo.com", "Bernardo" },
                    { "Luis_Zamarripa639", null, "Zamarripa", "OFa0ZSANk9", null, 1, null, null, "Luis.Zamarripa14@corpfolder.com", "Luis" },
                    { "Cristina40640", null, "Patiño", "iSHuuhsmWG", null, 1, null, null, "Cristina46@hotmail.com", "Cristina" },
                    { "Iker77641", null, "Figueroa", "_yoM0XnX_c", null, 1, null, null, "Iker.Figueroa5@hotmail.com", "Iker" },
                    { "Jose85634", null, "Guardado", "nV8cetMz0g", null, 1, null, null, "Jose76@yahoo.com", "José" },
                    { "Teresa75701", null, "Gaona", "SdLrPDleLj", null, 1, null, null, "Teresa_Gaona@gmail.com", "Teresa" },
                    { "Uriel.Soliz662", null, "Soliz", "XsCKJeZsci", null, 1, null, null, "Uriel.Soliz65@gmail.com", "Uriel" },
                    { "Isaias20664", null, "Medrano", "VvWaA3Rh4l", null, 1, null, null, "Isaias12@yahoo.com", "Isaias" },
                    { "JoseEmilio.Bernal685", null, "Bernal", "SJejg1bW1i", null, 1, null, null, "JoseEmilio_Bernal24@gmail.com", "José Emilio" },
                    { "Isabela94686", null, "Aponte", "GRS_u_yEb7", null, 1, null, null, "Isabela.Aponte@corpfolder.com", "Isabela" },
                    { "Ariadna.Yami14687", null, "Yami", "OSZ2n38SZ0", null, 1, null, null, "Ariadna35@hotmail.com", "Ariadna" },
                    { "Emilio91688", null, "Montero", "yallyJoUvW", null, 1, null, null, "Emilio.Montero24@gmail.com", "Emilio" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Lorena.Medina7689", null, "Medina", "csldJWLX8Y", null, 1, null, null, "Lorena_Medina44@hotmail.com", "Lorena" },
                    { "JulioCesar.Padron1690", null, "Padrón", "GH8SvWYlA0", null, 1, null, null, "JulioCesar18@gmail.com", "Julio César" },
                    { "Conchita.Ojeda8691", null, "Ojeda", "DskVnS1SIX", null, 1, null, null, "Conchita_Ojeda81@hotmail.com", "Conchita" },
                    { "Samuel_Pantoja42692", null, "Pantoja", "ExY0XkYUQc", null, 1, null, null, "Samuel12@nearbpo.com", "Samuel" },
                    { "Yaretzi.Matias55693", null, "Matías", "KvN8FfTpr_", null, 1, null, null, "Yaretzi.Matias@hotmail.com", "Yaretzi" },
                    { "Emmanuel.Pedroza694", null, "Pedroza", "yZdYsxZAn4", null, 1, null, null, "Emmanuel_Pedroza@hotmail.com", "Emmanuel" },
                    { "Luz.Brito57695", null, "Brito", "nqtrqZ_xAr", null, 1, null, null, "Luz19@nearbpo.com", "Luz" },
                    { "Jeronimo1696", null, "Manzanares", "DDeGdex06_", null, 1, null, null, "Jeronimo_Manzanares@nearbpo.com", "Jerónimo" },
                    { "Carlos86697", null, "Negrón", "zHLnvGfUwG", null, 1, null, null, "Carlos30@hotmail.com", "Carlos" },
                    { "Lorena.Rosales27698", null, "Rosales", "QT1q3UIsu0", null, 1, null, null, "Lorena.Rosales12@hotmail.com", "Lorena" },
                    { "Araceli_Quinonez699", null, "Quiñónez", "mBTgUrYujF", null, 1, null, null, "Araceli33@yahoo.com", "Araceli" },
                    { "MariaFernanda_Arenas25684", null, "Arenas", "VlzmIasVlL", null, 1, null, null, "MariaFernanda.Arenas@yahoo.com", "María Fernanda" },
                    { "Monica.Rosales683", null, "Rosales", "WoTdttfYzC", null, 1, null, null, "Monica31@nearbpo.com", "Mónica" },
                    { "Guillermo94682", null, "Enríquez", "A2uLwYTa7N", null, 1, null, null, "Guillermo.Enriquez@gmail.com", "Guillermo" },
                    { "Estefania19681", null, "Salinas", "xUnIlqw6Ve", null, 1, null, null, "Estefania_Salinas@hotmail.com", "Estefanía" },
                    { "Armando19665", null, "Galván", "98PVgPDhKD", null, 1, null, null, "Armando_Galvan98@hotmail.com", "Armando" },
                    { "Matias.Gaytan44666", null, "Gaytán", "p4nOUqno1S", null, 1, null, null, "Matias43@yahoo.com", "Matías" },
                    { "MariadeJesus89667", null, "Sedillo", "5SS0eSkydG", null, 1, null, null, "MariadeJesus_Sedillo14@corpfolder.com", "María de Jesús" },
                    { "Mercedes.Arce668", null, "Arce", "W8SeyZOHiT", null, 1, null, null, "Mercedes.Arce53@gmail.com", "Mercedes" },
                    { "Carolina_Brito669", null, "Brito", "78yhDWfnZX", null, 1, null, null, "Carolina82@yahoo.com", "Carolina" },
                    { "Natalia_Duenas670", null, "Dueñas", "EZ5bG4G8Bh", null, 1, null, null, "Natalia.Duenas85@yahoo.com", "Natalia" },
                    { "Agustin_Anguiano671", null, "Anguiano", "_mLm95P2uu", null, 1, null, null, "Agustin.Anguiano87@yahoo.com", "Agustín" },
                    { "Ariadna60663", null, "Gil", "pQ8yDiZ2sp", null, 1, null, null, "Ariadna66@gmail.com", "Ariadna" },
                    { "Sancho.Jurado672", null, "Jurado", "9fiFA61Y4U", null, 1, null, null, "Sancho47@gmail.com", "Sancho" },
                    { "Olivia13674", null, "Maestas", "6IwvNyH8ht", null, 1, null, null, "Olivia45@hotmail.com", "Olivia" },
                    { "Yaretzi_Escalante58675", null, "Escalante", "DfepqV2DHR", null, 1, null, null, "Yaretzi67@corpfolder.com", "Yaretzi" },
                    { "Mateo.Malave20676", null, "Malave", "yjBYh4YQX2", null, 1, null, null, "Mateo.Malave46@corpfolder.com", "Mateo" },
                    { "Iker57677", null, "Alarcón", "lxGnWPuPyv", null, 1, null, null, "Iker37@hotmail.com", "Iker" },
                    { "JoseMaria74678", null, "Aparicio", "pGvLNZQllG", null, 1, null, null, "JoseMaria_Aparicio32@hotmail.com", "José María" },
                    { "Dorotea.Marroquin679", null, "Marroquín", "q4Nynr6XMq", null, 1, null, null, "Dorotea_Marroquin8@yahoo.com", "Dorotea" },
                    { "Beatriz.Godinez2680", null, "Godínez", "cQfEaLUbKx", null, 1, null, null, "Beatriz.Godinez@yahoo.com", "Beatriz" },
                    { "Victor_Muro673", null, "Muro", "5Lp2NQByER", null, 1, null, null, "Victor.Muro@yahoo.com", "Víctor" },
                    { "JoseEduardo_Trejo91779", null, "Trejo", "PJYwHuqNGW", null, 1, null, null, "JoseEduardo.Trejo49@hotmail.com", "José Eduardo" },
                    { "Lilia52780", null, "Ochoa", "nX1MufBbQb", null, 1, null, null, "Lilia26@corpfolder.com", "Lilia" },
                    { "Cristobal_Coronado13781", null, "Coronado", "DP61T9ikNp", null, 1, null, null, "Cristobal.Coronado@hotmail.com", "Cristobal" },
                    { "Emilio8881", null, "Sedillo", "ELLKjUJPBI", null, 1, null, null, "Emilio.Sedillo61@yahoo.com", "Emilio" },
                    { "Ester8882", null, "Feliciano", "GaLC2JypIL", null, 1, null, null, "Ester_Feliciano@gmail.com", "Ester" },
                    { "Lucia_Preciado883", null, "Preciado", "h16jwGQ6U6", null, 1, null, null, "Lucia.Preciado@nearbpo.com", "Lucia" },
                    { "Melissa_Lugo884", null, "Lugo", "c3odlwVDKd", null, 1, null, null, "Melissa.Lugo25@yahoo.com", "Melissa" },
                    { "Alejandro_Jasso885", null, "Jasso", "JYgPynpALU", null, 1, null, null, "Alejandro71@corpfolder.com", "Alejandro" },
                    { "AlondraRomina.Prado36886", null, "Prado", "FiQwwKj9X3", null, 1, null, null, "AlondraRomina5@nearbpo.com", "Alondra Romina" },
                    { "Abril7887", null, "Roybal", "pX18vooEHC", null, 1, null, null, "Abril.Roybal46@yahoo.com", "Abril" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Marilu1888", null, "Vázquez", "67rLt71r_Y", null, 1, null, null, "Marilu_Vazquez43@yahoo.com", "Marilu" },
                    { "Anita.Ramirez88889", null, "Ramírez", "hHmIGGzt0S", null, 1, null, null, "Anita22@corpfolder.com", "Anita" },
                    { "Carlos_Toro890", null, "Toro", "iWqggi82Ja", null, 1, null, null, "Carlos44@gmail.com", "Carlos" },
                    { "Octavio.Vera891", null, "Vera", "M6PXdkcI4C", null, 1, null, null, "Octavio.Vera43@hotmail.com", "Octavio" },
                    { "RosaMaria68892", null, "Koenig", "O2lYV_thoE", null, 1, null, null, "RosaMaria95@nearbpo.com", "Rosa María" },
                    { "JulioCesar_Lira893", null, "Lira", "EfxdmpBgEe", null, 1, null, null, "JulioCesar.Lira@hotmail.com", "Julio César" },
                    { "Pilar.Prieto894", null, "Prieto", "y5v2fnFQXU", null, 1, null, null, "Pilar67@gmail.com", "Pilar" },
                    { "Mercedes_Mireles76895", null, "Mireles", "Mt2hsdkFtl", null, 1, null, null, "Mercedes76@corpfolder.com", "Mercedes" },
                    { "Axel.Quesada880", null, "Quesada", "5NM7xWvMs0", null, 1, null, null, "Axel_Quesada@gmail.com", "Axel" },
                    { "Rebeca75879", null, "Yunta", "89ekTgXbyv", null, 1, null, null, "Rebeca3@hotmail.com", "Rebeca" },
                    { "Ivan.Velez878", null, "Vélez", "5ueUkchqe6", null, 1, null, null, "Ivan.Velez@gmail.com", "Ivan" },
                    { "Guadalupe.Cardona877", null, "Cardona", "pYwZv3Fucu", null, 1, null, null, "Guadalupe.Cardona@corpfolder.com", "Guadalupe" },
                    { "MariaEugenia_Linares67861", null, "Linares", "FpQIWUfpXr", null, 1, null, null, "MariaEugenia15@yahoo.com", "María Eugenia" },
                    { "Leticia65862", null, "Amador", "JR9Db4fmsR", null, 1, null, null, "Leticia87@corpfolder.com", "Leticia" },
                    { "Israel.Alvarez863", null, "Alvarez", "dF0r1qmuTl", null, 1, null, null, "Israel_Alvarez20@gmail.com", "Israel" },
                    { "Rebeca5864", null, "Mojica", "xZZ_e_RsGk", null, 1, null, null, "Rebeca_Mojica@corpfolder.com", "Rebeca" },
                    { "LuisMiguel25865", null, "Escamilla", "klnuM2r339", null, 1, null, null, "LuisMiguel_Escamilla@yahoo.com", "Luis Miguel" },
                    { "Nicolas_Hinojosa866", null, "Hinojosa", "_uQFckEC0m", null, 1, null, null, "Nicolas17@nearbpo.com", "Nicolás" },
                    { "Gregorio_Crespo15867", null, "Crespo", "EhuiNASln9", null, 1, null, null, "Gregorio_Crespo33@corpfolder.com", "Gregorio" },
                    { "Gloria.Baez87896", null, "Báez", "5oZ85vKxqp", null, 1, null, null, "Gloria.Baez58@yahoo.com", "Gloria" },
                    { "Homero.Moreno868", null, "Moreno", "e31BBftC91", null, 1, null, null, "Homero.Moreno@nearbpo.com", "Homero" },
                    { "Sebastian_Aviles870", null, "Avilés", "1IP6wFN0a3", null, 1, null, null, "Sebastian_Aviles@gmail.com", "Sebastian" },
                    { "Marcos_Karan871", null, "Karan", "xQo7g9mLgl", null, 1, null, null, "Marcos50@hotmail.com", "Marcos" },
                    { "Elena19872", null, "Espinal", "SxFt3UouBq", null, 1, null, null, "Elena.Espinal@nearbpo.com", "Elena" },
                    { "Sergio_Briseno873", null, "Briseño", "y7GKYErWtU", null, 1, null, null, "Sergio24@nearbpo.com", "Sergio" },
                    { "German_Preciado874", null, "Preciado", "HwuCHjVQZO", null, 1, null, null, "German.Preciado18@nearbpo.com", "Germán" },
                    { "Salvador46875", null, "Báez", "lanMdrmOLu", null, 1, null, null, "Salvador45@nearbpo.com", "Salvador" },
                    { "Antonia.Sanchez876", null, "Sánchez", "YNVXiG6OXY", null, 1, null, null, "Antonia17@nearbpo.com", "Antonia" },
                    { "Estefania33869", null, "Collazo", "RqiplC5u5l", null, 1, null, null, "Estefania_Collazo@corpfolder.com", "Estefanía" },
                    { "LuisMiguel10860", null, "Peres", "N8XauQLUki", null, 1, null, null, "LuisMiguel40@gmail.com", "Luis Miguel" },
                    { "Ines37897", null, "Cisneros", "eFDYq2chww", null, 1, null, null, "Ines83@nearbpo.com", "Inés" },
                    { "Elias_Lucio899", null, "Lucio", "5xcMou2CM3", null, 1, null, null, "Elias85@corpfolder.com", "Elías" },
                    { "Emmanuel.Corral79920", null, "Corral", "PMfLrwYtAI", null, 1, null, null, "Emmanuel75@corpfolder.com", "Emmanuel" },
                    { "Carlota.Merino68921", null, "Merino", "iwDEwtZ5zd", null, 1, null, null, "Carlota9@corpfolder.com", "Carlota" },
                    { "AnaLuisa22922", null, "Menchaca", "IOKKadC3kE", null, 1, null, null, "AnaLuisa_Menchaca@gmail.com", "Ana Luisa" },
                    { "MariadelCarmen96923", null, "Jasso", "c9GawtmtLw", null, 1, null, null, "MariadelCarmen.Jasso46@hotmail.com", "María del Carmen" },
                    { "Lorenzo_Pedraza924", null, "Pedraza", "F1_1MDU0CH", null, 1, null, null, "Lorenzo56@corpfolder.com", "Lorenzo" },
                    { "FranciscoJavier_Quinterocruz51925", null, "Quintero cruz", "nY7kkJKLvV", null, 1, null, null, "FranciscoJavier34@corpfolder.com", "Francisco Javier" },
                    { "Jaime_Alaniz66926", null, "Alaniz", "vhVxX0y41J", null, 1, null, null, "Jaime72@nearbpo.com", "Jaime" },
                    { "Fernando.Luevano927", null, "Luevano", "RcBzrm0eNB", null, 1, null, null, "Fernando_Luevano@nearbpo.com", "Fernando" },
                    { "Lorena_Atencio928", null, "Atencio", "4qqqPu7KHd", null, 1, null, null, "Lorena21@nearbpo.com", "Lorena" },
                    { "Tadeo.Marroquin3929", null, "Marroquín", "thhqlfSeSM", null, 1, null, null, "Tadeo55@nearbpo.com", "Tadeo" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "MariaSoledad.Serrato46930", null, "Serrato", "YHXP4K0bbA", null, 1, null, null, "MariaSoledad.Serrato74@nearbpo.com", "María Soledad" },
                    { "Rocio_Zarate47931", null, "Zarate", "mDEp3zLPVo", null, 1, null, null, "Rocio3@yahoo.com", "Rocio" },
                    { "Beatriz0932", null, "Lovato", "z8qXbW1TOn", null, 1, null, null, "Beatriz94@nearbpo.com", "Beatriz" },
                    { "Marisol_Yanez47933", null, "Yáñez", "BRjCEDnLCb", null, 1, null, null, "Marisol.Yanez69@yahoo.com", "Marisol" },
                    { "Gustavo.Terrazas934", null, "Terrazas", "WM7h8So6OU", null, 1, null, null, "Gustavo_Terrazas@corpfolder.com", "Gustavo" },
                    { "Adela_Barrientos919", null, "Barrientos", "7MtbAdsqJM", null, 1, null, null, "Adela.Barrientos@gmail.com", "Adela" },
                    { "Teresa51918", null, "Botello", "E5OHTIZAZB", null, 1, null, null, "Teresa.Botello@nearbpo.com", "Teresa" },
                    { "JoseDaniel_Matos917", null, "Matos", "7_TkCfvsNC", null, 1, null, null, "JoseDaniel_Matos61@yahoo.com", "Jose Daniel" },
                    { "MariaGuadalupe84916", null, "Porras", "spJ4hU1BM0", null, 1, null, null, "MariaGuadalupe_Porras47@yahoo.com", "María Guadalupe" },
                    { "Jeronimo.Zaragoza59900", null, "Zaragoza", "j99N_RovCA", null, 1, null, null, "Jeronimo_Zaragoza6@gmail.com", "Jerónimo" },
                    { "Rosario.Quezada901", null, "Quezada", "Eqpg7cbVfw", null, 1, null, null, "Rosario_Quezada@nearbpo.com", "Rosario" },
                    { "Gabriel.Melgar67902", null, "Melgar", "jSfA7rWjX3", null, 1, null, null, "Gabriel62@yahoo.com", "Gabriel" },
                    { "Lucia_Roldan24903", null, "Roldán", "qduj_2piLt", null, 1, null, null, "Lucia_Roldan@yahoo.com", "Lucia" },
                    { "Armando15904", null, "Ortiz", "QqtksyrNmq", null, 1, null, null, "Armando.Ortiz@nearbpo.com", "Armando" },
                    { "Alexander9905", null, "Gutiérrez", "1mohcJ6fQu", null, 1, null, null, "Alexander94@corpfolder.com", "Alexander" },
                    { "Zoe90906", null, "Sedillo", "K0Q2y6evHB", null, 1, null, null, "Zoe84@nearbpo.com", "Zoe" },
                    { "Claudia_Urbina81898", null, "Urbina", "sh72Zq2fqS", null, 1, null, null, "Claudia83@yahoo.com", "Claudia" },
                    { "Cristian.Meza907", null, "Meza", "zA_7zFPWiJ", null, 1, null, null, "Cristian39@hotmail.com", "Cristian" },
                    { "Matias_Terrazas909", null, "Terrazas", "McpRGYiKeq", null, 1, null, null, "Matias_Terrazas50@hotmail.com", "Matías" },
                    { "Yaretzi85910", null, "Apodaca", "xCmyoSFfqy", null, 1, null, null, "Yaretzi_Apodaca92@yahoo.com", "Yaretzi" },
                    { "XimenaGuadalupe8911", null, "Yanes", "YIZmVtobtj", null, 1, null, null, "XimenaGuadalupe.Yanes70@nearbpo.com", "Ximena Guadalupe" },
                    { "Natalia.Karem912", null, "Karem", "wuvwmpJj0y", null, 1, null, null, "Natalia13@nearbpo.com", "Natalia" },
                    { "Paulina92913", null, "Pelayo", "A3TznCgaaU", null, 1, null, null, "Paulina42@yahoo.com", "Paulina" },
                    { "Catalina44914", null, "Valencia", "Mf1ptMmpLQ", null, 1, null, null, "Catalina.Valencia@hotmail.com", "Catalina" },
                    { "Brandon35915", null, "Ulloa", "7rszDqVDqv", null, 1, null, null, "Brandon_Ulloa42@nearbpo.com", "Brandon" },
                    { "Melissa_Moya0908", null, "Moya", "BZjOTabzIz", null, 1, null, null, "Melissa_Moya48@gmail.com", "Melissa" },
                    { "Raquel_Merino859", null, "Merino", "tOUUk5z_e1", null, 1, null, null, "Raquel.Merino11@nearbpo.com", "Raquel" },
                    { "Lizbeth12858", null, "Véliz", "7C4PKuP9mG", null, 1, null, null, "Lizbeth_Veliz@corpfolder.com", "Lizbeth" },
                    { "JoseEduardo.Longoria857", null, "Longoria", "UKe5rEirPh", null, 1, null, null, "JoseEduardo.Longoria20@yahoo.com", "José Eduardo" },
                    { "Alberto_Ruiz16802", null, "Ruiz", "AEMlUiIvWX", null, 1, null, null, "Alberto.Ruiz@nearbpo.com", "Alberto" },
                    { "Salvador_Delatorre803", null, "Delatorre", "f7CPixh0qr", null, 1, null, null, "Salvador_Delatorre@yahoo.com", "Salvador" },
                    { "Gabriela13804", null, "Saldaña", "3lOYQLivkb", null, 1, null, null, "Gabriela_Saldana29@corpfolder.com", "Gabriela" },
                    { "Veronica_Zamarripa69805", null, "Zamarripa", "VkZT_b9IPG", null, 1, null, null, "Veronica.Zamarripa@corpfolder.com", "Verónica" },
                    { "Kevin_Holguin82806", null, "Holguín", "yBDehStDpk", null, 1, null, null, "Kevin15@gmail.com", "Kevin" },
                    { "JuanCarlos2807", null, "Carrera", "8G4ccZKuae", null, 1, null, null, "JuanCarlos.Carrera43@nearbpo.com", "Juan Carlos" },
                    { "Gael.Nevarez93808", null, "Nevárez", "JY_EVL6jay", null, 1, null, null, "Gael.Nevarez@nearbpo.com", "Gael" },
                    { "Gabriel.Garibay809", null, "Garibay", "9E3uXKGoW8", null, 1, null, null, "Gabriel.Garibay@yahoo.com", "Gabriel" },
                    { "MariadeJesus19810", null, "Porras", "UWUgq8j8V4", null, 1, null, null, "MariadeJesus94@yahoo.com", "María de Jesús" },
                    { "Graciela_Figueroa811", null, "Figueroa", "yNRxe07ocA", null, 1, null, null, "Graciela70@nearbpo.com", "Graciela" },
                    { "Juana.Munoz15812", null, "Muñoz", "DATFrvxCNd", null, 1, null, null, "Juana_Munoz@yahoo.com", "Juana" },
                    { "Ivan.Zayas48813", null, "Zayas", "BvSKGsidjR", null, 1, null, null, "Ivan_Zayas@yahoo.com", "Ivan" },
                    { "Alfonso_Figueroa814", null, "Figueroa", "8uUADoCUnG", null, 1, null, null, "Alfonso_Figueroa33@gmail.com", "Alfonso" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "Patricia_Guillen815", null, "Guillen", "6cIKreuBSE", null, 1, null, null, "Patricia_Guillen@gmail.com", "Patricia" },
                    { "Melissa_Ortega816", null, "Ortega", "w5cZS2IuSX", null, 1, null, null, "Melissa_Ortega52@hotmail.com", "Melissa" },
                    { "Ernesto_Quiroz2801", null, "Quiroz", "N88IWoOfd9", null, 1, null, null, "Ernesto.Quiroz20@hotmail.com", "Ernesto" },
                    { "Kevin45800", null, "Ledesma", "ZheaeVf5qD", null, 1, null, null, "Kevin_Ledesma@hotmail.com", "Kevin" },
                    { "Andres_Xiana62799", null, "Xiana", "2UTpFPoM11", null, 1, null, null, "Andres.Xiana49@hotmail.com", "Andrés" },
                    { "Francisca26798", null, "Nieto", "ENOiD8ryN7", null, 1, null, null, "Francisca.Nieto31@gmail.com", "Francisca" },
                    { "Guillermo.Lomeli74782", null, "Lomeli", "HggRg7thHU", null, 1, null, null, "Guillermo.Lomeli@nearbpo.com", "Guillermo" },
                    { "Joaquin_Armijo29783", null, "Armijo", "qsp4H6pcg7", null, 1, null, null, "Joaquin.Armijo@yahoo.com", "Joaquín" },
                    { "Jazmin28784", null, "Chávez", "hxHxkusdgg", null, 1, null, null, "Jazmin_Chavez@gmail.com", "Jazmin" },
                    { "MariaGuadalupe69785", null, "Hinojosa", "bg18hV6eWo", null, 1, null, null, "MariaGuadalupe_Hinojosa@gmail.com", "María Guadalupe" },
                    { "MariaGuadalupe19786", null, "Tirado", "GElYBiJrWY", null, 1, null, null, "MariaGuadalupe_Tirado30@hotmail.com", "María Guadalupe" },
                    { "Patricio.Briseno787", null, "Briseño", "YcNftJXUXF", null, 1, null, null, "Patricio_Briseno@hotmail.com", "Patricio" },
                    { "Josefina86788", null, "Xairo Belmonte", "bCQ32elmLm", null, 1, null, null, "Josefina_XairoBelmonte19@yahoo.com", "Josefina" },
                    { "Alejandro_Carrera817", null, "Carrera", "M0nthD2hum", null, 1, null, null, "Alejandro61@gmail.com", "Alejandro" },
                    { "Luz_Bravo789", null, "Bravo", "LBlvHf2Qvf", null, 1, null, null, "Luz_Bravo@gmail.com", "Luz" },
                    { "Armando.Sisneros791", null, "Sisneros", "qNuAKe1pot", null, 1, null, null, "Armando_Sisneros@nearbpo.com", "Armando" },
                    { "Micaela_Covarrubias68792", null, "Covarrubias", "3ceudb2aQN", null, 1, null, null, "Micaela.Covarrubias@yahoo.com", "Micaela" },
                    { "Nicole54793", null, "Lucero", "pBL9gIbQzB", null, 1, null, null, "Nicole16@gmail.com", "Nicole" },
                    { "Amalia.Noriega6794", null, "Noriega", "qHaObIrVhH", null, 1, null, null, "Amalia36@gmail.com", "Amalia" },
                    { "Axel.Rojas77795", null, "Rojas", "ZD1RA5iMPZ", null, 1, null, null, "Axel93@hotmail.com", "Axel" },
                    { "Mercedes0796", null, "Lucero", "WGgtGNLgQU", null, 1, null, null, "Mercedes.Lucero69@corpfolder.com", "Mercedes" },
                    { "Magdalena29797", null, "Castañeda", "RtjnaXq8Ee", null, 1, null, null, "Magdalena16@yahoo.com", "Magdalena" },
                    { "Matias50790", null, "Espino", "rPVXTa_lSV", null, 1, null, null, "Matias_Espino16@yahoo.com", "Matías" },
                    { "Melany.Naranjo818", null, "Naranjo", "cxqKCjgevJ", null, 1, null, null, "Melany18@nearbpo.com", "Melany" },
                    { "Emilio.Santiago819", null, "Santiago", "nkjWFAHhRB", null, 1, null, null, "Emilio.Santiago80@corpfolder.com", "Emilio" },
                    { "Hernan.Espinal820", null, "Espinal", "DCmixDjvn7", null, 1, null, null, "Hernan41@nearbpo.com", "Hernán" },
                    { "Patricio.Balderas841", null, "Balderas", "mHQXv10HEu", null, 1, null, null, "Patricio_Balderas15@corpfolder.com", "Patricio" },
                    { "Victor_Heredia99842", null, "Heredia", "SD4a0Li_Tw", null, 1, null, null, "Victor_Heredia74@hotmail.com", "Víctor" },
                    { "Eloisa36843", null, "Leyva", "RzJ34D_QiR", null, 1, null, null, "Eloisa_Leyva94@gmail.com", "Eloisa" },
                    { "LuisMiguel_Villarreal41844", null, "Villarreal", "L5rwrXp877", null, 1, null, null, "LuisMiguel_Villarreal72@gmail.com", "Luis Miguel" },
                    { "Francisca.Delgadillo845", null, "Delgadillo", "Q_p08y2fMv", null, 1, null, null, "Francisca.Delgadillo@yahoo.com", "Francisca" },
                    { "Miranda93846", null, "Zarate", "KJZxsbQE2b", null, 1, null, null, "Miranda5@hotmail.com", "Miranda" },
                    { "Kevin_Arias60847", null, "Arias", "z_TLJ96G5L", null, 1, null, null, "Kevin.Arias31@yahoo.com", "Kevin" },
                    { "Miranda71840", null, "Rosado", "bfmRExMd5D", null, 1, null, null, "Miranda_Rosado91@gmail.com", "Miranda" },
                    { "Raquel80848", null, "Pulido", "1iyK3wVot3", null, 1, null, null, "Raquel_Pulido89@yahoo.com", "Raquel" },
                    { "Agustin26850", null, "Ceja", "DWPQD89Vni", null, 1, null, null, "Agustin_Ceja@corpfolder.com", "Agustín" },
                    { "Juana59851", null, "Terán", "zPI60NeN2n", null, 1, null, null, "Juana49@nearbpo.com", "Juana" },
                    { "JoseDaniel_Salcedo23852", null, "Salcedo", "_t6UE3bMI3", null, 1, null, null, "JoseDaniel_Salcedo@nearbpo.com", "Jose Daniel" },
                    { "JoseMiguel_Garay62853", null, "Garay", "aGe0nE70TA", null, 1, null, null, "JoseMiguel.Garay@gmail.com", "José Miguel" },
                    { "FranciscoJavier18854", null, "Mojica", "Um28nu1UMR", null, 1, null, null, "FranciscoJavier.Mojica@gmail.com", "Francisco Javier" },
                    { "Jimena_Saldana36855", null, "Saldaña", "RsRmihcNkn", null, 1, null, null, "Jimena53@nearbpo.com", "Jimena" },
                    { "AnaMaria50856", null, "Matos", "XsQsHoZtgj", null, 1, null, null, "AnaMaria_Matos@yahoo.com", "Ana María" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "NombreUsuario", "ActualizadoPor", "Apellido", "Clave", "CreadoPor", "EstadoUsuarioId", "FechaActualizacion", "FechaCreacion", "Mail", "Nombre" },
                values: new object[,]
                {
                    { "MariaGuadalupe_Luevano46849", null, "Luevano", "0mF9EjtDcT", null, 1, null, null, "MariaGuadalupe.Luevano@nearbpo.com", "María Guadalupe" },
                    { "Rosalia78936", null, "Alonso", "AsY2JPuJmN", null, 1, null, null, "Rosalia59@nearbpo.com", "Rosalia" },
                    { "Jose54839", null, "Verduzco", "QfCSUBrosE", null, 1, null, null, "Jose_Verduzco44@yahoo.com", "José" },
                    { "Francisca.Guajardo5837", null, "Guajardo", "cE7_gr5DP3", null, 1, null, null, "Francisca_Guajardo@nearbpo.com", "Francisca" },
                    { "Victoria_Centeno821", null, "Centeno", "EeMWKhedjF", null, 1, null, null, "Victoria.Centeno@corpfolder.com", "Victoria" },
                    { "Lola.Jaimes822", null, "Jaimes", "GYqcAWmYZQ", null, 1, null, null, "Lola_Jaimes26@yahoo.com", "Lola" },
                    { "Margarita83823", null, "Collado", "GVHUYoms_u", null, 1, null, null, "Margarita_Collado@yahoo.com", "Margarita" },
                    { "Gonzalo76824", null, "Godínez", "rhzVfSwRng", null, 1, null, null, "Gonzalo.Godinez49@gmail.com", "Gonzalo" },
                    { "Aaron_Veliz825", null, "Véliz", "rdAQ0yQHI8", null, 1, null, null, "Aaron.Veliz96@nearbpo.com", "Aarón" },
                    { "Dorotea21826", null, "Olvera", "WlLp0HH6Jn", null, 1, null, null, "Dorotea7@gmail.com", "Dorotea" },
                    { "Lucia15827", null, "Márquez", "k68D0BbGBH", null, 1, null, null, "Lucia.Marquez@hotmail.com", "Lucia" },
                    { "Diana.Matias40838", null, "Matías", "0hDKUHnjZf", null, 1, null, null, "Diana_Matias12@nearbpo.com", "Diana" },
                    { "Rosalia82828", null, "Robles", "hHZVRlfqkj", null, 1, null, null, "Rosalia_Robles1@hotmail.com", "Rosalia" },
                    { "Adriana_Bermudez60830", null, "Bermúdez", "HCRlqzuTXa", null, 1, null, null, "Adriana_Bermudez@nearbpo.com", "Adriana" },
                    { "JoseDaniel97831", null, "Madrid", "qzxApF7KMN", null, 1, null, null, "JoseDaniel72@hotmail.com", "Jose Daniel" },
                    { "Yamileth71832", null, "Córdova", "dp0kIVbPXO", null, 1, null, null, "Yamileth.Cordova@corpfolder.com", "Yamileth" },
                    { "Barbara_Carrera67833", null, "Carrera", "0bLV_kTFFY", null, 1, null, null, "Barbara.Carrera@yahoo.com", "Barbara" },
                    { "Nicolas.Carrera15834", null, "Carrera", "yfTfWbNGlB", null, 1, null, null, "Nicolas40@hotmail.com", "Nicolás" },
                    { "Natalia_Rojas835", null, "Rojas", "D4rBzpawqC", null, 1, null, null, "Natalia.Rojas93@hotmail.com", "Natalia" },
                    { "Martin.Alcala836", null, "Alcala", "pJER0VN6Ra", null, 1, null, null, "Martin_Alcala63@gmail.com", "Martín" },
                    { "Antonio_Arreola80829", null, "Arreola", "vBVQhDZxoi", null, 1, null, null, "Antonio87@nearbpo.com", "Antonio" },
                    { "Carolina.Quinterocruz572499", null, "Quintero cruz", "I28Elzbeqy", null, 1, null, null, "Carolina_Quinterocruz79@corpfolder.com", "Carolina" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Aaron_Carrasquillo1556");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Aaron_Kanimal2307");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Aaron_Nieves230");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Aaron_Romo1800");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Aaron_Veliz825");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Aaron.Batista46633");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Aaron.Caldera642169");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Aaron.Mondragon34588");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Aaron.Montenegro521752");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Aaron.Rico31779");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Aaron.Vanegas28963");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Abigail_Esparza1209");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Abigail_Orta802299");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Abigail_Xicoy711321");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Abigail.Llamas2040");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Abigail.Roldan1479");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Abigail531989");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Abraham_Acuna161538");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Abraham_Giron271230");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Abraham.Angulo1085");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Abraham.Escobedo1397");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Abraham.Polanco1353");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Abraham.Preciado1643");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Abraham28611");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Abraham65579");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Abraham702394");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Abraham912202");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Abril_Cervantez277");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Abril_Sanchez1161");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Abril.Varela1386");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Abril19705");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Abril451482");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Abril7887");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Adan_Cuellar96776");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Adan_Razo851024");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Adan.Barreto649");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Adan.Ocampo861550");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Adan.Orellana2208");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Adan711735");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Adan91883");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Adan97524");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Adela_Barrientos919");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Adela_Chavarria1965");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Adela_Raya01811");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Adela.Gallegos421443");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Adela.Olivarez2383");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Adela.Salinas882417");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Adela.Sarabia811130");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Adela251645");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Adela29487");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Adela97182");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Adriana_Abreu1559");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Adriana_Bermudez60830");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Adriana_Escobar969");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Adriana_Guardado842076");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Adriana_Miranda2102");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Adriana_Rosas501628");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Adriana.Brito2392");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Adriana.Salazar2095");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Adriana.Urena956");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Adriana.Zabaleta749");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Adriana57448");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Adriana662262");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Agustin_Anguiano671");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Agustin.Carrero1790");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Agustin.Delgado461576");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Agustin26850");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Agustin57399");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Agustin812062");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alan_Delagarza391500");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alan_Uribe89");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alan_Yami121064");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alan.Kortahernandez135");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alan.Leiva2283");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alan101313");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alan52113");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alan891978");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alberto_Ruiz16802");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alberto.Aparicio551757");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alberto.Gomez637");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alberto.Toro521389");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alberto36736");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alberto451001");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alberto91578");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alejandra_Delvalle764");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alejandra_Pineda14253");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alejandra.Botello971669");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alejandra.Krauelnatera1159");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alejandra.Rios1259");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alejandra.Serna72269");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alejandra771183");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alejandro_Carrera817");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alejandro_Cornejo882109");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alejandro_Fierro111510");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alejandro_Jasso885");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alejandro_Riojas971225");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alejandro_Sierra2442");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alejandro_Vargas1621");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alejandro.Moreno1120");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alejandro.Munoz1245");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alejandro.Nino35200");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alejandro.Sepulveda62543");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alejandro22369");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alejandro4628");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alejandro472362");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alexa_Acuna259");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alexa_Chacon621478");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alexa_Sierra01170");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alexa_Torrez1592");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alexa.Loera2121");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alexa.Porras35951");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alexa.Rodrigez2407");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alexa511297");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alexa7091");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alexa762143");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alexa79476");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alexa971227");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alexander_Velasquez121702");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alexander_Villagomez221236");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alexander.Cepeda2472");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alexander.Gallegos8165");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alexander.Kanzaki1032");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alexander.Moya98318");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alexander52545");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alexander9905");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alexis_Carvajal753");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alexis_Nanez1586");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alexis_Rangel93");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alexis_Riojas311434");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alexis_Villalpando1776");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alexis.Banuelos1696");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alexis.Sandoval691619");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alexis161602");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alfonso_Alvarado861852");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alfonso_Carrasco551395");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alfonso_Figueroa814");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alfonso_Godinez1098");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alfonso_Leyva661");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alfonso_Miranda571076");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alfonso_Ulloa1468");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alfonso_Yanez452");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alfonso.Jimenez3412");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alfonso.Lomeli1381");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alfonso.Morales114");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alfonso131701");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alfonso721010");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alfredo_Griego52610");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alfredo501875");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alfredo842006");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alfredo852419");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alfredo88207");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alicia_Quinterocruz2404");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alicia_Rendon461069");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alicia17270");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alicia532273");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Alicia732315");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AlondraRomina_Carrero542122");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AlondraRomina.Prado36886");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AlondraRomina341557");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Amalia_Ballesteros451172");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Amalia_Gaitan148");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Amalia.Ayala95237");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Amalia.Noriega6794");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Amalia.Sanches354");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Amalia701102");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Amalia70301");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ana_Lovato600");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ana_Razo702451");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ana_Robledo792138");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ana.Alvarado571316");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ana65612");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ana90502");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaLuisa_Archuleta1999");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaLuisa_Fierro142475");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaLuisa_Torrez351583");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaLuisa.Lira1728");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaLuisa.Quiros421612");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaLuisa.Serna398");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaLuisa22242");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaLuisa22922");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaLuisa811915");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaMaria_Agosto502004");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaMaria_Corona1469");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaMaria_Pina2470");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaMaria.Alaniz2393");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaMaria.Arevalo942001");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaMaria.Arias1324");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaMaria.Avila702");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaMaria.Benitez83");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaMaria.Quinta1676");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaMaria.Quintairos172244");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaMaria37707");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaMaria45548");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaMaria50856");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaMaria542354");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaMaria921526");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaSofia_Calvillo83505");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaSofia_Kanea321974");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaSofia_Solano521387");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaSofia.Escobar383");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaSofia121547");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaSofia171561");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaSofia4490");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaVictoria_Mora91983");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AnaVictoria.Solano342058");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Andrea_Baeza1720");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Andrea.Duran821117");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Andrea.Puga1502");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Andrea.Zapata682199");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Andrea232366");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Andres_Corral891454");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Andres_Karen613");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Andres_Xiana62799");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Andres.Farias1517");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Andres.Jasso871590");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Andres.Melgar1372");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Andres321298");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Andres5835");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Andres74714");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Andres911495");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Angela_Alanis478");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Angela_Balderas98636");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Angela_Florez321598");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Angela_Huerta156");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Angela_Parra201186");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Angela.Delafuente741335");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Angela.Iglesias931480");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Angela.Kanea61933");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Angela.Kara201080");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Angela.Valentin281231");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Angela.Villalpando122052");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Angela.Villareal157");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AngelDaniel_Otero58980");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AngelDaniel_Saiz1739");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AngelDaniel.Zambrano1520");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AngelDaniel38584");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AngelDaniel431796");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AngelDaniel50577");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AngelDaniel561352");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AngelDaniel721692");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AngelGabriel_Pantoja342055");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AngelGabriel_Vaca1268");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AngelGabriel_Villarreal461810");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AngelGabriel.Gollum80117");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AngelGabriel.Terrazas244");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AngelGabriel.Xacon512245");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AngelGabriel15937");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AngelGabriel41393");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AngelGabriel481292");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "AngelGabriel641941");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Anita.Beltran2123");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Anita.Cerda301957");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Anita.Ojeda708");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Anita.Ramirez88889");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Anita.Verduzco82728");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Anita122424");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Anita21375");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Anita241655");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Anita43322");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Anita852274");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Antonia_Barrios79621");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Antonia_Cortes45954");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Antonia_Quintana2622");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Antonia_Rios621153");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Antonia.Arana935");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Antonia.Covarrubias411442");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Antonia.Melgar2089");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Antonia.Quintairos851345");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Antonia.Sanchez876");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Antonia451981");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Antonia66280");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Antonio_Arreola80829");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Antonio.Laureano1797");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Antonio.Montemayor1156");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Antonio592352");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Antonio61375");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Antonio72494");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Antonio831103");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Araceli_Manzanares872237");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Araceli_Quinonez699");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Araceli.Arriaga44174");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Araceli.Lugo321379");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Araceli.Tapia491704");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Araceli.Villagomez1780");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Araceli542057");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ariadna_Arredondo1175");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ariadna_Cortes775");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ariadna_Quinones771");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ariadna.Adorno211040");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ariadna.Casillas58134");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ariadna.Ocampo92501");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ariadna.Ortega41105");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ariadna.Yami14687");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ariadna.Zamora395");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ariadna291142");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ariadna40629");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ariadna60663");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Armando_Kardachesoto201566");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Armando_Melendez801940");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Armando_Romo2063");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Armando.Meza951240");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Armando.Sisneros791");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Armando15904");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Armando19665");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Arturo_Patino953");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Arturo_Pena758");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Arturo_Vergara2050");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Arturo.Gonzalez38424");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Arturo.Miranda206");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Arturo212340");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Arturo231165");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Axel_Lara811200");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Axel.Balderas932276");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Axel.Cabrera1687");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Axel.Quesada880");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Axel.Rojas77795");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Axel.Velasco443");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Axel181595");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Axel201219");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Axel582003");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Barbara_Carrera67833");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Barbara_Serna64");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Barbara.Alcala2449");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Barbara.Archuleta781769");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Barbara.Venegas1373");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Barbara312070");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Barbara38648");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Barbara53554");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Barbara861312");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Beatriz_Fernandez74515");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Beatriz_Villanueva2399");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Beatriz_Zuniga192465");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Beatriz.Arce1677");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Beatriz.Godinez2680");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Beatriz.Lozada232331");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Beatriz0932");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Beatriz31205");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Beatriz50722");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Beatriz691322");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Beatriz721833");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Benito_Pantoja644");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Benito_Rubio2035");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Benito.Laboy901488");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Benito.Santana891260");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Benito.Tamayo1756");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Benito.Tijerina951455");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Benito61990");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Benito64278");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Benito741950");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Benjamin_Espinal1052");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Benjamin_Iglesias2469");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Benjamin_Trejo1707");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Benjamin.Linares482408");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Benjamin.Rosado101012");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Benjamin711347");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Benjamin861201");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Bernardo_Guevara638");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Bernardo_Romero691814");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Bernardo.Rivas531841");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Bernardo.Vargas1133");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Bernardo191168");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Bernardo241827");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Bernardo641033");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Berta_Arenas1582");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Berta_Avalos311382");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Berta_Barrientos77330");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Berta_Guzman1670");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Berta_Ochoa2309");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Berta.Molina33124");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Berta13179");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Berta252161");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Berta70716");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Berta95153");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Blanca.Covarrubias41277");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Blanca.Menendez1070");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Blanca.Robles0617");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Blanca.Tamez911299");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Blanca02278");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Blanca45750");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Blanca482252");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Blanca6247");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Blanca942013");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Brandon_Aguilera2379");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Brandon.Alfaro506");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Brandon.Barajas332175");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Brandon.Kaplan2462");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Brandon.Marrero137");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Brandon.Rosales531925");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Brandon.Villarreal551732");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Brandon35915");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Brayan_Soliz521773");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Brayan.Aguirre1211");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Brayan.Altamirano14471");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Brayan.Lovato406");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Brayan25659");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Brayan312149");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Brayan601174");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Brayan792201");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Brayan831606");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Camila_Delacruz314");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Camila_Delapaz70");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Camila.Cintron489");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Camila452164");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Camila572263");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Camila782108");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Caridad_Mateo1604");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Caridad.Alaniz1178");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Caridad222341");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carla_Olvera45328");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carla_Tamayo441862");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carla.Jaime126");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carla.Valdes411264");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carla122485");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carla16149");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carla73948");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carlos_Olmos482403");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carlos_Pichardo1966");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carlos_Roybal1049");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carlos_Toro890");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carlos_XairoBelmonte564");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carlos35940");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carlos86697");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carlos892166");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carlos9410");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carlota_Yebra1433");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carlota.Feliciano11242");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carlota.Merino68921");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carlota171449");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carlota181123");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carlota201902");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carlota621678");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carlota9273");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carmen_Ojeda47561");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carmen_Torrez172061");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carmen.Ramos37238");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carmen.Sanabria1334");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carmen21256");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carmen41126");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carmen452431");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carmen48774");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carmen701007");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carolina_Brito669");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carolina_Guerrero79368");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carolina_Kindelan86363");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carolina_Vallejo501402");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carolina.Beltran582212");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carolina.Cano1644");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carolina.Collazo46165");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carolina.Olivas9174");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carolina.Ontiveros0255");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carolina.Quinterocruz572499");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carolina12540");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carolina702423");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Carolina91770");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Catalina_Alcala2346");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Catalina_Caban392204");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Catalina_Cruz691155");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Catalina_Estrada891456");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Catalina.Flores40108");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Catalina.Segovia99234");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Catalina291519");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Catalina44914");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cecilia_Cantu1980");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cecilia_Hernadez2478");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cecilia.Bahena1837");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cecilia.Yago432005");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cecilia22642");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cecilia542321");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cesar_Esquivel9620");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cesar_Henriquez131404");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cesar_Valladares2128");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cesar_Veliz841665");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cesar.Haro37655");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cesar.Olvera2344");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cesar.Ortega551");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cesar24945");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cesar461560");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cesar52359");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cesar62173");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Clara_Segura1022");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Clara.Aranda537");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Clara.Cervantes263");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Clara.Urbina421857");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Clara581834");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Clara91279");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Claudia_Concepcion251537");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Claudia_Urbina81898");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Claudia.Benavides191618");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Claudia.Espinal64329");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Claudia.Guillen181");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Claudia.Marroquin1710");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Claudia791006");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Claudia851342");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Claudia92258");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Claudio_Casas621430");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Claudio_Duarte1778");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Claudio.Cruz281291");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Claudio.Porras2490");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Claudio.Sanchez851746");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Claudio.Tovar16557");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Claudio652044");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Clemente_Tamayo841412");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Clemente.Sauceda711934");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Clemente.Xenia731144");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Clemente322117");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Clemente65658");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Clemente941301");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Concepcion_Urbina93464");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Concepcion_Valdez53449");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Concepcion.Yanez428");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Concepcion.Ybarra1255");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Concepcion328");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Concepcion701027");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Concepcion881914");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Concepcion901118");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Conchita_Aguirre265");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Conchita.Ojeda8691");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Conchita921359");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cristian_Banda451635");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cristian_Solis402363");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cristian.Meza907");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cristian121891");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cristian71463");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cristina_Agosto496");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cristina_Koenig463");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cristina_Rosario229");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cristina_Tejada763");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cristina40640");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cristina841325");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cristina981749");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cristina991876");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cristobal_Amador1558");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cristobal_Coronado13781");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cristobal_Jasso791928");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cristobal_Navarrete23986");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cristobal_Otero1214");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cristobal_Yanez565");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cristobal.Alarcon1807");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cristobal.Ortega60176");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cristobal.Vega1496");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cristobal502059");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cristobal581471");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Cristobal62380");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Damian_Becerra731332");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Damian_Cortez48512");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Damian_Reyna2160");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Damian21639");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Damian231713");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Damian511905");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Damian601423");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Damian741694");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Daniel_Palacios1530");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Daniel_Sanabria43759");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Daniel_Trujillo721916");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Daniel.Aparicio161202");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Daniel.Gurule311195");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Daniel.Munoz982");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Daniel.Negron2099");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Daniel.Rios32138");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Daniela_Caraballo62944");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Daniela_Correa2205");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Daniela_Gracia2303");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Daniela_Madera1651");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Daniela_Ruelas35410");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Daniela_Sepulveda742332");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Daniela_Zayas222094");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Daniela.Roybal81011");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Daniela121368");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Daniela272389");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Daniela372064");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Daniela81773");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Daniela831964");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Daniela961848");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "David_Ledesma97297");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "David_Nieto1425");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "David_Salcedo691396");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "David.Briseno223");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "David.Canales1185");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "David.Esquivel93504");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "David.Montenegro87397");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "David.Montoya2229");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "David.Urena462021");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "David.Valdes641931");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "David24485");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "David2616");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "David692025");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "David951882");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Debora_Alaniz91203");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Debora_Elizondo24");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Debora_Zepeda1551");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Debora.Barreto2370");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Debora.Carranza781276");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Debora.Dominquez261284");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Debora591328");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Debora901114");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Diana_Magana1740");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Diana_Velasquez2215");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Diana_Velez90731");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Diana_Zapata2085");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Diana.Matias40838");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Diana31642");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Diana711246");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Diana741840");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Diana991829");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Diego_Alonso331820");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Diego_Alvarado77591");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Diego_Madrigal22302");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Diego_Rocha17568");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Diego_Saldana191895");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Diego.Cedillo1341");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Diego55447");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Diego732216");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Diego802227");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Dolores.Corrales1145");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Dolores.Padilla413");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Dolores.Rangel45192");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Dolores.Tello652009");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Dolores62225");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Dolores691429");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Dolores90441");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Dorotea_Candelaria2148");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Dorotea_Casares516");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Dorotea_Figueroa2207");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Dorotea.Amador941");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Dorotea.Hernandes302");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Dorotea.Marroquin679");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Dorotea21826");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Dorotea732002");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Dorotea77299");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "DulceMaria.Godinez36973");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "DulceMaria.Olivas1512");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "DulceMaria491636");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "DulceMaria51424");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "DulceMaria8127");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Eduardo_Galvez250");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Eduardo_Velasco892220");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Eduardo.Serrano2249");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elena_Espinosa3");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elena_Matias461003");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elena.Beltran291139");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elena.Camacho2432");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elena.Corral591580");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elena.Valdez727");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elena1171");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elena19872");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elena442152");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elena561196");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elena57580");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elena838");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elias_Cadena1951");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elias_Esquibel411907");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elias_Lucio899");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elias_Solorio831858");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elias_Yanez1089");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elias_Yebra262178");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elias.Alvarez02495");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elias.Gomez362163");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elias.Pineda862023");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elias202308");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elias90733");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elisa_Cepeda2401");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elisa_Delgadillo151771");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elisa_Nava1952");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elisa_Urbina352049");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elisa.Chavarria345");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elisa.Chavez2284");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elisa.Suarez221127");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elisa23373");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elisa8326");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elisa841141");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elizabeth_Cavazos63110");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elizabeth_Kara341794");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elizabeth_Koenig83970");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elizabeth_Mateo121271");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elizabeth.Cordova2426");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elizabeth.Iglesias2230");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elizabeth.Razo921922");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elizabeth.Tovar652");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elizabeth571574");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elizabeth78475");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elizabeth81742");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elizabeth822371");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Eloisa_Monroy01826");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Eloisa_Muniz46995");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Eloisa_Rascon981346");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Eloisa.deAnda852041");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Eloisa.Palomino1911");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Eloisa.Yunta1427");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Eloisa101");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Eloisa36843");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Eloisa382412");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Eloisa421280");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Eloisa431734");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Eloisa52723");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elsa_Delacruz298");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elsa_Pabon47712");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elsa_Saiz602377");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elsa_Vallejo591045");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elsa_Vargas2477");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elsa_Zambrana612090");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elsa.Gurule59458");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elsa.Lugo160");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elsa.Olivas1472");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elsa.Pulido602151");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elsa251943");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elsa781818");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elsa91542");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elvira_Munoz501107");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elvira.Alonso221");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elvira.Bonilla31285");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elvira.Mejia1005");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elvira.Sanchez1380");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elvira1350");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elvira301458");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elvira52943");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Elvira852323");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emilia_Alcala51483");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emilia_Valle1100");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emilia242373");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emilia25531");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emilia702382");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emilia852146");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emilia872236");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emiliano_Alarcon792182");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emiliano_Altamirano852105");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emiliano_Delarosa2027");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emiliano_Delatorre86306");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emiliano_Loera841242");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emiliano_Munguia32195");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emiliano_Tovar16202");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emiliano1994");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emiliano6462");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emilio_Aguirre671439");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emilio_Cavazos142445");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emilio_Coronado241320");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emilio_Magana40427");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emilio_Rangel2479");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emilio_Rendon1555");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emilio.Carrion194");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emilio.Marin75159");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emilio.Santiago819");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emilio13704");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emilio191520");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emilio55172");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emilio8881");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emilio91688");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emilio922153");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emily_Colunga9227");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emily_Ledesma162435");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emily_Montero454");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emily_Zamudio30605");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emily.Curiel1955");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emily141189");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emily341844");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emily631688");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emily802114");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emily862106");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emmanuel_Quiros871909");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emmanuel_Tirado291714");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emmanuel_Ulibarri4488");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emmanuel.Corral79920");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emmanuel.Gallardo1516");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emmanuel.Gracia751774");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emmanuel.Jaimes20598");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emmanuel.Pedroza694");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emmanuel84417");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Emmanuel89331");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Enrique_Madera2266");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Enrique_Olvera571459");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Enrique_Renteria222066");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Enrique.Barrera2336");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Enrique.Leon45583");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Enrique.Rubio1484");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Erick.Palomo2460");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Erick.Zaragoza2484");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Erick40204");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Erick431578");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Erick571948");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Erick61059");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ernesto_Quiroz2801");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ernesto_Tijerina1864");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ernesto_Vera531157");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ernesto.Benavides216");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ernesto.Sevilla631286");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ernesto.Varela1513");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ernesto49287");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ernesto7184");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ernesto741968");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esmeralda_Arce1991");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esmeralda_Feliciano1617");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esmeralda_Jaimes441431");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esmeralda_Rosales1421");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esmeralda.Barragan401545");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esmeralda.Gallardo75385");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esmeralda.Guardado38378");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esmeralda.Rolon602240");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esmeralda50351");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esmeralda941262");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esperanza_Tellez261351");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esperanza.Arreola9201");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esperanza.Cedillo1504");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esperanza.Reynoso501666");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esperanza.Tamayo72226");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esperanza304");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esperanza53434");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esperanza68597");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esperanza91888");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esteban_Bahena33997");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esteban_Parra61958");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esteban_Tamez1104");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esteban.Aparicio400");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esteban.Arteaga525");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esteban.Casares1793");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esteban.Escalante987");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esteban23767");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esteban42224");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esteban491889");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esteban792046");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Esteban7968");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Estefania_Mata3703");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Estefania.Cepeda5321");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Estefania.Cortez17266");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Estefania.Kanimal1311");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Estefania.Parra2167");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Estefania19681");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Estefania231946");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Estefania33869");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Estefania48231");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Estefania521428");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Estela_Badillo2385");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Estela_Puga851184");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Estela_Quezada481294");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Estela.Delao976");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Estela14459");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Estela2624");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Estela34161");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Estela5069");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ester_Chavarria311366");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ester_Orellana2234");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ester_Pineda1939");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ester.Pina382281");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ester481218");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ester631873");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ester661996");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ester8882");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Eva_Acevedo77323");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Eva_Calderon62761");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Eva_Nunez2430");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Eva_Paz431269");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Eva.Arredondo1718");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Eva.Corona2017");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Eva.Rosario151");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Eva.Solorio01709");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Eva371768");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Eva381764");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Evelyn_Blanco9339");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Evelyn_Chacon791745");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Evelyn_Nevarez212");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Evelyn.Mena2353");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Evelyn.Mora991418");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Evelyn112269");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Evelyn90560");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Fatima.Castro771786");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Fatima311575");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Fatima642037");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Federico_Agosto461181");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Federico_Aranda169");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Federico_Medina221633");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Federico_Villasenor1887");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Federico.Badillo981119");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Federico.Hernadez301413");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Federico.Kanimal73468");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Federico192104");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Federico342422");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Federico822223");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Felipe_Gaitan651");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Felipe.Esquibel1116");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Felipe.Mireles962233");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Felipe19185");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Felipe201886");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Felipe331179");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Felipe502190");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Fernando_Miramontes236");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Fernando.Arenas332");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Fernando.Luevano927");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Fernando181376");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Fernando45574");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "FernandoJavier_Arellano304");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "FernandoJavier_Sepulveda1715");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "FernandoJavier.Benavidez47998");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "FernandoJavier221099");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "FernandoJavier26465");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "FernandoJavier84313");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Florencia_Escalante50959");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Florencia_Reyna2127");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Florencia_Valdes251799");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Florencia.Cardenas771499");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Florencia.Garica381108");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Florencia.Montanez401420");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Florencia.Olivares1743");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Florencia.Varela31961");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Florencia401727");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Francisca_Batista42");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Francisca_Cepeda1813");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Francisca_Echevarria242253");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Francisca_Granados1854");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Francisca.Casillas369");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Francisca.Delgadillo845");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Francisca.Guajardo5837");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Francisca.Matias1483");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Francisca26798");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Francisca80495");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Francisca871254");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Francisco_Cervantez832134");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Francisco_Lomeli45955");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Francisco.Cotto1015");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Francisco.Toro1682");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Francisco152333");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Francisco241044");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Francisco381038");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Francisco531371");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Francisco702450");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Francisco881158");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Francisco98120");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Francisco991384");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "FranciscoJavier_Batista4467");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "FranciscoJavier_Bustamante241");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "FranciscoJavier_Quinterocruz51925");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "FranciscoJavier_Riojas1722");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "FranciscoJavier_Saavedra432024");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "FranciscoJavier.Gil536");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "FranciscoJavier.Nava801717");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "FranciscoJavier.Sedillo821273");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "FranciscoJavier121975");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "FranciscoJavier18854");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "FranciscoJavier51624");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "FranciscoJavier5384");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gabriel_Jasso198");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gabriel.Alonso381614");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gabriel.Garibay809");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gabriel.Melgar67902");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gabriel.Xiana534");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gabriel161885");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gabriel4423");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gabriela_Bermudez2461");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gabriela_Lira2411");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gabriela_Mares362098");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gabriela_Mendoza1926");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gabriela_Nieves122068");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gabriela.Alcantar1532");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gabriela.Alvarez3188");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gabriela.Aragon310");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gabriela.Mares1853");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gabriela.Negrete891213");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gabriela13804");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gabriela182033");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gabriela532210");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gabriela55342");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gael_Aguilera1378");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gael.Nevarez93808");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gael.Varela1629");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gael922056");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gael941703");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gerardo_Arevalo1821");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gerardo_Ayala441699");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gerardo_Baeza18");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gerardo_Duenas21656");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gerardo_Esparza441071");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gerardo_Molina1244");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gerardo.Bernal611986");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gerardo.Castillo30");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gerardo.Orta432360");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gerardo32252");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gerardo441855");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gerardo561447");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gerardo971356");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "German_Calvillo661083");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "German_Carrero621491");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "German_Preciado874");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "German.Carrion7014");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "German.Rosado2439");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "German.Urrutia74393");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "German.Viera98");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "German321737");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "German982421");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gilberto.Karen1063");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gilberto.Leon1563");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gilberto.Marin392365");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gilberto.Rolon68127");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gilberto.Sanches951004");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gilberto101124");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gilberto221457");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gilberto401056");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gilberto43717");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gilberto62011");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gloria_Aguilera1310");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gloria_Ayala572448");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gloria_Correa2181");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gloria_Espino621293");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gloria_Xiana47390");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gloria.Baez87896");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gonzalo_Iglesias621489");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gonzalo_Roldan682375");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gonzalo.Chavarria1664");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gonzalo.Delarosa1485");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gonzalo.Sevilla7399");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gonzalo62755");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gonzalo76824");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Graciela_Arevalo725");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Graciela_Figueroa811");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Graciela_Olivas6455");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Graciela.Quintairos1163");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Graciela92491");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gregorio_Crespo15867");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gregorio.Castaneda1113");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gregorio981512");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Guadalupe_Cordero1392");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Guadalupe_Melgar964");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Guadalupe_Orta2180");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Guadalupe.Cardona877");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Guadalupe.Galarza650");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Guadalupe.Kardachesoto90103");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Guadalupe.Perea645");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Guadalupe.Trejo531689");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Guadalupe.Ulibarri951973");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Guadalupe351394");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Guadalupe651258");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Guadalupe782015");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Guillermina_Alvarez2261");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Guillermina.Quinterocruz691257");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Guillermina21571");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Guillermina26141");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Guillermo_Delafuente2255");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Guillermo_Guillen2279");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Guillermo.Lomeli74782");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Guillermo121806");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Guillermo352481");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Guillermo4952");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Guillermo94682");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gustavo_Delarosa224");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gustavo_Madera1912");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gustavo_Tafoya1954");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gustavo.Kanzaki931924");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gustavo.Terrazas934");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gustavo.Zabaleta92282");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gustavo121785");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gustavo161238");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gustavo242282");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Gustavo812096");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Hernan.Espinal820");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Hernan201881");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Hernan381020");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Hernan391281");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Hernan892179");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Homero_Alarcon2453");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Homero_Cadena97989");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Homero_Quintana1369");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Homero_Sanchez222");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Homero_Villalpando1708");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Homero.Espinal1815");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Homero.Gonzales571511");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Homero.Moreno868");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Homero.Quintana34522");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Homero71041");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Homero83208");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Horacio_Bernal609");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Horacio_Guzman291149");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Horacio_Lira111608");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Horacio.Arenas83267");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Horacio.Cavazos82715");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Horacio.Delarosa1232");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Horacio.Madera2459");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Hugo_Chavez241680");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Hugo.Betancourt5327");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Hugo.Manzanares1762");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Hugo.Sarabia1452");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Hugo01921");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Hugo11451");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ignacio_Oquendo2304");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ignacio.Alaniz201591");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ignacio.deAnda341508");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ignacio.Quezada626");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ignacio331436");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ignacio61648");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ignacio69481");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ignacio69586");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Iker_Alva132271");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Iker_Jaime1275");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Iker_Velez376");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Iker.Avalos2042");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Iker.Posada32324");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Iker57677");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Iker77641");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ines_Acuna492374");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ines_Alcantar37");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ines_Riojas83957");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ines_Rivera1065");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ines.Menendez461863");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ines.Nunez182083");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ines.Quiroz2159");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ines292186");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ines37592");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ines37897");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ines481803");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Irene_Gaona41721");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Irene1245");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Irene26466");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Irene50491");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Irene65407");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Irene972391");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isaac_Alcala262387");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isaac_Estrada1426");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isaac_Luevano1486");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isaac_Marroquin1739");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isaac.Apodaca1646");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isaac.Escalante1408");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isaac.Kranzsans661067");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isaac.Velasco1542");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isaac.Vigil1988");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isaac551509");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isaac642268");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isaac742018");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isaac811235");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isaac84967");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isaac911747");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isabel_Mireles952358");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isabel_Posada730");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isabel_Valverde391792");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isabel_Xenia104");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isabel.Gonzales2079");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isabel.Kranzsans232427");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isabel42043");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isabela_Velasquez2214");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isabela.Baez45");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isabela.Carrillo1037");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isabela.Rael1897");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isabela151274");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isabela94686");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isaias_Aguilera882241");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isaias_Badillo1008");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isaias_Corrales89974");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isaias_Polanco2026");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isaias.Hidalgo271960");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isaias.Tamez751784");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isaias.Ulibarri2277");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isaias13251");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isaias20664");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isaias621787");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Isaias86558");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Israel_Kara2194");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Israel_Venegas2364");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Israel.Alvarez863");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Israel.Barraza469");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Israel26338");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Israel522289");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Israel682286");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Israel771212");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Israel891711");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ivan_Gil1252");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ivan_Mondragon38726");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ivan_Yago1878");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ivan.Casas21232");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ivan.Mireles1971");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ivan.Montoya691726");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ivan.Quintairos284");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ivan.Saiz89435");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ivan.Velez878");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ivan.Zayas48813");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ivan301684");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ivan561343");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ivan57116");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ivan651154");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ivanna_Esquibel2142");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ivanna_Guerra902088");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ivanna_Pelayo701527");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ivanna_Zayas681192");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ivanna.Duarte672368");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ivanna.Villegas2343");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ivanna.Zambrana193");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ivanna231832");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ivanna271874");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ivanna53105");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ivanna841166");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jacobo_Abreu1399");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jacobo_Ocampo291407");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jacobo_Olivera15107");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jacobo.Castaneda521870");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jacobo.Karan1197");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jaime_Alaniz66926");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jaime_Laboy421700");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jaime_Mateo79283");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jaime.Paz58274");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jaime.Sandoval321953");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jaime.Urias768");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Javier.Lara9562");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Javier.Verdugo657");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Javier.Yanes492");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Javier37581");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Javier591337");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jazmin_Delafuente522217");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jazmin_Flores92958");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jazmin.Muro1525");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jazmin.Velez58409");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jazmin23619");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jazmin28784");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jazmin542137");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jazmin71290");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jennifer_Montez1990");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jennifer_Regalado939");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jennifer.Cotto1679");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jennifer68211");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jennifer812275");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jeronimo_Martinez2150");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jeronimo.Jasso902185");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jeronimo.Karan792305");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jeronimo.Karen331021");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jeronimo.Leon71240");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jeronimo.Najera592168");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jeronimo.Zaragoza59900");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jeronimo1696");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jeronimo89394");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jeronimo932228");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jesus_Galvez301657");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jesus_Zayas738");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jesus.Gaytan40566");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jesus252078");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jesus40125");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jimena_Armas541695");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jimena_Ferrer1013");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jimena_Saldana36855");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jimena.Barreto1002");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jimena31305");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jimena681667");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jimena781962");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Joaquin_Armijo29783");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Joaquin_Cornejo82047");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Joaquin_Kano1278");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Joaquin_Rangel1288");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Joaquin.Krasnova1731");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Joaquin59528");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Joaquin67131");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Joaquin862381");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Joaquin871898");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jorge.Leiva17136");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jorge.Rivera2010");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jorge.Villareal971577");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jorge631401");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jorge72048");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jorge851546");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JorgeLuis_Espino2218");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JorgeLuis_Mesa112");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JorgeLuis_Tamez262192");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JorgeLuis.Acuna1265");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JorgeLuis.Benavides692254");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JorgeLuis.Casas392");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JorgeLuis.Padilla42409");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JorgeLuis.Toledo291572");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JorgeLuis131319");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JorgeLuis412211");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jose_Acuna1801");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jose_Castaneda2474");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jose_Gonzalez2030");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jose_Grijalva556");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jose_Montemayor2438");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jose.Quinonez63975");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jose.Quintero512203");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jose54839");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jose59517");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jose72443");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jose85634");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Jose921018");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseAntonio_Gaona98411");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseAntonio_Kadarrodriguez772213");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseAntonio_Ponce2112");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseAntonio_Prado2338");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseAntonio_Quintana744");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseAntonio44576");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseAntonio751182");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseDaniel_Cadena34");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseDaniel_Matos917");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseDaniel_Quezada851078");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseDaniel_Salcedo23852");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseDaniel.Cavazos415");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseDaniel.Covarrubias57552");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseDaniel.Mendez681622");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseDaniel.Velez12379");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseDaniel361770");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseDaniel431129");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseDaniel70729");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseDaniel88344");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseDaniel97831");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseEduardo_Batista1267");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseEduardo_Olivo1477");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseEduardo_Trejo91779");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseEduardo.Arriaga921767");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseEduardo.Hinojosa1600");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseEduardo.Longoria857");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseEduardo2442");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseEmilio_Almanza52");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseEmilio_Blanco2468");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseEmilio_Cazares332287");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseEmilio.Bernal685");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseEmilio.Burgos333");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseEmilio.Carranza2443");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseEmilio.Sierra22147");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Josefina_Barrientos10106");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Josefina_Manzanares1327");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Josefina_Olvera371034");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Josefina.Brito651623");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Josefina.Covarrubias37972");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Josefina.Matos994");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Josefina.Melendez832372");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Josefina86788");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseLuis.Casas38357");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseLuis.Lucero2196");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseLuis.Zelaya9425");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseLuis14100");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseLuis211283");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseLuis21535");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseLuis94575");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseMaria_Barajas294");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseMaria_Godinez97184");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseMaria_Lemus331904");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseMaria.Naranjo567");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseMaria.Rojas62416");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseMaria10239");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseMaria262091");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseMaria27170");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseMaria332494");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseMaria74678");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseMiguel_Arroyo370");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseMiguel_Galindo2292");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseMiguel_Garay62853");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseMiguel_Zavala831336");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseMiguel.Cruz1908");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseMiguel.Kamat851367");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseMiguel.Varela6833");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseMiguel64133");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JoseMiguel911625");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Juan_Jaramillo641047");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Juan_Narvaez111884");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Juan.Alcaraz372454");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Juan.Garica1637");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Juana_Acosta97380");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Juana_Caraballo2285");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Juana_Mena746");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Juana_Santillan90186");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Juana_Segovia607");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Juana_Sevilla261730");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Juana.Karen2136");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Juana.Maestas232183");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Juana.Munoz15812");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Juana11445");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Juana59851");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JuanCarlos_Barrera1160");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JuanCarlos_Cedillo56164");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JuanCarlos_Galvez92599");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JuanCarlos_Portillo1019");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JuanCarlos.Teran991641");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JuanCarlos.Valdes281601");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JuanCarlos2807");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JuanCarlos3740");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JuanCarlos992464");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JuanManuel.Ferrer45555");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JuanManuel.Kanea441663");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JuanManuel.Olvera1132");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JuanManuel.Palacios841977");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JuanManuel801869");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JuanPablo_Armendariz7758");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JuanPablo.Benavides622");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JuanPablo.Quintairos631");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JuanPablo.Saucedo991903");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JuanPablo.Valenzuela711");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JuanPablo451544");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JuanPablo6235");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Julia_Vergara51433");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Julia.Valentin412028");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Julia651845");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Julia701936");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Julieta_Bustos2312");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Julieta_Martinez11");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Julieta_Parra905");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Julieta_Tamez2294");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Julieta.Adorno73");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Julieta.Gallardo542124");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Julieta.Kadarrodriguez431675");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Julieta.Rincon1523");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Julieta67325");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Julio_Mayorga291949");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Julio.Bermudez2031");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Julio.Irizarry1492");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Julio.Laboy602480");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Julio.Medina241607");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Julio501177");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Julio552492");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JulioCesar_Carrion752298");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JulioCesar_Frias341969");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JulioCesar_Kanea1220");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JulioCesar_Lira893");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JulioCesar_Luevano4831");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JulioCesar.Ballesteros301290");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JulioCesar.Padron1690");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JulioCesar.Porras1856");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "JulioCesar721654");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Kevin_Arias60847");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Kevin_Holguin82806");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Kevin.Echevarria431068");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Kevin.Padilla412483");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Kevin45800");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Kevin57356");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Kimberly_Quevedo1522");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Kimberly_Rendon49");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Kimberly_Saenz82324");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Kimberly.Meza1087");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Kimberly.Valenzuela252313");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Kimberly221331");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Kimberly86455");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Kimberly902051");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Laura.Moreno17742");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Laura491093");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Laura50293");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Laura592110");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Laura91363");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Leonardo_Bahena1473");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Leonardo_Crespo542356");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Leonardo_Sauceda1467");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Leonardo_Xana2316");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Leonardo.Cardenas2200");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Leonardo.Carranza18757");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Leonardo.Espinal441066");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Leonardo.Xicoy371729");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Leonor_Escobar1411");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Leonor_Montalvo178");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Leonor.Agosto23966");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Leonor.Godoy1036");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Leonor.Karan261859");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Leonor.Tello87473");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Leonor252188");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Leonor63719");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Leticia.Avila1025");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Leticia.Bustos526");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Leticia.Casarez1611");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Leticia.Kaplan1188");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Leticia.Regalado523");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Leticia.Rodriquez731871");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Leticia.Zepeda32747");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Leticia1672");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Leticia311798");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Leticia65862");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lilia_Carreon121339");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lilia_Leiva30451");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lilia_Montanez78482");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lilia.Vargas90720");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lilia292388");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lilia52780");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lilia652339");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lilia701385");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lilia82487");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Liliana_Gollum1315");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Liliana_Mata912248");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Liliana_Valdivia652444");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Liliana.Acosta1839");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Liliana.Gamez621237");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Liliana.Quintana562493");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Liliana1048");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Liliana42189");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Liliana81626");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lizbeth_Kano1476");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lizbeth.Cuellar941716");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lizbeth.Kortahernandez371374");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lizbeth.Navarrete472172");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lizbeth.Salazar1017");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lizbeth12858");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lola_Benitez2395");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lola_Gaona247");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lola_Saucedo11381");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lola.Alaniz1896");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lola.Jaimes822");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lola.Quinta701282");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lola.Trejo1588");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lola.Urbina312247");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lola262080");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lola331466");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lola502300");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lola581350");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lola622243");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lorena_Atencio928");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lorena_Gaytan1539");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lorena_Pacheco601835");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lorena.Arteaga2345");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lorena.Kyra301035");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lorena.Matias381536");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lorena.Medina7689");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lorena.Nava1233");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lorena.Nevarez1463");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lorena.Rosales27698");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lorena38292");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lorena56777");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lorena752145");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lorenzo_Almonte2130");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lorenzo_Gutierrez72144");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lorenzo_Montano43129");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lorenzo_Pedraza924");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lorenzo_Quevedo402386");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lorenzo.Barrios50");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lorenzo.Duarte432319");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lorenzo.Ibarra2209");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lorenzo.Robles756");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lorenzo241631");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lorenzo531817");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lorenzo87999");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lourdes_Munguia766");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lourdes_Robledo119");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lourdes.Concepcion115");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lourdes.Feliciano172433");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lourdes.Maestas522000");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lourdes.Rivero191");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lourdes122297");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lourdes1286");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lourdes231243");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lourdes57602");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lourdes801828");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lourdes851338");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lucas_Karen1147");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lucas_Negron522310");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lucas.Lozada941736");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lucas.Rojas92365");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lucas49217");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lucas94594");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lucas97446");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lucia_Amador551029");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lucia_Kortahernandez88213");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lucia_Preciado883");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lucia_Roldan24903");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lucia.Barrera12530");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lucia.Cisneros167");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lucia.Deleon1422");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lucia.Naranjo162280");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lucia15827");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Lucia84364");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luis_Nieto99549");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luis_Ybarra1115");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luis_Zamarripa639");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luis.Alaniz268");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luis.Gomez453");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luis.Leyva960");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luis.Sauceda2425");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luis.Zambrana9277");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luis1032");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luis441630");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luis612416");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luis77623");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luisa_Najera349");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luisa.Ceballos1206");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luisa.Paez81358");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luisa.Valentin4229");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luisa.Zayas18614");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luisa01753");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luisa1513");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luisa211672");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luisa671938");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luisa88113");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisAngel_Otero731838");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisAngel_Pedroza571652");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisAngel.Acevedo502155");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisAngel262221");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisAngel57432");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisAngel91401");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisAngel99334");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisFernando_Colunga2325");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisFernando_Gollum301585");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisFernando_Padilla5279");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisFernando_Rojas491461");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisFernando_Velasco1054");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisFernando.Curiel49311");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisFernando.Fernandez11023");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisGabino_Castillo4978");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisGabino_Nazario881110");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisGabino.Delacruz661388");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisGabino60511");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisGabino931693");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisMiguel_Acevedo1061");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisMiguel_Aviles1014");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisMiguel_Montez432100");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisMiguel_Montez52414");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisMiguel_Villarreal41844");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisMiguel.Barrera2441");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisMiguel.Delagarza1042");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisMiguel.Valencia711945");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisMiguel10860");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisMiguel25865");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisMiguel402402");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisMiguel58479");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "LuisMiguel802184");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luz_Bravo789");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luz_Negron1136");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luz_Ulloa1705");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luz.Brito57695");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luz.Escamilla191861");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luz.Guzman22949");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luz.Melgar181985");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luz.Tamayo2238");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luz612400");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Luz981062");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Magdalena_Chavarria81158");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Magdalena_Cortes2173");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Magdalena_Olivares2250");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Magdalena.Madera95946");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Magdalena29797");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Magdalena592440");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Magdalena952296");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Magdalena97388");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Manuel_Alanis15");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Manuel_Longoria1140");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Manuel.Badillo40308");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Manuel.Rosales41713");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Manuel.Tapia439");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Manuel1244");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Manuel631524");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Manuela.Contreras366");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Manuela.Esparza2008");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Manuela.Salinas862326");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Manuela.Yanes474");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Manuela0402");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Manuela841223");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marcela_Guardado231782");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marcela_Quinterocruz2265");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marcela.Alcala2135");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marcela.Cerda1913");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marcela.Torres37155");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marcela.Valle191668");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marcela.Xicoy438");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marcela111390");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marcela771194");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MarcoAntonio_Riojas331824");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MarcoAntonio.Velazquez472");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MarcoAntonio.Zamarripa371919");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MarcoAntonio542092");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MarcoAntonio832334");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marcos_Alonso491661");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marcos_Baeza56254");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marcos_Karan871");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marcos_Koenig91573");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marcos_Krauelnatera912072");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marcos01724");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marcos442376");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marcos581409");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marcos872482");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Margarita_Almonte521169");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Margarita_Duran6752");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Margarita_Pelayo101766");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Margarita_Saavedra7118");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Margarita_Tejada1090");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Margarita_Teran371152");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Margarita.Ulloa1993");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Margarita.Valencia518");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Margarita701096");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Margarita83823");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Maria_Garza419");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Maria_Prieto58745");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Maria.Miramontes841440");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Maria841543");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaCristina_Hurtado1932");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaCristina_Lemus1697");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaCristina_Ocampo590");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaCristina_Palomo482328");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaCristina_Ramon1593");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaCristina_Rodriguez20279");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaCristina_Solano3414");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaCristina.Carbajal1956");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaCristina.Delrio26");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaCristina182032");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaCristina961540");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariadeJesus19810");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariadeJesus54214");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariadeJesus55532");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariadeJesus581691");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariadeJesus812466");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariadeJesus89667");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariadelCarmen.Chacon550");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariadelCarmen.Zepeda1567");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariadelCarmen37627");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariadelCarmen96923");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariadelosAngeles_Mora2436");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariadelosAngeles_Olivares10480");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariadelosAngeles_Vega8360");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariadelosAngeles.Anguiano25374");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariadelosAngeles.Rojas1967");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariadelosAngeles.Torrez661534");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariadelosAngeles52390");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariadelosAngeles72156");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaElena_Aleman95315");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaElena_Jaimes559");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaElena_Lerma1435");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaElena_Marroquin551698");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaElena_Soto1125");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaElena.Banda1138");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaElena.Caballero1836");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaElena.Haro14437");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaElena.Pantoja521723");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaElena.Pena296");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaElena.Rael386");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaElena13128");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaElena542107");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaElena7082");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaEugenia_Castaneda1772");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaEugenia_Linares67861");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaEugenia.Macias2463");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaEugenia101446");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaEugenia211609");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaEugenia75418");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaFernanda_Arenas25684");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaFernanda_Resendez911721");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaFernanda332246");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaFernanda51349");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaFernanda5527");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaFernanda662410");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaFernanda79484");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaGuadalupe_Dominguez14938");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaGuadalupe_Gollum1553");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaGuadalupe_Luevano46849");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaGuadalupe_Manzanares321541");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaGuadalupe_Salazar1568");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaGuadalupe_Tapia541788");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaGuadalupe.Mora421");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaGuadalupe.Olvera396");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaGuadalupe19786");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaGuadalupe351647");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaGuadalupe581330");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaGuadalupe69785");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaGuadalupe84916");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaGuadalupe92447");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaJose_Garcia1210");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaJose_Reyes83303");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaJose.Chacon362");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaJose.Zamora2016");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaJose141750");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaJose231944");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaJose582476");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaJose791239");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaLuisa_Carrera671340");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaLuisa.Tejada82330");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaLuisa25748");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mariana_Cordova717");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mariana_Malave841775");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mariana.Esquivel901028");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mariana25582");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mariana771992");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mariano_Osorio861594");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mariano.Bernal1603");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mariano541398");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mariano992347");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaSoledad_Nunez2082");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaSoledad_Rivera2497");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaSoledad.Corona91765");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaSoledad.Serrato46930");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaSoledad90404");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaTeresa_Barrientos1571");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaTeresa_deAnda81804");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaTeresa_Granado151146");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaTeresa_Hidalgo0");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaTeresa.Cordero462075");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaTeresa.Prado977");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaTeresa352019");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaTeresa891112");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MariaTeresa93547");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Maricarmen_Aguilar348");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Maricarmen_Medina180");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Maricarmen_Melendez1616");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Maricarmen_Prieto932097");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Maricarmen.Casas187");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Maricarmen161039");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Maricarmen93460");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marilu_Ballesteros761092");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marilu.Jaquez653");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marilu.Kortajarena762074");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marilu.Pulido1683");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marilu.Rojo241303");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marilu.Solorzano2231");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marilu1888");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marilu312065");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marilu661599");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marilu83654");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mario_Carbajal291287");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mario_Velazquez512311");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mario.Bermudez123");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mario.Pagan500");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mario.Quintanilla1761");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mario152034");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marisol_Resendez2054");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marisol_Yanez47933");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marisol_Zambrano408");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marisol01979");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marisol772329");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marisol902129");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marisol98751");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marta_Lemus53546");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marta.Caraballo532398");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marta.Olmos189");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marta.Pichardo1060");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marta22272");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marta651318");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marta71942");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Marta91295");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Martin_Almanza01106");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Martin_Karan355");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Martin_Karem89343");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Martin_Xacon1333");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Martin_Yanez561289");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Martin.Alcala836");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Martin.Cavazos132");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Martin.Guerra202116");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Martin.Montez681226");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Martin.Sisneros18246");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Martin101959");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Martin29335");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Martin60166");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mateo.Carmona754");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mateo.Malave20676");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mateo.Marroquin831329");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mateo.Sanches78440");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mateo581438");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mateo671391");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mateo851899");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Matias_Terrazas909");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Matias_Ybarra359");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Matias.Armijo64319");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Matias.Bahena971");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Matias.Bustos01400");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Matias.Espino301529");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Matias.Gaytan44666");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Matias.Razo152197");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Matias17142");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Matias22");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Matias272437");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Matias50790");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Matias541638");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mauricio.Mascarenas382");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mauricio.Meraz4615");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Maximiliano_Caban391");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Maximiliano_Corral44257");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Maximiliano_Vallejo981453");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Maximiliano.Escobedo1584");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Maximiliano.Raya152");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Maximiliano732357");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mayte_Olivera53734");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mayte.Chavarria2270");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mayte.Garibay1490");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mayte.Heredia3754");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mayte.Urena2038");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mayte52378");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mayte78405");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Melany_Caraballo8569");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Melany_Centeno701304");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Melany_Muro951091");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Melany.Armas111831");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Melany.Lomeli12314");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Melany.Naranjo818");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Melany20361");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Melany931151");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Melany981531");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Melissa_Ayala1229");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Melissa_Lugo884");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Melissa_Mayorga2165");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Melissa_Moya0908");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Melissa_Ortega816");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Melissa_Perales1307");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Melissa_Romo2131");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Melissa_Rosado421825");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Melissa.Amador2067");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Melissa.Angulo1364");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Melissa.Deleon1358");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Melissa.Duran612007");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Melissa.Kamal34162");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Melissa.Rosado411437");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Melissa.Solano1970");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Melissa.Zayas1381");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Melissa57316");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Melissa65477");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Melissa8778");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mercedes_Adorno1263");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mercedes_Mireles76895");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mercedes_Quinterodelacruz601671");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mercedes.Arce668");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mercedes.Kadarrodriguez911285");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mercedes.Nevarez1719");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mercedes0796");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mercedes4209");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mercedes451690");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Mercedes921228");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Micaela_Covarrubias68792");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Micaela_Gil711203");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Micaela_Ledesma1217");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Micaela_Padron1865");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Micaela_Resendez95647");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Micaela_Solorio5509");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Micaela.Amador681361");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Micaela1097");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Micaela891441");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Micaela941497");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Miguel.deAnda841");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Miguel.Florez276");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Miguel.Grijalva819");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Miguel.Rojo311579");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Miguel61348");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Miguel802162");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MiguelAngel_Kanea1055");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MiguelAngel_Trujillo2458");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MiguelAngel.Contreras40");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MiguelAngel.Fonseca1296");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MiguelAngel191528");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MiguelAngel27387");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MiguelAngel41460");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "MiguelAngel64264");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Miranda.Kara1830");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Miranda.Kardachesoto2193");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Miranda.Montoya210");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Miranda332456");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Miranda71840");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Miranda93846");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Monica_Burgos1405");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Monica_Koenig1706");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Monica_Zaragoza821868");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Monica.Espinal521518");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Monica.Espino831051");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Monica.Rolon261791");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Monica.Rosales683");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Monica.Zabaleta831894");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Monica342406");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Monica9916");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Monserrat_Acuna99429");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Monserrat_Rodrigez1357");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Monserrat_Sanches220");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Monserrat_Solis2014");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Monserrat.Acevedo622154");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Monserrat.Aleman521475");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Monserrat.Feliciano741009");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Monserrat.Quintanilla34122");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Naomi.Baca1221");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Naomi.Ontiveros77981");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Naomi421632");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Naomi511674");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Natalia_Abrego151207");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Natalia_Arellano751552");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Natalia_Armas1842");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Natalia_Castillo652022");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Natalia_Corona65337");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Natalia_Duenas670");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Natalia_Jaime77243");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Natalia_Rojas835");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Natalia.Benavides1150");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Natalia.Bonilla141605");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Natalia.Karem912");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Natalia.Montalvo312");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Natalia.Olmos2301");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Natalia.Sosa1994");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Natalia.Valdes275");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Natalia.Zarate1410");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Natalia541610");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Natalia902264");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Nicolas_Hinojosa866");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Nicolas.Abrego1789");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Nicolas.Beltran151673");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Nicolas.Candelaria1755");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Nicolas.Carrera15834");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Nicolas.Loera2191");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Nicolas231464");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Nicolas42499");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Nicolas61215");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Nicolas78772");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Nicole_Marquez1640");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Nicole_Reyna121");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Nicole.Beltran232187");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Nicole.Ruiz1362");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Nicole231086");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Nicole261122");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Nicole46154");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Nicole521445");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Nicole54793");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Nicole831406");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Norma_Granado82996");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Norma_Olivarez769");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Norma.Batista842069");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Norma.Mojica544");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Norma90630");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Octavio_Figueroa391204");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Octavio_Ulibarri862141");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Octavio.Martinez91506");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Octavio.Pelayo1867");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Octavio.Vera891");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Octavio26660");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Octavio302471");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Octavio481748");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Octavio531224");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Octavio861615");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Olivia_Arteaga2111");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Olivia_Escobedo50336");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Olivia_Marrero831074");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Olivia_Olivo911976");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Olivia.Armendariz421354");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Olivia.Benavides1893");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Olivia13674");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Olivia52538");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Olivia641809");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Olivia91176");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Oscar_Cantu78760");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Oscar_Casarez2259");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Oscar_Correa99991");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Oscar_Villareal101650");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Oscar.Anaya902206");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Oscar.Aparicio2101");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Oscar.Mendoza140");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Oscar.Montenegro983");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Oscar951942");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Pablo.Alaniz646");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Pablo.Ruelas151470");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Pablo722335");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Pablo922429");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Paola_Delagarza2084");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Paola_Delgadillo201031");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Paola_Medina1241");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Paola.Coronado307");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Paola.Laureano2496");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Paola.Narvaez36295");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Paola13228");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Paola321658");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Paola37340");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Patricia_Carrillo972351");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Patricia_Guillen815");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Patricia_Ontiveros2488");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Patricia.Atencio2418");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Patricia.Corral91918");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Patricia.Serrato72140");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Patricia151900");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Patricia682384");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Patricia84183");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Patricio_Alcaraz852290");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Patricio_Chapa109");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Patricio_Murillo2093");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Patricio_Ordonez44724");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Patricio_Preciado968");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Patricio.Alvarado571131");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Patricio.Balderas841");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Patricio.Briseno787");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Patricio.Holguin731419");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Patricio.Kanaria360");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Patricio.Montemayor1097");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Patricio.Ramirez1549");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Patricio632446");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Paulina_Banda641000");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Paulina_Franco972260");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Paulina_Salinas1725");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Paulina.Aranda541");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Paulina.Berrios811653");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Paulina.Carvajal2012");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Paulina.Jiminez431");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Paulina.Lira372");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Paulina.Melgar92197");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Paulina.Nevarez781685");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Paulina352120");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Paulina691777");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Paulina791872");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Paulina92913");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Pedro_Alfaro11564");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Pedro_Barrios131781");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Pedro_Quintairos1048");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Pedro_Saucedo539");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Pedro.Navarro1199");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Pedro.Polanco5978");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Pedro.Roque7587");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Pedro272103");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Pedro661057");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Pedro99146");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Pilar_Arce2498");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Pilar_Chapa962");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Pilar_Henriquez101");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Pilar_Kanaria151043");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Pilar_Saenz596");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Pilar.Maldonado331208");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Pilar.Nunez2125");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Pilar.Prieto894");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Pilar.Serna1849");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Pilar242322");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Pilar371167");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Pilar61360");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Pilar91660");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rafael_Barrientos2256");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rafael_Berrios1317");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rafael_Herrera2428");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rafael.Florez1846");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rafael.Korta2396");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rafael.Kranzsans1414");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rafael01649");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rafael28762");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rafael3546");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rafael361620");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rafael391300");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rafael411415");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rafael6323");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rafael961432");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rafael98145");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ramiro.Alcaraz2039");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ramiro.Flores1802");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ramiro.Olivo45765");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ramiro.Vega602219");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ramiro.Vigil205");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ramiro351822");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ramiro89741");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ramiro93706");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ramiro981234");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ramon_Cardona63563");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ramon_Carrera57950");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ramon_Cordova841344");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ramon_Rodriguez1551");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ramon.Avila101847");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ramon.Vergara1627");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ramon171548");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ramon301053");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ramona_Becerra79430");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ramona_Mena652029");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ramona.Esquivel47608");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ramona561135");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Raquel_Merino859");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Raquel_Tovar1877");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Raquel.Montenegro572");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Raquel241030");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Raquel38643");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Raquel80848");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Raul_Blanco1987");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Raul_Solorzano811917");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Raul.Esquibel68261");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Raul.Gonzalez882071");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Raul.Tirado1851");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Raul30422");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Raul519");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Raul9735");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rebeca_Kanaria2257");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rebeca_Yunta309");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rebeca.Manzanares436");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rebeca181589");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rebeca5864");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rebeca75879");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rebeca881193");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Regina_Cervantez1634");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Regina_Mascarenas29249");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Regina.Covarrubias2348");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Regina.Garza2415");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Regina.Maestas1444");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Regina201081");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Regina88593");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Reina_Delapaz177");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Reina_Huixtlacatl1474");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Reina_Moya1077");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Reina_Paz346");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Reina.Aguilera64573");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Reina.Cazares202457");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Reina.Serrato503");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Reina101937");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Reina401808");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Reina641923");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Renata_Aparicio751930");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Renata_Meza2081");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Renata_Roybal1272");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Renata.Cordero91812");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Renata.Echevarria231998");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ricardo_Alejandro2361");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ricardo_Najera2171");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ricardo_Salcedo2036");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ricardo.Aguilar1026");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ricardo.Rodriquez1860");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ricardo731326");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ricardo791613");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ricardo871738");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Roberto_Botello922295");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Roberto.Barajas2126");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Roberto.Esparza1171");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Roberto.Padilla510");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Roberto381554");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Roberto921758");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rocio_Adorno4520");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rocio_Vela2434");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rocio_Zarate47931");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rocio.Acuna602222");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rocio.Colon1383");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rocio.Ocasio143");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rocio.Santillan92");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rocio39606");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rodrigo_Alvarado1128");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rodrigo_Nevarez2176");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rodrigo.Lozano1365");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rodrigo301148");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rodrigo51444");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rodrigo657");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rodrigo9618");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rodrigo96291");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rosa_Bravo519");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rosa_Delagarza425");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rosa_Nieves89457");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rosa_Ulibarri531929");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rosa.Cardona2077");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rosa.Varela72632");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rosa.Vela1662");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rosa0709");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rosa521879");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rosa55258");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rosalia.Aguayo3175");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rosalia321084");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rosalia711094");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rosalia78936");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rosalia82828");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rosalia9156");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "RosaMaria_Leiva347");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "RosaMaria_Rivas631075");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "RosaMaria_Teran130");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "RosaMaria.Calderon5557");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "RosaMaria.Tijerina288");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "RosaMaria36321");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "RosaMaria661733");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "RosaMaria68892");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "RosaMaria801783");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rosario_Melgar2020");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rosario_Rascon2489");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rosario_Sandoval2239");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rosario.Archuleta1256");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rosario.Gallegos472060");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rosario.Preciado331251");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rosario.Quezada901");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Rosario.Ulibarri1880");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ruben_Bahena462");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ruben_Zabaleta571515");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ruben.Fonseca231982");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ruben331741");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Salvador_Armendariz4601");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Salvador_Delatorre803");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Salvador_Haro5787");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Salvador_Huixtlacatl377");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Salvador_Mayorga35486");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Salvador_Villareal321416");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Salvador.Escamilla26371");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Salvador.Garica1910");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Salvador.Menchaca426");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Salvador141587");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Salvador281570");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Salvador46875");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Salvador82102");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Samuel_Pantoja42692");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Samuel_Valentin1487");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Samuel_Xana281050");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Samuel.Borrego513");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Samuel.Melendez226");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Samuel.Olivera711247");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Samuel.Saavedra984");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Samuel171596");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Samuel301248");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Samuel341046");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Samuel341073");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Samuel372455");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sancho_Carmona691109");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sancho_Guzman1058");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sancho_Holguin2251");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sancho_Munoz1314");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sancho_Tafoya1137");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sancho.Jurado672");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sancho.Ulibarri301249");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sancho281866");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sancho331191");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sancho672288");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Santiago_Delao57535");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Santiago_Delapaz1088");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Santiago_Lerma604");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Santiago_Osorio27389");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Santiago_Terrazas962232");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Santiago.Chapa992");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Santiago.Haro12198");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Santiago61700");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sara_Montez511082");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sara13553");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Saul_Luna51901");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Saul_Patino1465");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Saul_Riojas1920");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Saul.Sierra1306");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Saul.Yami737");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sebastian_Aviles870");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sebastian_Salcido872267");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sebastian.Rivera618");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sebastian.Villarreal1759");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sergio_Briseno873");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sergio.Correa812320");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sergio.Kara341323");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sergio.Orta529");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sergio302170");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sergio54218");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sergio571462");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sergio651308");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sergio901503");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Silvia_deAnda6595");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Silvia_Mayorga552087");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Silvia_Miranda632318");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Silvia_Pacheco942118");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Silvia_Serrato412174");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Silvia_Trujillo921751");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Silvia.Centeno561417");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Silvia.Nevarez199");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Silvia151481");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Silvia231164");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Silvia59286");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sofia_Luevano1187");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sofia_Ortega531507");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sofia.Mota721569");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sofia23497");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sofia32226");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sofia48507");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Soledad_Camarillo1984");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Soledad_Munguia90248");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Soledad_Paredes1754");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Soledad_Rendon2293");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Soledad_Xicoy1850");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Soledad.Longoria1450");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Soledad76111");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sonia_Alaniz94352");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sonia_Rosas2420");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sonia_Solorio2342");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sonia.Arguello150");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sonia.Herrera85144");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sonia.Peralta611995");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sonia.Rios215");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sonia271819");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sonia522473");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Sonia701180");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Susana_Prado1521");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Susana.Alonzo2073");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Susana.Caban7788");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Susana.Iglesias41795");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Susana292195");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Susana311565");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Susana41355");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Tadeo.Casillas902350");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Tadeo.Gallegos501686");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Tadeo.Marroquin3929");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Tadeo.Rodarte861309");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Tadeo17289");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Tadeo63395");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Teodoro_Vera710");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Teodoro.Baez9666");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Teodoro.Dominquez2045");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Teodoro.Melgar781448");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Teodoro.Naranjo163");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Teodoro.Parra732");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Teodoro752086");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Teresa_Casillas1562");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Teresa_Esparza470");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Teresa_Preciado625");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Teresa_Raya2291");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Teresa_Resendez95570");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Teresa_Sanabria94514");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Teresa_Viera985");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Teresa.Bahena0961");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Teresa.Cortes251134");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Teresa201597");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Teresa202158");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Teresa51918");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Teresa75701");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Teresa952355");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Timoteo_Fajardo1498");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Timoteo_Granados1980");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Timoteo.Florez21281");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Timoteo.Munoz251095");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Timoteo10139");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Tomas_Serna51016");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Tomas.Candelaria76");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Tomas.Leiva1816");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Tomas.Xiana1656");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Tomas491270");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Tomas511514");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Tomas60233");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Tomas98589");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Uriel_Cordova456");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Uriel_Gaytan85");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Uriel.Crespo93635");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Uriel.Lebron1763");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Uriel.Miramontes301173");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Uriel.Soliz662");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Uriel.Zapata2397");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Uriel962225");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Valentina_Robles979");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Valentina_Velasquez508");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Valentina42317");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Valentina801659");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Valentina82306");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Valeria_Covarrubias85498");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Valeria.Alonso791997");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Valeria.Cardona39");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Valeria171935");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Valeria432115");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Vanessa_Velasquez451890");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Vanessa.Casares89305");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Vanessa.Munguia2139");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Vanessa14403");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Vanessa671190");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Vanessa85260");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Vanessa911805");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Vanessa992327");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Veronica_Castaneda591261");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Veronica_Gutierrez81143");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Veronica_Toro965");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Veronica_Zamarripa69805");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Veronica.Puga4533");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Veronica.Urrutia242235");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Veronica43743");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Veronica502467");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Veronica571403");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Vicente_Galvan912486");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Vicente_Garay461");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Vicente_Ozuna1222");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Vicente.Fajardo1121");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Vicente.Pina632132");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Vicente.Rojo832119");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Vicente6575");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Vicente781101");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Victor_Heredia99842");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Victor_Macias1927");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Victor_Muro673");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Victor.Guerrero5320");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Victor.Pacheco771162");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Victor.Zabaleta921823");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Victor351906");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Victor912349");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Victor953");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Victoria_Arce781744");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Victoria_Centeno821");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Victoria_Guevara1493");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Victoria_Orta322157");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Victoria.Angulo1963");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Victoria.Muro896");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Victoria791581");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Victoria91216");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "VictorManuel_Montez2147");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "VictorManuel_Posada603");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "VictorManuel91494");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Virginia_Benavidez30353");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Virginia.Altamirano1377");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Virginia.Beltran1712");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Virginia.Blanco36272");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Virginia.Escobedo1681");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Virginia.Kyra59");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Virginia.Ocampo1505");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ximena_Arce988");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ximena_Korta1467");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ximena_Saldana8171");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ximena_Vela219");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ximena.Almonte1501");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ximena.Lovato70450");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ximena.Tejada312413");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Ximena64271");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "XimenaGuadalupe.Razo2053");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "XimenaGuadalupe.Sarabia2133");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "XimenaGuadalupe141266");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "XimenaGuadalupe8911");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "XimenaGuadalupe92947");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Xochitl_Aguilera181972");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Xochitl_Chavarria572436");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Xochitl_Santacruz1533");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Xochitl.Barreto351198");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Xochitl.Pantoja1250");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Xochitl.Saucedo420");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Xochitl.Villarreal381079");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Xochitl721947");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Xochitl74341");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Yamileth_Candelaria1253");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Yamileth_Vaca2405");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Yamileth_Vega661302");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Yamileth.Chacon493");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Yamileth.Palomo27317");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Yamileth.Pizarro1370");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Yamileth.Quesada51300");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Yamileth01843");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Yamileth4196");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Yamileth71832");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Yamileth742177");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Yaretzi_Escalante58675");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Yaretzi_Haro762452");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Yaretzi_Olivares6290");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Yaretzi.Aguayo1072");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Yaretzi.Matias55693");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Yaretzi.Negrete381111");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Yaretzi.Sanabria47585");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Yaretzi10262");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Yaretzi31367");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Yaretzi85910");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Yolanda.Becerra41892");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Yolanda.Verdugo993");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Yolanda55168");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Yolanda682367");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Zoe_Briseno2337");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Zoe_Bueno40718");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Zoe.Arriaga791521");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Zoe.Ramon61");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Zoe.Rolon391760");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Zoe40190");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "NombreUsuario",
                keyValue: "Zoe90906");
        }
    }
}
