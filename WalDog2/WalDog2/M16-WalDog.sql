CREATE DATABASE WalDog

USE WalDog

-- SELECT * FROM Logar
-- SELECT * FROM Pagamentos
-- SELECT * FROM BancoDinheiro 
-- SELECt * FROM DogDados
-- SELECt * FROM Passeios

-- DELETE DogDados


CREATE TABLE Logar
(username VARCHAR (50) PRIMARY KEY NOT NULL,
pass VARCHAR (50) NOT NULL)


CREATE TABLE Pagamentos
(idPagamentos INT IDENTITY(1,1) PRIMARY KEY,
valorConta DECIMAL(25, 2) NOT NULL,
username VARCHAR(50), CONSTRAINT fk_usernameV FOREIGN KEY (username) REFERENCES Logar(username))


CREATE TABLE BancoDinheiro
(nome VARCHAR (50) NOT NULL,
nif VARCHAR (9) NOT NULL,
numCartao VARCHAR (16) NOT NULL,
validaCartao VARCHAR (50) NOT NULL,
codSegu VARCHAR (4) NOT NULL,
PRIMARY KEY(nif, numCartao ),
username VARCHAR(50), CONSTRAINT fk_username FOREIGN KEY (username) REFERENCES Logar(username),
-- Tenho que deixar essa variavel como IDENTITY, assim o erro some!
idPagamentos INT, CONSTRAINT fk_idPagar FOREIGN KEY (idPagamentos) REFERENCES Pagamentos(idPagamentos))


CREATE TABLE TypeCao
(racaCachorro VARCHAR(40) PRIMARY KEY)
-- 130 raças de cahorros
INSERT INTO TypeCao (racaCachorro)
VALUES('Afghan Hound'),
('Affenpinscher'), 
('Airedale Terrier'), 
('Akita'), 
('Alaskan Malamute'), 
('American Cocker Spaniel'), 
('American Staffordshire Terrier'), 
('Argentine Dogo'), 
('Australian Cattle Dog'), 
('Australian Shepherd'), 
('Basenji'), 
('Basset Hound'), 
('Basset Hush'), 
('Beagle'), 
('Beagle Harrier'), 
('Bedlington Terrier'), 
('Belgian Griffon'), 
('Bernese Mountain Dog'), 
('Bichon Frisé'), 
('Bloodhound'), 
('Bobtail'), 
('Borzoi'), 
('Boston Terrier'), 
('Boxer'), 
('Brazilian Mastiff'), 
('Bull Terrier'), 
('Bullmastiff'), 
('Cairn Terrier'), 
('Cane Corso'), 
('Cavalier King Charles Spaniel'), 
('Chesapeake Bay Retriever'), 
('Chihuahua'), 
('Chinese Crested'), 
('Chow Chow'), 
('Collie'), 
('Coton de Tuléar'), 
('Dachshund'), 
('Dalmatian'), 
('Dandie Dinmont Terrier'), 
('Doberman'), 
('English Bulldog'), 
('English Cocker Spaniel'), 
('English Foxhound'), 
('English Setter'), 
('English Springer Spaniel'), 
('Eurasian'), 
('Field Spaniel'), 
('Finnish Lapphund'), 
('Flat-Coated Retriever'), 
('Fox Terrier'), 
('French Bulldog'), 
('German Shepherd'), 
('Golden Retriever'), 
('Great Dane'), 
('Greater Swiss Mountain Dog'), 
('Greyhound'), 
('Harrier'), 
('Havanese'), 
('Hovawart'), 
('Hungarian Vizsla'), 
('Husky Siberiano'), 
('Irish Setter'), 
('Irish Terrier'), 
('Irish Wolfhound'), 
('Italian Greyhound'), 
('Italian Volpino'), 
('Jack Russell Terrier'), 
('Japanese Chin'), 
('Japanese Spitz'), 
('Jagdterrier'), 
('Jindo'), 
('Keeshond'), 
('Kerry Blue Terrier'), 
('King Charles Spaniel'), 
('Komondor'), 
('Kuvasz'), 
('Labradoodle'), 
('Labrador Retriever'), 
('Lakeland Terrier'), 
('Leonberger'), 
('Lhasa Apso'), 
('Maltese'), 
('Mastiff'), 
('Miniature Pinscher'), 
('Miniature Schnauzer'), 
('Mongrel'), 
('Neapolitan Mastiff'), 
('Newfoundland'), 
('Norfolk Terrier'), 
('Norwegian Elkhound'), 
('Norwich Terrier'), 
('Old English Sheepdog'),
('Otterhound'), 
('Papillon'), 
('Pitbull'), 
('Pomeranian'), 
('Poodle'), 
('Portuguese Water Dog'), 
('Pug'), 
('Redbone Coonhound'), 
('Rhodesian Ridgeback'), 
('Rottweiler'), 
('Russell Terrier'), 
('Scottish Deerhound'), 
('Scottish Terrier'), 
('Shih Tzu'),
('Siberian Husky'), 
('Silky Terrier'), 
('Skye Terrier'), 
('Spaniel tibetano'), 
('Staffordshire Bull Terrier'), 
('Terra Nova'), 
('Terrier Escocês'),
('Terrier Tibetano'), 
('Tibetan Mastiff'), 
('Tibetan Spaniel'), 
('Tibetan Terrier'), 
('Tosa'), 
('Ukrainian Shepherd Dog'), 
('Vizsla'), 
('Volpino Italiano'), 
('Weimaraner'), 
('Welsh Corgi (Cardigan)'), 
('Welsh Corgi (Pembroke)'), 
('West Highland White Terrier'), 
('Whippet'), 
('Xoloitzcuintli'), 
('Yorkshire Terrier'), 
('Zuchon (Shichon)'), 
('Outro');


CREATE TABLE DogDados
(idDoguinho INT IDENTITY(1,1) PRIMARY KEY,
nameDog VARCHAR(20) NOT NULL,
tamanho VARCHAR(7) NOT NULL, -- Grande, Médio ou Pequeno
gostarCarinho VARCHAR(3) NOT NULL, -- Sim ou Não 
brinquedo VARCHAR(3) NOT NULL, -- Sim ou Não 
amigavel VARCHAR(3) NOT NULL, -- Nível de amizade
alergia VARCHAR(3) NOT NULL, -- Sim ou Não 
descricao VARCHAR(200) NOT NULL,
username VARCHAR(50), CONSTRAINT fk_usernameD FOREIGN KEY (username) REFERENCES Logar(username),
racaCachorro VARCHAR(40), CONSTRAINT fk_racaCachorro FOREIGN KEY (racaCachorro) REFERENCES TypeCao (racaCachorro))


CREATE TABLE Passeios
(idPasseio INT IDENTITY(1,1) PRIMARY KEY,
dataPasseio DATE NOT NULL ,
precoCorrida DECIMAL(25, 2) NOT NULL,
verificacao VARCHAR(15) NOT NULL,
username VARCHAR(50), CONSTRAINT fk_usernameP FOREIGN KEY (username) REFERENCES Logar(username),
idDoguinho INT, CONSTRAINT fk_idDog FOREIGN KEY (idDoguinho) REFERENCES DogDados (idDoguinho),
descricao VARCHAR(200) NOT NULL)



