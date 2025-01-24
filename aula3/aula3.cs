using System;

class Aula03{
    static void Main(string[] args){
    byte n1 = 10;// pode adicionar de 0 a 255
     int num = 0;
    //  int e um tipo primitivo
    // numero inteiro com sinal ex pode receber numero com sinal - + 
    char letra = 'k';
    // pode adicionar um caracter se usa '
    float virgula = 2.3f;
    // tem que indicar o f no final para entender que e float(numero quebrado)
    string nome = "Kaiky";
        //  pode se armazenar um conjunto de caracteres (ao contrario do char) se usa "

        var num2 = 10;
        // o sistema indicara o tipo de variavel conforme o valor que ela tem (10 ou seja int), Não se pode mudar essa variavel 
        var num1 = nome;

        Console.Write("Valor é "+num1);

        int n2 ,n3, n4;
        n2 = 2; 
        n3 = 4;
        n4 = n2 + n3 ; 
        Console.Write("a soma entre"+n2+"e"+n3+ "è igual"+n4);
    }
}