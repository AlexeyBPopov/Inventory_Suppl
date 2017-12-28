use InventoryDB

select * from LocAreas

insert into LocUnits (UnitNum, LocArea_ID) values (1,2)
insert into LocUnits (UnitNum, LocArea_ID) values (2,2)
insert into LocUnits (UnitNum, LocArea_ID) values (3,2)
insert into LocUnits (UnitNum, LocArea_ID) values (4,2)
insert into LocUnits (UnitNum, LocArea_ID) values (5,2)
insert into LocUnits (UnitNum, LocArea_ID) values (6,2)
insert into LocUnits (UnitNum, LocArea_ID) values (7,2)
insert into LocUnits (UnitNum, LocArea_ID) values (8,2)

select LocUnits.ID, LocAreas.AreaName, LocUnits.UnitNum 
from LocUnits inner join LocAreas on (LocUnits.LocArea_ID = LocAreas.ID)