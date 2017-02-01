create database db_PerguntasERespostas

use db_PerguntasERespostas

create table tb_Jogador
(
	id int identity primary key,
	nome varchar(100) not null
)

select * from tb_Jogador

insert into tb_Jogador(nome) values('Amanda')
insert into tb_Jogador(nome) values('Fernanda')

create table tb_Perguntas
(
	id int identity primary key,
	pergunta varchar(max),
	resposta_correta varchar(max),
	data datetime default getdate()	
)

select * from tb_Perguntas

insert into tb_Perguntas(pergunta, resposta_correta)
values('Qual é a formula utilizada para se calcular a distorção causada pela gravidade infinita de um buraco negro?', 'Raio de Schwarschild')

select * from tb_Jogador
delete from tb_Jogador where id = 8
insert into tb_Jogador(nome) values('Ramon')

delete from tb_Jogador


--Limpa os dados da tabela e reinicia o id.
truncate table tb_Jogador