from flask import Flask, jsonify
import json
import os

app = Flask(__name__)

file_path = os.path.join(os.path.dirname(__file__), "example_station.json")
with open(file_path, "r", encoding="utf-8") as f:
    JSON_DATA = json.load(f)

@app.route("/", defaults={"path": ""})
@app.route("/<path:path>")
def catch_all(path):
    return jsonify(JSON_DATA)

# zum starten: 
# $ flask --app mock-api run --host=0.0.0.0