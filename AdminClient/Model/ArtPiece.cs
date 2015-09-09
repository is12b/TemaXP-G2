namespace AdminClient.ServiceReference1 {
    public partial class ArtPiece{
        public bool Checked { get; set; }

        public override string ToString() {
            return this.Name;
        }
    }
}