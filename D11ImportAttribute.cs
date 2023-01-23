namespace modernflatPJ1
{
    internal class D11ImportAttribute : Attribute
    {
        private string v;
        private string entryPoint;

        public D11ImportAttribute(string v, string EntryPoint)
        {
            this.v = v;
            entryPoint = EntryPoint;
        }
    }
}