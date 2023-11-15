namespace BlazorPatternComposite.Data
{
     public class Apartment :Component
    {
        

        private List<Component> components = new List<Component>();


        public Apartment(string name, double square) : base(name,square) {  }
        

        

        public override void Add(Component component)
        {
            components.Add(component);
        }
        public override void Remove(Component component)
        {
            components.Remove(component);
        }
        public override void GetInfo()
        {
            
        }
    }
}
