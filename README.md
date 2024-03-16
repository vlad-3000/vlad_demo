#### CREATE TABLE IF NOT EXISTS public.product
(
    id text COLLATE pg_catalog."default" NOT NULL,
    title text COLLATE pg_catalog."default" NOT NULL,
    producttypeid text COLLATE pg_catalog."default" NOT NULL,
    articlenumber text COLLATE pg_catalog."default" NOT NULL,
    description text COLLATE pg_catalog."default" NOT NULL,
    image text COLLATE pg_catalog."default" NOT NULL,
    productionpersoncount text COLLATE pg_catalog."default" NOT NULL,
    productionworkshopnumber text COLLATE pg_catalog."default" NOT NULL,
    mincostforagent text COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT product_pkey PRIMARY KEY (id)
)

#### TABLESPACE pg_default;

#### ALTER TABLE IF EXISTS public.product
   ####  OWNER to postgres;
