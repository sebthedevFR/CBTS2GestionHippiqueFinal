INSERT INTO utilisateur (user_login, user_mdp) VALUES
('admin', 'admin'),
('root', 'root');

INSERT INTO proprietaire (pro_nom, pro_prenom, pro_civilite) VALUES
('Heinz', 'Sarah', 'F'),
('Asmer', 'Valentine', 'F'),
('Leboule', 'Patrick', 'H'),
('Halon', 'Victor', 'H');




INSERT INTO calendrier (date_course) VALUES
('2/10/2018'),
('3/30/2017');

INSERT INTO jockey (joc_nom, joc_prenom, joc_age, joc_civilite) VALUES
('Royal', 'Gimli', 31, 'H'),
('Strudell', 'Samir', 29, 'H'),
('Croissant', 'Fabrice', 28, 'H'),
('Triblo', 'Arthur', 24, 'H'),
('Blaise', 'Pascal', 29, 'H'),
('Troulou', 'Damien', 32, 'H'),
('Derullo', 'Joseph', 34, 'H'),
('Figulo', 'James', 30, 'M');

INSERT INTO hippodrome (hip_nom, hip_lieu) VALUES
('Etoile', 'Chantilly'),
('Dauphin', 'Toulouse'),
('Bohemia', 'Vincennes'),
('Dinarobin', 'Lyon Parilly'),
('Prince', 'Auteuil');

INSERT INTO entraineur (ent_nom, ent_prenom, ent_age, ent_civilite, ent_localisation) VALUES
('Troufi', 'Cybille', 38, 'F', 'Senlis'),
('Bueno', 'Sandrine', 49, 'H', 'Lille'),
('Fraiso', 'Faramir', 27, 'F', 'Strasbourg'),
('Farcy', 'Thomas', 37, 'F', 'Senlis');


INSERT INTO course (crs_nom, crs_lieu, crs_nbrmax, crs_price, crs_first, crs_second, crs_third, crs_fourth, crs_fifth, hip_id, crs_agemin, crs_agemax, crs_sexe, crs_date) VALUES
('Prix Lapin', 'Etoile', 16, 49131, 24430, 9880, 7280, 4680, 2861, 1, 3, 23, 'X', '4/13/2017'),
('Prix Ralou', 'Dinarobin', 18, 98701, 47300, 23100, 13600, 9450, 5251, 4, 7, 32, 'F', '2/15/2017'),
('Prix Café', 'Dauphin', 3, 49140, 24430, 9890, 7280, 4680, 2860, 2, 3, 23, 'X', '4/29/2017'),
('Prix Lapin', 'Dinarobin', 16, 49130, 24430, 9880, 7280, 4680, 2860, 4, 3, 23, 'X', '4/6/2017'),
('Prix Lapin', 'Dinarobin', 16, 49140, 24430, 9880, 7280, 4680, 2870, 4, 3, 23, 'X', '4/6/2017'),
('Prix toto', 'Prince', 99, 15, 1, 2, 3, 4, 5, 5, 1, 99, 'M', '4/29/2017');


INSERT INTO cheval (ch_nom, ch_couleur, ch_age, ch_specialite, ch_nompere, ch_nommere, ch_sexe, ent_id, pro_id) VALUES
('Jumpar', 'Noir', 11, 'Obstacles', 'Jolly', 'Rose', 'M', 4, 4),
('Cyril', 'Noir', 11, 'Obstacles', 'Jolly', 'Rose', 'M', 3, 4),
('Charlie', 'Noir blanc', 18, 'Obstacles', 'Jolly', 'Rose', 'M', 3, 1),
('Louise', 'Noir', 22, 'Trot', 'Val', 'Loic', 'F', 4, 3),
('Lucia', 'Noir', 14, 'Galop', 'Tyrone', 'Miranda', 'M', 4, 4),
('Symettra', 'Brun', 29, 'Trot', 'Richard', 'Sombra', 'M', 2, 1);

INSERT INTO participe (ch_id, crs_id, joc_id, classement) VALUES
(7, 4, 1, 0),
(3, 4, 2, 0),
(4, 4, 4, 0),
(1, 6, 1, 3),
(8, 6, 2, 2),
(3, 6, 6, 1),
(4, 6, 4, 4),
(5, 6, 5, 5);