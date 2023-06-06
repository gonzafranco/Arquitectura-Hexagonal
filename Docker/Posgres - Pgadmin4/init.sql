CREATE TABLE IF NOT EXISTS  public.Libros
(
    Id uuid NOT NULL,
    Titulo character varying(50) COLLATE pg_catalog."default",
    Autor character varying(50) COLLATE pg_catalog."default",
    paginas integer,
    ISBN character varying(20) COLLATE pg_catalog."default",
    CONSTRAINT "Libros_pkey" PRIMARY KEY (Id)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.Libros
    OWNER to root;