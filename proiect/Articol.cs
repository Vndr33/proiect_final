using SQLite;


namespace proiect
{
    [Table("articol")]
    public class Articol
    {
        [PrimaryKey]
        [AutoIncrement]
        [Column("id")]
        public int Id_articol {  get; set; }

        [Column("titlu")]
        public string Titlu {  get; set; }

        [Column("autor")]
        public string Autor {  get; set; }

        [Column("continut")]
        public string Continut {  get; set; }
    }
}
