# Exercícios do Capítulo 12 do livro

1. Aplicação de gestão de aniversários:
	1. Declare uma classe Aniversario para armazenar um nome (texto) e uma data de nascimento (DateTime);
	2. Crie e teste os métodos necessários às seguintes operações:
	    1. Criar um aniversariante;
		2. Mostrar a lista de aniversariantes (de 10 em 10 caso sejam mais do que 10);
		3. Pesquisar os aniversariantes que fazem anos num determinado mês.

2. Aplicação para gestão de alunos:
	1. Declare uma classe *Aluno* com os atributos *numAluno* (inteiro), *nome* (texto), *idade* (inteiro), *altura* (real) e os métodos necessários para a manipulação dos atributos.
	2. Na classe *Aluno* reescreva o método *ToString()* para que devolva todos os atributos num formato para apresentar no ecrã.
	3. Declare uma classe *Turma* com os atributos *disciplina* (texto) e *listaDeAlunos* (lista do tipo Aluno).
	4. Na classe *Program* crie um método para mostrar todos os alunos de uma turma.
	5. Na classe *Program* crie um método que apresente os alunos ordenados alfabeticamente pelo nome.
	6. Na classe *Program* crie um método que apresente os alunos ordenados pela idade.
	7. Na classe *Program* crie um método que devolva a altura média dos alunos de uma turma.	
	8. No método principal da classe *Program*:
	    1. Crie três alunos, *a1*, *a2* e *a3* e adicione-os à turma *t1* de música.
		2. Apresente os alunos da turma *t1* ordenados alfabeticamente pelo nome.
		3. Apresente os alunos da turma *t1* ordenados pela idade.
		4. Crie uma turma *t2* de matemática por cópia da turma *t1* e remova o aluno *a2* pois não faz parte desta turma.
		5. Apresente as alturas médias das turmas *t1* e *t2*.
		
3. Aplicação de gestão de contactos:
    1. Declare uma classe Contacto com os seguintes atributos *nome*, *rede* e *número de telefone*;
	2. Utilizando a classe *List<T>* para guardar a lista de contactos, crie e teste os métodos necessários às seguintes operações:
	    1. Guardar os dados de um contacto.
		2. Mostrar os dados de um contacto.
		3. Percorrer a lista de contactos.
		4. Pesquisar os contactos de uma determinada rede.
		5. Pesquisar o número de telefone de um determinado contacto.		
		6. Pesquisar o nome do contacto com um determinado número de telefone.
		7. Remover da agenda um contacto pelo número de telefone.		
