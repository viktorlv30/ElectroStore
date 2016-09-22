
namespace ElectroStore.Models
{
    public class Cabel : IGoods
    {
        //Id cable
        public int Id { get; set; }

        //Marks name
        public string Mark { get; set; }

        //Cross section of wire
        public string CrossSection { get; set; }

        //Producer of wire
        public string Producer { get; set; }

        //Price of each wire
        public double Price { get; set; }
        
        
    }
}