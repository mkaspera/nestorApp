CREATE TABLE Parametry (id INTEGER PRIMARY KEY, nazwa VARCHAR(50), wartosc VARCHAR(20));

INSERT INTO Parametry (id, nazwa, wartosc) VALUES (1, 'PortCOM', 'COM4');
INSERT INTO Parametry (id, nazwa, wartosc) VALUES (2, 'Baudrate', '57600');
INSERT INTO Parametry (id, nazwa, wartosc) VALUES (3, 'SkalaTensometr', '1');
INSERT INTO Parametry (id, nazwa, wartosc) VALUES (4, 'SkalaDroga', '1');
INSERT INTO Parametry (id, nazwa, wartosc) VALUES (5, 'CzuloscStart', '1');
INSERT INTO Parametry (id, nazwa, wartosc) VALUES (6, 'DrogaStop', '1');
INSERT INTO Parametry (id, nazwa, wartosc) VALUES (7, 'TimeoutStop', '1000');