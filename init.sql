CREATE TABLE turno (
	id_turno SERIAL PRIMARY KEY,
	periodo VARCHAR(30) NOT NULL CHECK (LENGTH(TRIM(periodo)) > 0),
	inicio TIME NOT NULL,
	fim TIME NOT NULL
);

CREATE TABLE usuario (
	id_usuario SERIAL PRIMARY KEY,
    nome VARCHAR(100) NOT NULL CHECK (length(trim(nome)) > 0),
    email VARCHAR(100) UNIQUE NOT NULL CHECK (email ~* '^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$'),
    senha VARCHAR(255) NOT NULL CHECK (length(senha) >= 8),
    endereco VARCHAR(150) CHECK (length(trim(endereco)) > 0),
    cidade VARCHAR(50) CHECK (length(trim(cidade)) > 0),
    estado CHAR(2) CHECK (estado ~ '^[A-Z]{2}$'),
    id_turno_usuario INTEGER,
	CONSTRAINT fk_usuario_turno FOREIGN KEY (id_turno_usuario) REFERENCES turno (id_turno)
);

CREATE TABLE produto (
    id_produto SERIAL PRIMARY KEY,
    nome VARCHAR(100) NOT NULL CHECK (LENGTH(TRIM(nome)) > 0),
    categoria VARCHAR(20) NOT NULL CHECK (LENGTH(TRIM(categoria)) > 0),
    peso DECIMAL(10,3) NOT NULL CHECK (peso > 0),
    preco_uni DECIMAL(10,2) NOT NULL CHECK (preco_uni > 0),
    id_usuario_produto INTEGER NOT NULL,
    CONSTRAINT fk_produto_usuario FOREIGN KEY (id_usuario_produto) REFERENCES usuario (id_usuario)
);

CREATE TABLE registro_producao (
	id_registro SERIAL PRIMARY KEY,
	data_registro DATE NOT NULL DEFAULT CURRENT_DATE,
	hora_inicio TIME NOT NULL DEFAULT CURRENT_TIME,
	hora_fim TIME,
	qtd_produzido INTEGER NOT NULL CHECK (qtd_produzido > 0),
	id_produto_registro INTEGER NOT NULL,
	id_usuario_registro INTEGER NOT NULL,
	id_turno_registro INTEGER NOT NULL,
	CONSTRAINT fk_registro_produto FOREIGN KEY (id_produto_registro) REFERENCES produto (id_produto),
	CONSTRAINT fk_registro_usuario FOREIGN KEY (id_usuario_registro) REFERENCES usuario (id_usuario),
	CONSTRAINT fk_registro_turno FOREIGN KEY (id_turno_registro) REFERENCES turno (id_turno)
);

CREATE TABLE comentario (
	id_comentario SERIAL PRIMARY KEY,
	conteudo TEXT NOT NULL CHECK (LENGTH(TRIM(conteudo)) > 0),
	data_criacao TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	id_usuario_comenta INTEGER NOT NULL,
	id_registro_comenta INTEGER NOT NULL UNIQUE,
	CONSTRAINT fk_comentario_usuario FOREIGN KEY (id_usuario_comenta) REFERENCES usuario (id_usuario),
	CONSTRAINT fk_comentario_registro FOREIGN KEY (id_registro_comenta) REFERENCES registro_producao (id_registro)
);