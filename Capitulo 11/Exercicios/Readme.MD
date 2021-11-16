# Exercícios do Capítulo 11 do livro

1. Crie a classe Aluno com dois atributos, *nome* e *idade*, e um método construtor para poder inicializar esses dois atributos. De seguida, no método principal crie três alunos, pedindo ao utilizador os respetivos dados e apresente a média das idades.
2. Gestão de empregados:
   1. Crie a classe Empregado com três atributos, *nome*, *salario* e *dataDeEntradaNaEmpresa* (do tipo *DateTime*) e respetivos métodos seletores e modificadores.
	2. Crie, na classe Empregado, um método construtor com argumentos que permita iniciar todos os atributos do empregado.
	3. Crie na classe *Empregado* o método *ToString()* que devolva os dados da classe Empregado da seguinte forma: Nome: <nome> Salario: <salario> Data de entrada na empresa: <dataDeEntradaNaEmpresa> (dd-mm-aaaa).
	4. Crie na classe *Empregado* o método *AumentarSalario* que permita aumentar o salário do empregado numa determinada percentagem (ex. 10%).
	5. Crie na classe Empregado um método que permita fazer a *Deep Copy* de um objeto Empregado (neste caso interessa um método que implemente a *Deep Copy* pois a dataDeEntradaNaEmpresa é específica de cada empregado).
	6. Crie, no método principal da classe *Program*, o empregado *emp1* com os seguintes dados (Joana,1500.87, 25-12-2010). Crie mais um empregado *emp2*, fazendo uma cópia de *emp1* e altere os dados para (Miguel,1200,1-1-2008). Invoque os métodos para apresentar os dados no ecrã e corra o programa.
	7. Implemente um método que faça a *Shallow Copy* e veja a diferença nos resultados. 
3. Formas geométricas:
	1. Crie a classe abstrata *FormaGeometrica* com o atributo *nome* e os métodos abstratos *Area* e *Perimetro*. 
	2. Crie a classe *Retangulo* derivada da classe *FormaGeometrica* com os atributos largura e comprimento e os métodos *Area* e *Perimetro* com  as fórmulas para o cálculo da área e do perímetro. 
	3. Faça o mesmo para a classe *Circunferencia*, mas com o atributo *raio*. 
	4. No programa principal crie um *retangulo*, uma *circunferencia* e o método *MostraDados*, que recebe uma forma geométrica (*retangulo* ou *circunferencia*) e apresenta no ecrã os dados dessa forma geométrica (nome, largura e comprimento ou raio, a área e o perímetro).
	5. Crie e teste um método que apresente o dia do ano de uma determinada data.
	6. Crie e teste um método que apresente a diferença em dias entre duas datas.
	7. Crie e teste um método que indique se uma determinada data é ou não um dia útil da semana.
	8. Crie e teste um método que devolva quantas horas faltam para o fim do dia.
	9. Crie e teste um método que devolva quantos dias já viveu.
