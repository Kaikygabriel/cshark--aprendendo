namespace SalesWebMvc3.Models
{
    public class Departament
    {
        public Departament() { }

        public Departament(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }


        public string Name{ get; set; }
    }
}
