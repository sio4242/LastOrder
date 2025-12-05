DROP TABLE pos_sales_detail PURGE;
/
DROP TABLE pos_sales PURGE;
/

CREATE TABLE pos_sales (
    sid NUMBER PRIMARY KEY,
    sdate DATE DEFAULT SYSDATE,
    total NUMBER
);
/

CREATE TABLE pos_sales_detail (
    sdid NUMBER PRIMARY KEY,
    sid NUMBER REFERENCES pos_sales(sid),
    pid NUMBER REFERENCES product(pid),
    qty NUMBER,
    amount NUMBER
);
/
ALTER TABLE pos_sales ADD status VARCHAR2(20) DEFAULT ' ';
/

