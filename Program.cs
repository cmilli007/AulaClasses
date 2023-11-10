// See https://aka.ms/new-console-template for more information
// Aluno Marina = new Aluno ();
// var Marina = new Aluno ();
//aluno Marina =new ();
Aluno aurora = new() {
    rm = 12345,
    nome = "aurora",
    idade = 78,
};

Aluno Marina = new();
Marina.rm = 13489;
Marina.nome= "Marina";
Marina.idade= 17;

Marina.Exibir();
aurora.Exibir();

aurora.TrancarMatricula();
Marina.Exibir();
aurora.Exibir();

// string mensagem = $" o aluno(a) {Marina.nome} posuui o rm {Marina.rm}.";
// Console.WriteLine(mensagem);
