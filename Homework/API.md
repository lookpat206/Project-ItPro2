## สรุปอบรม IT Pro 2 เรื่อง การใช้งาน API

### API : Application Programming Interface คือ

ชุดข้อกำหนดที่กำหนดวิธีการที่โปรแกรมคอมพิวเตอร์ต่าง ๆ สื่อสารกัน หรือวิธีการที่แต่ละส่วนของซอฟต์แวร์สามารถใช้งานกันได้ โดย API ทำหน้าที่เป็นตัวกลางในการทำให้แอปพลิเคชันหรือโปรแกรมสามารถเรียกใช้บริการหรือฟังก์ชันจากโปรแกรมหรือบริการอื่น ๆ ได้โดยไม่ต้องรู้รายละเอียดภายในของโปรแกรมหรือบริการนั้น ๆ อย่างละเอียด

### Web API (Web Application Programming Interface) คือ

ชุดข้อกำหนดที่ให้แอปพลิเคชันหรือโปรแกรมสามารถเชื่อมต่อและสื่อสารกับเซิร์ฟเวอร์หรือบริการอื่น ๆ ผ่านเครือข่ายที่ใช้โปรโตคอล HTTP (Hypertext Transfer Protocol) หรือ HTTPS (HTTP Secure) เพื่อให้บริการหรือแลกเปลี่ยนข้อมูล.

##### วัตถุประสงค์การใช้งาน Web API

1. **การเข้าถึงข้อมูล** : เพื่อดึงข้อมูลจากเว็บไซต์หรือบริการอื่น ๆ โดยไม่ต้องทำการแสดงผลทั้งหมดของเว็บไซต์นั้น ๆ แต่แสดงผลเพียงที่ต้องการเท่านั้น

1. **การส่งข้อมูล**: เพื่อส่งข้อมูลไปยังเซิร์ฟเวอร์หรือบริการอื่น ๆ ที่จะทำการประมวลผลหรือบันทึกข้อมูล.

1. **การให้บริการ** : บริการออนไลน์หลาย ๆ แห่งใช้ Web API เพื่อให้นักพัฒนาสามารถนำบริการนั้น ๆ มาใช้ในแอปพลิเคชันของตนเอง.

1. **การปรับแต่งแอปพลิเคชัน** : Web API ช่วยให้นักพัฒนาสามารถใช้ฟังก์ชันหรือบริการจากระบบภายนอกเพื่อปรับแต่งและเสริมความสามารถของแอปพลิเคชันของตน.

##### ประเภทของ Web API

1. RESTful API (Representational State Transfer)

   > เป็นแนวคิดของการสื่อสารในรูปแบบของ Representation ของข้อมูล โดยใช้ HTTP methods เช่น GET, POST, PUT, DELETE เพื่อทำงานกับข้อมูลบนเซิร์ฟเวอร์. RESTful API มักใช้รูปแบบข้อมูลเป็น JSON

2. GraphQL API

   > เป็นภาษาคิวรีที่ถูกออกแบบมาเพื่อให้แอปพลิเคชันสามารถร้องขอข้อมูลที่ต้องการได้เฉพาะเจาะจง ไม่เหมือนกับ RESTful API ที่มีรูปแบบการส่งข้อมูลที่ถูกกำหนดไว้ล่วงหน้า

3. SOAP (Simple Object Access Protocol)

   > เป็นโปรโตคอลที่ใช้ XML เพื่อสื่อสารระหว่างแอปพลิเคชัน. มักใช้ในการเรียกเมธอดหรือฟังก์ชันจากระบบหรือเซิร์ฟเวอร์ที่ให้บริการ

4. JSON-RPC

   > เป็นโปรโตคอลที่ใช้ JSON เพื่อส่งข้อมูลและเรียกเมธอดหรือฟังก์ชันต่าง ๆ ระหว่างโปรแกรม

5. WebSocket API:

   > เป็นโปรโตคอลที่อนุญาตให้เกิดการสื่อสารแบบ full-duplex (สื่อสารไป-มาได้ทั้งสองทิศทาง) ระหว่างเบราว์เซอร์และเซิร์ฟเวอร์

6. OpenAPI (Swagger):

   > เป็นเครื่องมือที่ช่วยในการสร้างและจัดเก็บเอกสาร API ซึ่งสามารถช่วยให้นักพัฒนาและผู้ใช้งานเข้าใจและใช้งาน API ได้ง่ายขึ้น

7. gRPC (gRPC Remote Procedure Call)

   > เป็นโปรโตคอลที่พัฒนาโดย Google และใช้ Protocol Buffers เพื่อการสื่อสารแบบ RPC ระหว่างแอปพลิเคชัน.

8. SOAP (Simple Object Access Protocol)

   > เป็นโปรโตคอลที่ใช้ XML เพื่อสื่อสารระหว่างแอปพลิเคชัน. มักใช้ในการเรียกเมธอดหรือฟังก์ชันจากระบบหรือเซิร์ฟเวอร์ที่ให้บริการ.

### ขั้นตอนการใช้งาน API

1. ติดตั้ง node js
2. สร้างไฟล์ .env ใช้เก็บข้อมูล Database
   ```
   DB_HOst="localhost"
   DB_USER="root"
   DB_PASS=""
   DB_NAME="myproject"
   DB_PORT=3306
   ```
3. สร้างโฟเดอร์ src ใช้เก็บไฟเดอร์ config ประกอบด้วย ไฟล์ config-database.js และ ไฟล์ index.js

   - ไฟล์ config-database.js

   ```
      const mysql = require('mysql');
      const DB = mysql.createPool({
      host: process.env.DB_HOST,
      user: process.env.DB_USER,
      password:process.env.DB_PASS,
      database: process.env.DB_NAME,
      port: process.env.DB_PORT,
      })

      module.exports = DB;

   ```

   - ไฟล์ index.js

     > ส่วนที 1 ใช้สำหรับดึงข้อมูลจาก database

     ```
     const express = require("express");
     require("dotenv/config");
     const bp = require("body-parser");
     const cors = require("cors");
     const DB = require("./config/config-database.js");
     const moment = require("moment");
     ```

     > ส่วนที่ 2 ใช้สำหรับส่งข้อมูลไปยัง localhost

     ```
     const app = express();
     app.use(express.json());
     app.use(cors());
     app.use(function (req, res, next) {
     res.setTimeout(120000, function () {
     res.send(408);
     });
     next();
     });

     // localhost
     app.listen(5000, () => console.log(`Listening on port${5000}...`));
     ```

     > 2.1
