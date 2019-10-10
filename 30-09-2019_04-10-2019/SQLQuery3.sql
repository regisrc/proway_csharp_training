CREATE DATABASE Musicas;
USE Musicas;

CREATE TABLE Playlist
(
	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	IdMusica INT NOT NULL,
	CONSTRAINT FK_MUSICA_PLAYLIST FOREIGN KEY (IdMusica) REFERENCES Musica(Id)
);

CREATE TABLE Musica
(
	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	Nome NVARCHAR(60) NOT NULL,
	IdArtista INT NOT NULL,
	IdGenero INT NOT NULL,
	CONSTRAINT FK_MUSICA_GENERO FOREIGN KEY (IdArtista) REFERENCES Artistas(Id),
	CONSTRAINT FK_MUSICA_ARTISTA FOREIGN KEY (IdGenero) REFERENCES Generos(Id)
);

CREATE TABLE Generos
(
	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	Nome NVARCHAR(60) NOT NULL
);

CREATE TABLE Artistas
(
	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	Nome NVARCHAR(60) NOT NULL
);

INSERT INTO Artistas(Nome)
VALUES
('Massacration'),
('Cassia Eller'),
('Nando Reis'),
('Legião Urbana'),
('Jon Lajoie');

INSERT INTO Generos(Nome)
VALUES
('Rock'),
('MPB'),
('Metal'),
('?');

INSERT INTO Musica(IdArtista,IdGenero,Nome)
VALUES
(1,3,'Metal Dental Destruction'),
(1,3,'Evil Papagali'),
(1,3,'Metal Cereal'),
(1,3,'Metal is the law'),
(1,3,'The mummy'),
(5,4,'The Best Song'),
(4,1,'Tempo Perdido'),
(2,2,'Segundo Sol'),
(3,2,'Luz dos Olhos'),
(4,1,'Quase sem querer');

INSERT INTO Playlist(IdMusica)
VALUES
(1),
(2),
(3),
(4),
(5),
(6),
(7),
(8),
(9),
(10);



