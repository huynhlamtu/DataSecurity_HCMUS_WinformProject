alter session set "_ORACLE_SCRIPT"=true;

 -- Tao user
-- DROP USER c##Hann CASCADE;
-- DROP USER c##Annu CASCADE;
-- DROP USER c##Theota CASCADE;

-- Ban to chuc    
CREATE USER BTC_Ad IDENTIFIED BY 123;
CREATE USER BTC_1 IDENTIFIED BY 123;

grant select, update, delete, insert on ungcuvien to btc_ad;

grant select, update, delete, insert on vaitro to btc_ad;

-- To lap danh sach
CREATE USER TO_LAPDS_1 IDENTIFIED BY 123;
CREATE USER TO_LAPDS_2 IDENTIFIED BY 123;
CREATE USER TO_LAPDS_3 IDENTIFIED BY 123;



