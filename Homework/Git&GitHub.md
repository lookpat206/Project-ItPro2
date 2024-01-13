## สรุปอบรม IT Pro 2 เรื่อง การใช้ Git & Git Hub

### Version Control

คือ เครื่องมือช่วยติดตามการเปลี่ยนแปลงของ Source Code เพื่อให้สามารถย้อนกับไปเวอร์ชั่นก่อนหน้าได้

#### สาเหตุการใช้งาน Version Control

    - เกิดการบันทึกข้อมูลซ้ำ เป็นจำนวนมาก ส่งผลให้ใช้พื้นที่ในการเก็บข้อมูลขนาดใหญ่
    - เกิดความสับสนในการบันทึกข้อมูล

### วิวัฒนาการ Version Control

1. Copy File & Folder การบันทึกสำรองไฟล์/โฟเดอร์ไปเรื่อย
2. Patch เปรียบเทียบไฟล์ใหม่ กับ ไฟล์เก่า
3. Local Version Control System มีฐานข้อมูลเฉพาะใช้จัดเก็บข้อมูลการเปลี่ยนแปลง

- Check-In="จัดเก็บ"
- Check-Out"เรียกคืน"

4. Centralized Local Version Control System แบบรวมศูนย์ ใช้งานเป็นทีม ถ้าง่ายระบบ รวมให้ ถ้ายากระบบ ถามผู้ใช้
5. Distributde Local Version Control System แบบกระจายบันทึกข้อมูลหลักผู้ใช้ Clone ข้อมูลไว้ในเครื่อง

- Check-In & Check-Out แบบ Offline
- Push ขึ้น Server

### Git Hub

คือเว็บเซิฟเวอร์ที่ให้บริการฝากไฟล์ Git Remote Repository

### Git

คือโปรแกรมที่ใช้ติดตามและ ตรวจสอบการแก้ไขไฟล์หรือcode ของ project โดย มีรูปแบบการทำงานแบบLocal Repository และ แบบ Distributde Local Version Control System

#### สาเหตุการใช้งาน Git

- ติดตามเวอร์ชั่นของโค้ด
- อำนวยความสะดวกในการทำงานเป็นทีม

#### วงจรการใช้งาน

1. Working Directory (Untracked) คือ ไฟล์หรือโฟเดอร์ ในคอมพิวเตอร์ของผู้ใช้
1. Working Directory (Tracked) คือ ไฟล์หรือโฟเดอร์ ที่ผู้ใช้ track ไว้กับ Git โดยใช้คำสั่ง git init
1. Staging Area คือ พื้นที่จัดเก็บเวอร์ชันของไฟล์ที่ผู้ใช้แก้ไข โดยใช้คำสั่ง git add
1. Local Repository คือ การบันทึกข้อมูลไฟล์ที่แก้ไขแล้วลงในคอมพิวเตอร์ของผู้ใช้ โดยใช้คำสั่ง git commit
1. Remote Repository คือ การผลักข้อมูลในคอมพิวเตอร์ขึ้นไปบน Server แสดงข้อมูลบน Git Hub หรือ GitLab โดยใช้คำสั่ง git push

#### คำสั่งที่ใช้กับ Git

- เริ่มต้นการใช้งาน สร้าง Local Git Repository
  - git init
- การ Tracked ไฟล์เพิ่มเข้า git
  - git add
- การ Tracked ลบไฟล์ใน git
  - git rm --cached
- การบันทึกประวัติการแก้ไขถาวร และ การแสดงรายละเอียดการบันทึก
  - git Commit
  - git Log
- การเปรียบเทียบไฟล์ในเวอร์ชั่นต่างๆ
  - git diff
- การยกเลิกการแก้ไขไฟล์
  - git checkout
- การกู้คืนไฟล์
  - git reset
- Branching คือ การแบ่งกิ่ง เพื่อแยกส่วนการทำงาน
  - add
  - delete
  - Merge (รวมกิ่ง)
- การบันทึกข้อมูลบน Server
  - git push
- การดึงข้อมูลบน Server มายังคอมพิวเตอร์
  - git pull
- การคัดลอกข้อมูลจาก Server
  - git clone
- การเพิ่ม README
  - ใช้ทำคู่มือการใช้งาน(เอกสารประกอบ)
  - ใช้เขียนอธิบายระเอียดของ Project
