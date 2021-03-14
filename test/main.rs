extern crate uuid;
extern crate serde;

use uuid::Uuid;
use serde::{Serialize, Deserialize};

// I'm a comment

/*
 * I'm another comment!
 */

fn main() {
    let a = MyStruct {
        user_id: Uuid::nil()
    };
    println!("Generated ID: {}", a.user_id);

    let json_str = serde_json::to_string_pretty(&a).unwrap();
    println!("Serialized Struct:\n{}\n", json_str);
    let b: MyStruct = serde_json::from_str(&json_str).unwrap();

    println!("ID from deserialized struct: {}", b.user_id);
}

#[derive(Serialize, Deserialize)]
pub struct MyStruct {
    user_id: Uuid
}
