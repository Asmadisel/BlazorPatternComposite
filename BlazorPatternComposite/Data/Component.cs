namespace BlazorPatternComposite.Data
{
    abstract public class Component
    {
        protected string name;
        protected double square;

        public Component(string name, double square)
        {
            this.name = name;
            this.square=square;
        }

        public virtual void Add(Component component) { }
        public virtual void Remove(Component component) { }

        public virtual void GetInfo() 
        { 

        }
    }
}
