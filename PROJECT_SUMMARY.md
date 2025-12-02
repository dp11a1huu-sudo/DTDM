# 📋 TỔNG QUAN TOÀN DỰ ÁN DTDM - ĐIỆN TOÁN ĐÁM MÂY

**Ngày hoàn thành:** 27-29 tháng 11 năm 2025
**Sinh viên:** Bùi Hương Giang, Phạm Thị Thùy An, Nguyễn Thị Mỹ Dung
**Giáo viên hướng dẫn:** TS. Trần Chí Thiện

---

## 📊 TỔNG QUÁT HỆ THỐNG

### 1. Kiến Trúc Microservices

Dự án DTDM là một **mô phỏng hệ thống cloud computing** với 9 dịch vụ chính chạy trong Docker containers:

```
┌─────────────────────────────────────────┐
│         USER/INTERNET (Port 80)         │
└────────────────┬────────────────────────┘
                 │
        ┌────────▼─────────┐
        │   API Gateway    │
        │  (Nginx @ :80)   │
        │  Reverse Proxy   │
        └────┬─────────┬───┘
             │         │
        ┌────▼─┐   ┌──▼──────────┐
        │ Web  │   │   Backend   │
        │Front │   │    API      │
        │:8080 │   │   :8085     │
        └──────┘   │  (Flask)    │
                   └──┬──────────┘
                      │
        ┌─────────────┼──────────────┐
        │             │              │
    ┌───▼──┐    ┌────▼────┐    ┌───▼──┐
    │ DB   │    │ Auth    │    │MinIO │
    │:3306 │    │:8081    │    │:9000 │
    │Maria │    │Keycloak │    │      │
    │DB    │    └─────────┘    └──────┘
    └──────┘
    
    ┌──────────────────────────────────┐
    │  Monitoring & Observability      │
    │  Prometheus:9090 | Grafana:3000  │
    └──────────────────────────────────┘
    
    ┌──────────────────────────────────┐
    │  Internal DNS Server (BIND9)     │
    │  Port: 1053 UDP                  │
    └──────────────────────────────────┘
```

### 2. 9 Services Trong Docker Compose

| No | Service | Image | Port | Mục Đích |
|----|---------|-------|------|---------|
| 1 | api-gateway-proxy-server | nginx:stable | 80 | Reverse proxy & routing |
| 2 | web-frontend-server | nginx:stable | 8080 | Web frontend tĩnh |
| 3 | application-backend-server | python:3.11-alpine | 8085 | Flask REST API |
| 4 | authentication-identity-server | keycloak:latest | 8081 | OAuth2/OIDC auth |
| 5 | relational-database-server | mariadb:11 | 3306 | Database |
| 6 | object-storage-server | minio/minio | 9000/9001 | Object storage |
| 7 | internal-dns-server | bind9:9.18 | 1053 | DNS resolver |
| 8 | monitoring-prometheus-server | prom/prometheus | 9090 | Metrics collection |
| 9 | monitoring-grafana-dashboard-server | grafana/grafana | 3000 | Metrics visualization |
| 10 | monitoring-node-exporter-server | prom/node-exporter | 9100 | System metrics |

---

## 📁 CẤU TRÚC DỰ ÁN

```
DTDM/
├── docker-compose.yml                    ← Orchestration file (9 services)
│
├── api-gateway-proxy-server/             ← API Gateway (Nginx)
│   └── nginx.conf                        ← Routing: / → web, /api → backend, /auth → keycloak
│
├── web-frontend-server/                  ← Web Frontend (Nginx)
│   ├── Dockerfile                        ← Alpine nginx + HTML
│   ├── conf.default                      ← Nginx config (port 80 → 8080)
│   └── html/
│       ├── index.html                    ← Homepage: "MyMiniCloud - Home"
│       └── blog/
│           └── index.html                ← Blog index
│
├── application-backend-server/           ← Backend API (Flask)
│   ├── Dockerfile                        ← Python 3.11 + Flask
│   ├── app.py                            ← Flask routes (4 endpoints)
│   └── students.json                     ← 5 sinh viên mẫu (JSON)
│
├── relational-database-server/           ← MariaDB Database
│   └── init/
│       ├── 001_init.sql                  ← Create minicloud DB + notes table
│       └── 002_init.sql                  ← Create studentdemo DB + students table
│
├── authentication-identity-server/       ← Keycloak (OAuth2/OIDC)
│   (No config needed - image only)
│
├── object-storage-server/                ← MinIO (S3-compatible)
│   └── data/                             ← Volume mount for storage
│
├── internal-dns-server/                  ← BIND9 DNS Server
│   ├── named.conf                        ← BIND config
│   ├── named.conf.options                ← DNS options (disable IPv6, dnssec)
│   ├── named.conf.local                  ← Zone definitions
│   └── db.cloud.local                    ← Zone file (4 DNS records)
│
├── monitoring-prometheus-server/         ← Prometheus
│   └── prometheus.yml                    ← Config (1 job: node-exporter)
│
├── test scripts/
│   ├── test_db_connection.py             ← Test MariaDB connection
│   ├── test_system_complete.ps1          ← PowerShell test all services
│   ├── get_keycloak_token.ps1            ← Get JWT token from Keycloak
│   ├── test_dns_final.ps1                ← Test DNS resolution
│   └── test_secure.py                    ← Test JWT validation
│
└── Additional files
    ├── HUONG_DAN_CHI_TIET.txt            ← Detailed tutorial
    ├── README_DB_TEST.md                 ← Database testing guide
    └── Report_DTDM_COMPLETE.md           ← Full report (generated)
```

---

## 🔌 4 ENDPOINTS BACKEND API

### Flask App (app.py) - 4 Endpoints

| Endpoint | Method | Auth | Response |
|----------|--------|------|----------|
| `/hello` | GET | ❌ Public | `{"message": "Hello from Backend!"}` |
| `/student` | GET | ❌ Public | JSON array từ `students.json` (5 sinh viên) |
| `/students` | GET | ❌ Public | JSON array từ database `studentdemo.students` |
| `/secure` | GET | ✅ JWT Required | `{"message": "Secure resource OK (DEBUG MODE)", "preferred_username": "sv01"}` |

### Route Mappings

```
Browser Request               API Gateway (Nginx)      Backend Server
─────────────────            ───────────────────      ──────────────
http://localhost/api/hello   location /api/  ──→    http://backend:8081/hello
http://localhost/api/student location /api/  ──→    http://backend:8081/student
http://localhost/api/students location /api/ ──→    http://backend:8081/students
```

---

## 🗄️ DATABASE SCHEMA

### Database 1: minicloud

```sql
CREATE TABLE notes (
    id INT AUTO_INCREMENT PRIMARY KEY,
    title VARCHAR(100) NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

INSERT INTO notes(title) VALUES ('Hello from MariaDB!');
```

### Database 2: studentdemo

```sql
CREATE TABLE students (
    id INT AUTO_INCREMENT PRIMARY KEY,
    student_id VARCHAR(10) NOT NULL,
    fullname VARCHAR(100) NOT NULL,
    dob DATE,
    major VARCHAR(50)
);

-- 3 sinh viên mẫu:
('SV01', 'Bui Huong Giang', '2005-04-03', 'Cong nghe thong tin'),
('SV02', 'Pham Thi Thuy An', '2005-01-20', 'Mang tinh va truyen thong du lieu'),
('SV03', 'Nguyen Thi My Dung', '2005-09-03', 'An toan thong tin')
```

---

## 🔐 AUTHENTICATION FLOW (Keycloak)

### 1. Setup Keycloak (Admin Console)

```
URL: http://localhost:8081
Username: admin
Password: admin
```

### 2. Create Realm: realm_sv189

```
Realm: realm_sv189
Enabled: ON
```

### 3. Create User: sv01

```
Username: sv01
Email: sv01@cloud.local
First name: Sinh
Last name: Vien 01
Password: password123
Enabled: ON
```

### 4. Create Client: flask-app

```
Client ID: flask-app
Type: OpenID Connect
Authentication: OFF
Redirect URIs: http://localhost:8085/*
Standard Flow: ON
Direct Access Grants: ON
```

### 5. Get JWT Token

```powershell
$response = Invoke-WebRequest -Uri "http://localhost:8081/realms/realm_sv189/protocol/openid-connect/token" `
  -Method POST `
  -Headers @{"Content-Type"="application/x-www-form-urlencoded"} `
  -Body "grant_type=password&client_id=flask-app&client_secret=<SECRET>&username=sv01&password=password123"

$token = ($response.Content | ConvertFrom-Json).access_token
```

### 6. Use Token to Call Secure Endpoint

```bash
curl -H "Authorization: Bearer $token" http://localhost:8085/secure
```

---

## 🌐 NGINX ROUTING CONFIGURATION

### API Gateway (nginx.conf)

```nginx
events {}
http {
    server {
        listen 80;
        
        # Web Frontend
        location / {
            proxy_pass http://web-frontend-server:80;
            proxy_set_header Host $host;
            proxy_set_header X-Real-IP $remote_addr;
        }
        
        # Backend API (strip /api/)
        location /api/ {
            proxy_pass http://application-backend-server:8081/;
        }
        
        # Keycloak
        location /auth/ {
            proxy_pass http://authentication-identity-server:8080/;
        }
    }
}
```

### Request Flow

```
Browser → http://localhost/api/hello
   ↓
API Gateway @ :80 sees /api/
   ↓
Proxy to http://application-backend-server:8081/hello
   ↓
Flask returns: {"message": "Hello from Backend!"}
```

---

## 🔍 DNS CONFIGURATION (BIND9)

### Zone File: db.cloud.local

```
$TTL 1H
@   IN  SOA ns.cloud.local. admin.cloud.local. (2 1H 15M 1W 1H)
    IN  NS  ns.cloud.local.
ns  IN  A   172.18.0.10

; Service Records
web-frontend-server     IN A 10.10.10.10
app-backend.cloud.local IN A 10.10.10.20
minio.cloud.local       IN A 10.10.10.30
keycloak.cloud.local    IN A 10.10.10.40
```

### DNS Resolution

```bash
# Test from host
dig @127.0.0.1 -p 1053 app-backend.cloud.local

# Test from container
docker exec app-backend nslookup app-backend.cloud.local internal-dns-server

# Expected
# Server: internal-dns-server
# Address: 172.18.0.X#53
# Name: app-backend.cloud.local
# Address: 10.10.10.20
```

---

## 📊 MONITORING STACK

### Prometheus (prometheus.yml)

```yaml
global:
  scrape_interval: 15s

scrape_configs:
  - job_name: 'node'
    static_configs:
      - targets: ['monitoring-node-exporter-server:9100']
```

### Grafana Dashboard

```
URL: http://localhost:3000
Username: admin
Password: admin

Data Source: Prometheus @ http://monitoring-prometheus-server:9090

Metrics:
- CPU: rate(node_cpu_seconds_total[5m])
- RAM: node_memory_MemAvailable_bytes
- Network: rate(node_network_receive_bytes_total[5m])
```

---

## 🧪 TESTING CHECKLIST

### 1. Web Frontend (Port 8080)
```bash
curl -I http://localhost:8080
# Expected: HTTP/1.1 200 OK
```

### 2. API Gateway (Port 80)
```bash
curl http://localhost/
# Expected: HTML from web-frontend
```

### 3. Backend API (Port 8085)
```bash
curl http://localhost:8085/hello
# {"message": "Hello from Backend!"}

curl http://localhost:8085/student
# [{"id": "SV001", "name": "Nguyen Van A", ...}, ...]

curl http://localhost:8085/students
# [DB records from studentdemo.students]
```

### 4. Database (Port 3306)
```bash
docker exec relational-database-server mariadb -uroot -proot -e "SHOW DATABASES; USE minicloud; SHOW TABLES;"
# minicloud.notes
# studentdemo.students
```

### 5. Keycloak (Port 8081)
```
http://localhost:8081
Admin: admin/admin

Create realm_sv189 → Create user sv01 → Create client flask-app → Get JWT token
```

### 6. MinIO (Port 9001)
```
http://localhost:9001
minioadmin/minioadmin

Create buckets: profile-pics, documents
Upload files: avatar.jpg, report.pdf
```

### 7. DNS Server (Port 1053)
```bash
docker exec -it app-backend nslookup app-backend.cloud.local internal-dns-server
# Expected: Address: 10.10.10.20
```

### 8. Prometheus (Port 9090)
```
http://localhost:9090
Status → Targets
up metric
```

### 9. Grafana (Port 3000)
```
http://localhost:3000
Connections → Data sources → Prometheus
Create custom dashboard with 3 metrics
```

---

## 🚀 QUICK START

### 1. Start All Services

```bash
cd c:\52300110_NgoTrongHuu\DTDM
docker compose up -d
docker compose ps  # Verify 9 containers running
```

### 2. Test Web

```bash
# Browser: http://localhost/
# Expected: "MyMiniCloud - Home" from web-frontend
```

### 3. Test API

```bash
curl http://localhost:8085/hello
# {"message": "Hello from Backend!"}
```

### 4. Test Database

```bash
python test_db_connection.py
```

### 5. Setup Keycloak

```bash
# http://localhost:8081 → admin/admin
# Create realm_sv189, user sv01, client flask-app
```

### 6. Get JWT Token

```bash
.\get_keycloak_token.ps1
```

### 7. Test Secure Endpoint

```bash
curl -H "Authorization: Bearer $token" http://localhost:8085/secure
# {"message": "Secure resource OK (DEBUG MODE - UPDATED)", "preferred_username": "sv01"}
```

---

## 📝 KEY FEATURES & IMPLEMENTATIONS

### ✅ Implemented

1. **10 Microservices** trong Docker Compose
2. **Nginx Reverse Proxy** với routing rules
3. **Flask REST API** với 4 endpoints
4. **Keycloak Authentication** (OAuth2/OIDC)
5. **MariaDB Database** với 2 databases
6. **BIND9 DNS Server** với zone file
7. **MinIO Object Storage** (S3-compatible)
8. **Prometheus + Grafana** cho monitoring
9. **Node Exporter** cho system metrics
10. **JWT Token Validation** cho secure endpoints

### 🔧 Configuration Details

1. **Docker Network:** cloud-net (bridge)
2. **Port Mapping:** 80 (gateway), 8080 (frontend), 8085 (backend), 8081 (keycloak), 3306 (db), 9000/9001 (minio), 1053 (dns), 9090 (prometheus), 3000 (grafana)
3. **Database Init:** Auto-run SQL scripts từ `/docker-entrypoint-initdb.d`
4. **DNS:** BIND9 với IPv6 disabled, DNSSEC disabled
5. **API Gateway:** Strip `/api/` prefix trước forward
6. **Token Validation:** Debug mode - chỉ check Bearer format & audience claim

### 🎯 Learning Outcomes

- Hiểu microservices architecture
- Docker & containerization
- Networking & service discovery (DNS)
- Authentication & authorization (OAuth2/OIDC)
- API gateway & reverse proxy
- Database management
- Monitoring & observability
- Infrastructure as Code (docker-compose)

---

## 📋 ENVIRONMENT VARIABLES

### application-backend-server

```env
OIDC_ISSUER=http://authentication-identity-server:8080/realms/realm_sv189
OIDC_AUDIENCE=account
```

### authentication-identity-server (Keycloak)

```env
KC_BOOTSTRAP_ADMIN_USERNAME=admin
KC_BOOTSTRAP_ADMIN_PASSWORD=admin
KC_HOSTNAME=localhost
KC_HOSTNAME_STRICT=false
KC_HTTP_ENABLED=true
```

### relational-database-server (MariaDB)

```env
MARIADB_ROOT_PASSWORD=root
MARIADB_DATABASE=minicloud
```

### object-storage-server (MinIO)

```env
MINIO_ROOT_USER=minioadmin
MINIO_ROOT_PASSWORD=minioadmin
```

---

## 🔗 IMPORTANT LINKS & RESOURCES

### Local Services

- Web Frontend: http://localhost:8080
- API Gateway: http://localhost:80
- Backend API: http://localhost:8085
- Keycloak Admin: http://localhost:8081/admin
- MinIO Console: http://localhost:9001
- Prometheus: http://localhost:9090
- Grafana: http://localhost:3000
- DNS: localhost:1053 (UDP)

### Database Connections

- MariaDB: localhost:3306 (root/root)
- Databases: minicloud, studentdemo

### API Endpoints

- Public: /hello, /student, /students
- Protected: /secure (requires JWT token)

### Credentials

- Keycloak Admin: admin/admin
- MinIO Admin: minioadmin/minioadmin
- Database: root/root
- Grafana: admin/admin

---

## 📚 ADDITIONAL RESOURCES

- HUONG_DAN_CHI_TIET.txt - Detailed tutorial (1433 lines)
- Report_DTDM_COMPLETE.md - Full report with screenshots
- test_system_complete.ps1 - Complete test script
- get_keycloak_token.ps1 - Token retrieval script

---

**Dự án hoàn thành và sẵn sàng cho production testing!** 🎉
