CREATE DATABASE Musicas;
USE MUSICAS;

CREATE TABLE Playlist
(
	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	Nome NVARCHAR(60) NOT NULL,
	Artista NVARCHAR(60) NOT NULL,
	Genero NVARCHAR(60) NOT NULL
);

INSERT INTO Playlist(Nome,Artista,Genero)
VALUES
('Segundo Sol', 'Cassia Eller', 'MPB'),
('Luz dos Olhos', 'Nando Reis', 'MPB'),
('Tempo Perdido', 'Legião Urbana', 'Rock'),
('1 Minuto para o fim do mundo', 'CPM22', 'Rock'),
('Evil Papagali', 'Massacration', 'Metal'),
('Metal Dental Destruction', 'Massacration', 'Metal'),
('Metal Cereal', 'Massacration', 'Metal'),
('Metal is the law', 'Massacration', 'Metal'),
('The mummy', 'Massacration', 'Metal'),
('The Best Song', 'Jon Lajoie', '?');


