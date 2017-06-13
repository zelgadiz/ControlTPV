BEGIN TRANSACTION;
CREATE TABLE `clientes` (
	`clientes`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`codigo`	TEXT NOT NULL UNIQUE,
	`nombre`	TEXT NOT NULL,
	`ap_pat`	TEXT NOT NULL,
	`ap_mat`	TEXT,
	`sexo`	TEXT NOT NULL,
	`fec_nac`	TEXT,
	`direccion`	TEXT NOT NULL,
	`telefono`	TEXT,
	`correo`	TEXT,
	`edad`	REAL NOT NULL
);
COMMIT;
