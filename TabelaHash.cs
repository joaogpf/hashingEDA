using System;


namespace hashing
{
    public class TabelaHash
    {
        private no[]tabela;
        private int capacidade = 16;
        private int tamanho;
        public TabelaHash()
        {
            tabela = new no[capacidade];
            tamanho = 0;
            this.capacidade = capacidade;
        }
    
    // calcula o valor hash de acordo com o algoritmo hash da chave
    private int gerarCodigoHash(object chave){
        int numero = 0;
        char[] caracteres = chave.ToString().ToCharArray();
        
        for(int i = 0; i < caracteres.Length; i++){
            numero +=(int)caracteres[i];       
        }
        double media = numero*(Math.Pow(5, 0.5) -1)/2;
        double valorNumerico = media - Math.Floor(media);
    return (int)Math.Floor(valorNumerico*capacidade);
    }

    public int GetTamanho(){
        return tamanho;
    }

    public bool vefificarSeVazia(){
        return tamanho == 0?true:false;
    }

    public void Inserir(object chave, object valor){
        int codigoHash = gerarCodigoHash(chave);
        no novoNo = new no(chave, valor, codigoHash, null);
        no no = tabela[codigoHash];

        while(no != null){
            if(no.chave.Equals(chave)){
                no.valor = valor;
                
                return;
            }
          no = no.proximo;
        }

      novoNo.proximo = tabela[codigoHash];
      tabela[codigoHash] = novoNo;
      tamanho++;
    }

    public object GetValor(object chave){
        if (chave == null){
            return null;
        }

        int codigoHash = gerarCodigoHash(chave);
        no no = tabela[codigoHash];
        while(no != null){
            if(no.chave.Equals(chave)){
                return no.valor;
            }
            no = no.proximo;
        }
    return null;
    }


 
    }

    
}