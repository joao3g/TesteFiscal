--
-- PostgreSQL database dump
--

-- Dumped from database version 15.4
-- Dumped by pg_dump version 15.4

-- Started on 2023-09-21 17:16:08

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 4 (class 2615 OID 2200)
-- Name: public; Type: SCHEMA; Schema: -; Owner: pg_database_owner
--

CREATE SCHEMA public;


ALTER SCHEMA public OWNER TO pg_database_owner;

--
-- TOC entry 3336 (class 0 OID 0)
-- Dependencies: 4
-- Name: SCHEMA public; Type: COMMENT; Schema: -; Owner: pg_database_owner
--

COMMENT ON SCHEMA public IS 'standard public schema';


SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 214 (class 1259 OID 16412)
-- Name: item; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.item (
    idnota integer NOT NULL,
    produto character varying NOT NULL,
    valor numeric NOT NULL,
    iditem integer NOT NULL
);


ALTER TABLE public.item OWNER TO postgres;

--
-- TOC entry 217 (class 1259 OID 16429)
-- Name: item_iditem_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.item_iditem_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.item_iditem_seq OWNER TO postgres;

--
-- TOC entry 3337 (class 0 OID 0)
-- Dependencies: 217
-- Name: item_iditem_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.item_iditem_seq OWNED BY public.item.iditem;


--
-- TOC entry 216 (class 1259 OID 16421)
-- Name: notafiscal; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.notafiscal (
    idnota integer NOT NULL,
    data date NOT NULL,
    emissor character varying NOT NULL
);


ALTER TABLE public.notafiscal OWNER TO postgres;

--
-- TOC entry 215 (class 1259 OID 16420)
-- Name: notafiscal_idnota_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.notafiscal_idnota_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.notafiscal_idnota_seq OWNER TO postgres;

--
-- TOC entry 3338 (class 0 OID 0)
-- Dependencies: 215
-- Name: notafiscal_idnota_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.notafiscal_idnota_seq OWNED BY public.notafiscal.idnota;


--
-- TOC entry 3178 (class 2604 OID 16430)
-- Name: item iditem; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.item ALTER COLUMN iditem SET DEFAULT nextval('public.item_iditem_seq'::regclass);


--
-- TOC entry 3179 (class 2604 OID 16424)
-- Name: notafiscal idnota; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.notafiscal ALTER COLUMN idnota SET DEFAULT nextval('public.notafiscal_idnota_seq'::regclass);


--
-- TOC entry 3327 (class 0 OID 16412)
-- Dependencies: 214
-- Data for Name: item; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.item (idnota, produto, valor, iditem) FROM stdin;
1	Produto 1	10.45	1
1	Produto 1	10.45	2
1	Produto 1	10.45	3
1	Produto 1	10.45	4
1	Produto 1	10.45	5
1	Produto 1	10.45	6
1	Produto 1	10.45	7
1	Produto 1	10.45	8
1	Produto 1	10.45	9
1	Produto 1	10.45	10
1	Produto 1	10.45	11
\.


--
-- TOC entry 3329 (class 0 OID 16421)
-- Dependencies: 216
-- Data for Name: notafiscal; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.notafiscal (idnota, data, emissor) FROM stdin;
1	2008-06-01	Joao
\.


--
-- TOC entry 3339 (class 0 OID 0)
-- Dependencies: 217
-- Name: item_iditem_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.item_iditem_seq', 11, true);


--
-- TOC entry 3340 (class 0 OID 0)
-- Dependencies: 215
-- Name: notafiscal_idnota_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.notafiscal_idnota_seq', 1, true);


--
-- TOC entry 3181 (class 2606 OID 16438)
-- Name: item item_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.item
    ADD CONSTRAINT item_pk PRIMARY KEY (idnota, iditem);


--
-- TOC entry 3184 (class 2606 OID 16428)
-- Name: notafiscal notafiscal_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.notafiscal
    ADD CONSTRAINT notafiscal_pk PRIMARY KEY (idnota);


--
-- TOC entry 3182 (class 1259 OID 16419)
-- Name: item_produto_idx; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX item_produto_idx ON public.item USING btree (produto);


-- Completed on 2023-09-21 17:16:08

--
-- PostgreSQL database dump complete
--

