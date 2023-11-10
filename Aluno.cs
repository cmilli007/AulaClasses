class Aluno{
    // Estado
    public int rm;
    public string nome = default!;
    public int idade;
    public bool ativo = true;
    //Comportamento
     public void Exibir () {
        if (!this.ativo) return;
        
        string mensagem = $" o aluno(a) {this.nome} posuui o rm {this.rm} e idade {this.idade}.";
        Console.WriteLine(mensagem);

    }
    public void TrancarMatricula (){
        this.ativo = false;
    }
}