#!/usr/bin/env bash
# Khởi động MiniCloud (11 container) trên GitHub Codespaces.
# Tự động phát hiện domain public của Codespaces để cấu hình Keycloak issuer,
# tránh lỗi /secure trả 401 do lệch claim "iss" giữa token và backend.
set -e

if [ -z "$CODESPACE_NAME" ] || [ -z "$GITHUB_CODESPACES_PORT_FORWARDING_DOMAIN" ]; then
  echo ">> Không phát hiện GitHub Codespaces. Chạy ở chế độ local (mặc định localhost)."
  docker compose up -d
  exit 0
fi

DOMAIN="${GITHUB_CODESPACES_PORT_FORWARDING_DOMAIN}"
KC_PUBLIC_URL="https://${CODESPACE_NAME}-8081.${DOMAIN}"

cat > .env <<EOF
# Tệp này được start-codespaces.sh sinh tự động - KHÔNG commit lên Git.
KC_HOSTNAME=${KC_PUBLIC_URL}
OIDC_ISSUER_EXPECTED=${KC_PUBLIC_URL}/realms/realm_sv110
EOF

echo ">> Đã sinh .env:"
cat .env
echo ""

docker compose up -d

echo ""
echo "=== Đặt các cổng sau thành Public trong tab PORTS của Codespaces ==="
echo "API Gateway   : https://${CODESPACE_NAME}-80.${DOMAIN}"
echo "Web Server    : https://${CODESPACE_NAME}-8080.${DOMAIN}"
echo "Keycloak      : ${KC_PUBLIC_URL}"
echo "App Backend   : https://${CODESPACE_NAME}-8085.${DOMAIN}"
echo "MinIO Console : https://${CODESPACE_NAME}-9001.${DOMAIN}"
echo "Prometheus    : https://${CODESPACE_NAME}-9090.${DOMAIN}"
echo "Grafana       : https://${CODESPACE_NAME}-3000.${DOMAIN}"
