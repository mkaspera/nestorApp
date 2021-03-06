﻿CREATE TABLE Parametry (id INTEGER PRIMARY KEY, nazwa VARCHAR(50), wartosc VARCHAR(20));
INSERT INTO Parametry (id, nazwa, wartosc) VALUES (1, 'PortCOM', 'COM3');
INSERT INTO Parametry (id, nazwa, wartosc) VALUES (2, 'Baudrate', '57600');
INSERT INTO Parametry (id, nazwa, wartosc) VALUES (3, 'SkalaTensometr', '1430');
INSERT INTO Parametry (id, nazwa, wartosc) VALUES (4, 'SkalaDroga', '100');
INSERT INTO Parametry (id, nazwa, wartosc) VALUES (5, 'CzuloscStart', '1000');
INSERT INTO Parametry (id, nazwa, wartosc) VALUES (6, 'TimeoutPomiar', '5');
CREATE TABLE Klienci (id INTEGER PRIMARY KEY, nazwa VARCHAR(50), logo VARCHAR(20));
CREATE TABLE Produkty (id INTEGER PRIMARY KEY, nazwa VARCHAR(50), dlugosc INTEGER, szerokosc INTEGER, wysokosc INTEGER, typ VARCHAR(20));
CREATE TABLE Sprezyny (id INTEGER PRIMARY KEY, nazwa VARCHAR(50), wysokoscPoczatkowa INTEGER, srednica INTEGER, liczbaZwoi INTEGER);
CREATE TABLE Druty (id INTEGER PRIMARY KEY, nazwa VARCHAR(50), srednica INTEGER, dostawca VARCHAR(20));
CREATE TABLE Pomiar (id INTEGER PRIMARY KEY, idKlient INTEGER, idProdukt INTEGER, idSprezyna INTEGER, idDrut INTEGER, data DATETIME, iloscPunktowPomiarowych INTEGER);
CREATE TABLE DanePomiaru (id INTEGER PRIMARY KEY, idPomiar INTEGER, proba INTEGER, sila REAL, ugiecie REAL, procent REAL);