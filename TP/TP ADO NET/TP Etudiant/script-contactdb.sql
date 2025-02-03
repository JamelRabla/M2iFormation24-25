
CREATE DATABASE demo01ado;
GO

USE demo01ado;
GO

CREATE TABLE personne (
 id INT IDENTITY(1,1) PRIMARY KEY,
 prenom NVARCHAR(50) NOT NULL,
 nom NVARCHAR(50) NOT NULL,
 email VARCHAR(255) NOT NULL
);
GO

INSERT INTO
 personne
 (prenom, nom, email)
VALUES
 ('Jean', 'Michel', 'jean@michel.fr');
GO

CREATE TABLE Etudiant(
 id INT IDENTITY(1,1) PRIMARY KEY,
 nom VARCHAR(50),
 prenom VARCHAR(50),
 numeroClasee INT,
 dateDiplome DATE
);

 