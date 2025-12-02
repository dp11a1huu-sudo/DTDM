// Frontend Demo - Calling Backend API
// DTDM Cloud Computing Project

console.log("=== FRONTEND DEMO ===");
console.log("Calling Backend API from Frontend");
console.log();

// Simulate frontend calling backend API
const API_BASE = "http://localhost:8085"; // In production: app-backend.cloud.local:8085

async function callBackendAPI() {
    try {
        console.log("1. Calling /hello endpoint...");
        const helloResponse = await fetch(`${API_BASE}/hello`);
        const helloData = await helloResponse.json();
        console.log("✅ Response:", helloData);

        console.log("\n2. Calling /students endpoint...");
        const studentsResponse = await fetch(`${API_BASE}/students`);
        const studentsData = await studentsResponse.json();
        console.log("✅ Response: Retrieved", studentsData.length, "student records");

        console.log("\n3. Calling /secure endpoint (requires JWT)...");
        // This would require a valid JWT token
        console.log("ℹ️  Requires: Authorization: Bearer <jwt_token>");

        console.log("\n🎉 Frontend-Backend communication successful!");
        console.log("🌐 In production: Use domain names instead of localhost");

    } catch (error) {
        console.error("❌ API call failed:", error);
    }
}

// Run demo
callBackendAPI();
