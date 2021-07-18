namespace hashing
{
    public class no
    {
        public object chave;
        public object valor;

        public int hash;

        public no proximo;

            public no(object chave, object valor, int hash, no proximo){
                this.chave = chave;
                this.valor = valor;
                this.hash = hash;
                this.proximo = proximo;
            }
    }
}