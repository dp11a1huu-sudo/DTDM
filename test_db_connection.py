import mysql.connector
from mysql.connector import Error

def connect_and_test_database():
    try:
        # Kết nối đến MariaDB
        connection = mysql.connector.connect(
            host='localhost',        # hoặc 127.0.0.1
            port=3306,               # port được expose từ container
            database='studentdb',    # tên database
            user='root',            # username
            password='root'         # password
        )

        if connection.is_connected():
            print("✅ Kết nối thành công đến MariaDB!")
            print(f"📊 Server version: {connection.get_server_info()}")

            # Tạo cursor để thực hiện queries
            cursor = connection.cursor()

            # Hiển thị thông tin database hiện tại
            cursor.execute("SELECT DATABASE();")
            db_name = cursor.fetchone()
            print(f"📋 Database hiện tại: {db_name[0]}")

            # Hiển thị danh sách tables
            cursor.execute("SHOW TABLES;")
            tables = cursor.fetchall()
            print("📋 Danh sách tables:")
            for table in tables:
                print(f"  - {table[0]}")

            # Hiển thị dữ liệu trong bảng students
            cursor.execute("SELECT * FROM students;")
            students = cursor.fetchall()
            print("\n👥 Danh sách sinh viên trong studentdb:")
            print("ID | Student ID | Full Name | DOB | Major")
            print("-" * 60)
            for student in students:
                print(f"{student[0]} | {student[1]} | {student[2]} | {student[3]} | {student[4]}")

            # Thực hiện một số CRUD operations mẫu
            print("\n🔄 THỰC HIỆN CRUD OPERATIONS:")

            # CREATE - Thêm sinh viên mới
            print("\n➕ CREATE: Thêm sinh viên mới")
            cursor.execute("""
                INSERT INTO students (student_id, fullname, dob, major)
                VALUES (%s, %s, %s, %s)
            """, ('SV004', 'Nguyen Van D', '2003-06-15', 'Data Science'))
            connection.commit()
            print("✅ Đã thêm sinh viên SV004")

            # READ - Đọc dữ liệu
            print("\n📖 READ: Hiển thị sinh viên ngành Computer Science")
            cursor.execute("SELECT * FROM students WHERE major = 'Computer Science';")
            cs_students = cursor.fetchall()
            for student in cs_students:
                print(f"  - {student[1]}: {student[2]}")

            # UPDATE - Cập nhật thông tin
            print("\n✏️ UPDATE: Cập nhật major của SV004")
            cursor.execute("""
                UPDATE students
                SET major = 'Artificial Intelligence'
                WHERE student_id = 'SV004'
            """)
            connection.commit()
            print("✅ Đã cập nhật major của SV004 thành 'Artificial Intelligence'")

            # DELETE - Xóa bản ghi
            print("\n🗑️ DELETE: Xóa sinh viên SV004")
            cursor.execute("DELETE FROM students WHERE student_id = 'SV004'")
            connection.commit()
            print("✅ Đã xóa sinh viên SV004")

            # Hiển thị dữ liệu cuối cùng
            print("\n📋 Dữ liệu cuối cùng trong bảng students:")
            cursor.execute("SELECT * FROM students;")
            final_students = cursor.fetchall()
            for student in final_students:
                print(f"  {student[0]}. {student[1]} - {student[2]} ({student[3]}) - {student[4]}")

    except Error as e:
        print(f"❌ Lỗi kết nối database: {e}")

    finally:
        if connection.is_connected():
            cursor.close()
            connection.close()
            print("\n🔌 Đã đóng kết nối database")

if __name__ == "__main__":
    connect_and_test_database()