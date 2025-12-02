import mysql.connector
from mysql.connector import Error

def test_db_connection():
    connection = None
    cursor = None
    try:
        connection = mysql.connector.connect(
            host='127.0.0.1',      # dùng localhost/127.0.0.1 thay cho tên container
            port=3306,             # port bạn đã map
            database='studentdb',
            user='root',
            password='root'
        )

        if connection.is_connected():
            cursor = connection.cursor()
            cursor.execute("SELECT * FROM students")
            records = cursor.fetchall()

            print("Danh sách sinh viên:")
            for row in records:
                print(f"ID: {row[0]}, Student ID: {row[1]}, Name: {row[2]}")

    except Error as e:
        print(f"Lỗi: {e}")
    finally:
        # Kiểm tra connection và cursor trước khi đóng
        if cursor is not None:
            cursor.close()
        if connection is not None and connection.is_connected():
            connection.close()

if __name__ == "__main__":
    test_db_connection()
