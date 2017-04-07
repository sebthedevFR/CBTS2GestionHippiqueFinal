
CREATE TABLE utilisateur (
  [user_id] int NOT NULL IDENTITY,
  [user_login] varchar(15) DEFAULT NULL,
  [user_mdp] varchar(15) DEFAULT NULL,
  PRIMARY KEY ([user_id])
)  ;


CREATE TABLE entraineur (
  [ent_id] int NOT NULL IDENTITY,
  [ent_nom] varchar(15) DEFAULT NULL,
  [ent_prenom] varchar(15) DEFAULT NULL,
  [ent_age] int DEFAULT NULL,
  [ent_civilite] varchar(15) DEFAULT NULL,
  [ent_localisation] varchar(15) DEFAULT NULL,
  PRIMARY KEY ([ent_id]),
  CONSTRAINT [ent_num] UNIQUE  ([ent_id])
)  ;

CREATE TABLE hippodrome (
  [hip_id] int NOT NULL IDENTITY,
  [hip_nom] varchar(15) DEFAULT NULL,
  [hip_lieu] varchar(15) DEFAULT NULL,
  PRIMARY KEY ([hip_id])
)  ;

CREATE TABLE jockey (
  [joc_id] int NOT NULL IDENTITY,
  [joc_nom] varchar(15) DEFAULT NULL,
  [joc_prenom] varchar(15) DEFAULT NULL,
  [joc_age] int DEFAULT NULL,
  [joc_civilite] varchar(15) DEFAULT NULL,
  PRIMARY KEY ([joc_id]),
  CONSTRAINT [joc_num] UNIQUE  ([joc_id])
)  ;

CREATE TABLE proprietaire (
  [pro_id] int NOT NULL IDENTITY,
  [pro_nom] varchar(15) DEFAULT NULL,
  [pro_prenom] varchar(15) DEFAULT NULL,
  [pro_civilite] varchar(15) DEFAULT NULL,
  PRIMARY KEY ([pro_id]),
  CONSTRAINT [pro_num] UNIQUE  ([pro_id])
)  ;

CREATE TABLE course (
  [crs_id] int NOT NULL IDENTITY,
  [crs_nom] varchar(50) DEFAULT NULL,
  [crs_lieu] varchar(15) DEFAULT NULL,
  [crs_nbrmax] int DEFAULT NULL,
  [crs_price] int DEFAULT NULL,
  [crs_first] int DEFAULT NULL,
  [crs_second] int DEFAULT NULL,
  [crs_third] int DEFAULT NULL,
  [crs_fourth] int DEFAULT NULL,
  [crs_fifth] int DEFAULT NULL,
  [hip_id] int NOT NULL,
    [crs_agemin] int DEFAULT NULL,
    [crs_agemax] int DEFAULT NULL,
    [crs_sexe] varchar(15) DEFAULT NULL,
    [crs_date] varchar(15) DEFAULT NULL,
    
  PRIMARY KEY ([crs_id]),
  CONSTRAINT [crs_num] UNIQUE  ([crs_id])
 ,
  CONSTRAINT [hip_id] FOREIGN KEY ([hip_id]) REFERENCES hippodrome ([hip_id])
)  ;

CREATE TABLE cheval (
  [ch_id] int NOT NULL IDENTITY,
  [ch_nom] varchar(15) DEFAULT NULL,
  [ch_couleur] varchar(15) DEFAULT NULL,
  [ch_age] int DEFAULT NULL,
  [ch_specialite] varchar(15) DEFAULT NULL,
  [ch_nompere] varchar(15) DEFAULT NULL,
  [ch_nommere] varchar(15) DEFAULT NULL,
  [ch_sexe] varchar(15) DEFAULT NULL,
  [ent_id] int NOT NULL,
  [pro_id] int NOT NULL,
  PRIMARY KEY ([ch_id]),
  CONSTRAINT [ch_num] UNIQUE  ([ch_id]),
  CONSTRAINT [cheval_ibfk_1] FOREIGN KEY ([ent_id]) REFERENCES entraineur ([ent_id]),
  CONSTRAINT [cheval_ibfk_2] FOREIGN KEY ([pro_id]) REFERENCES proprietaire ([pro_id])
)  ;

CREATE INDEX [ent_id] ON cheval ([ent_id]);
CREATE INDEX [pro_id] ON cheval ([pro_id]);
CREATE INDEX [hip_id] ON course ([hip_id]);


CREATE TABLE participe (
  [ch_id] int NOT NULL,
  [crs_id] int NOT NULL,
  [joc_id] int NOT NULL,
[classement] int DEFAULT NULL,
  CONSTRAINT [joc_id] UNIQUE  ([joc_id])
 ,
  CONSTRAINT [participe_ibfk_1] FOREIGN KEY ([ch_id]) REFERENCES cheval ([ch_id]),
  CONSTRAINT [participe_ibfk_2] FOREIGN KEY ([crs_id]) REFERENCES course ([crs_id]),
  CONSTRAINT [participe_ibfk_3] FOREIGN KEY ([joc_id]) REFERENCES jockey ([joc_id])
) ;

CREATE INDEX [crs_id] ON participe ([crs_id]);
CREATE INDEX [ch_id] ON participe ([ch_id]);



CREATE TABLE resultat (
  [rslt_id] int NOT NULL IDENTITY,
  [rslt_place] int NOT NULL,
  [crs_id] int NOT NULL,
  [ch_id] int NOT NULL,
  [joc_id] int NOT NULL,
  PRIMARY KEY ([rslt_id])
 ,
  CONSTRAINT [resultat_ibfk_1] FOREIGN KEY ([crs_id]) REFERENCES course ([crs_id]),
  CONSTRAINT [resultat_ibfk_2] FOREIGN KEY ([ch_id]) REFERENCES cheval ([ch_id]),
  CONSTRAINT [resultat_ibfk_3] FOREIGN KEY ([joc_id]) REFERENCES jockey ([joc_id])
) ;

CREATE INDEX [crs_id] ON resultat ([crs_id]);
CREATE INDEX [ch_id] ON resultat ([ch_id]);
CREATE INDEX [joc_id] ON resultat ([joc_id]);


CREATE TABLE calendrier (
  [date_course] varchar(15) NOT NULL
)

ALTER TABLE calendrier
  ADD PRIMARY KEY (date_course);

