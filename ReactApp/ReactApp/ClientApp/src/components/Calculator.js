import { useState } from "react"

export const Calculator = () => {

    const [a, seta] = useState(0);
    const [b, setb] = useState(0);
    const [v, setV] = useState("add");
    const [res, setRes] = useState(0);


    const compute = () => {
        switch (v) {
            case "add":
                setRes(a + b);
                break;
            case "sub":
                setRes(a - b);
                break;
            case "mul":
                setRes(a * b);
                break;
        }
    }

    return (
        <div>
            <h1>Calculator</h1>
            <input type="number" onChange={(e) => seta(parseInt(e.target.value))} /> <br></br>
            <input type="number" onChange={(e) => setb(parseInt(e.target.value))} /> <br></br>
            <select onChange={(e) => setV(e.target.value)}>
                <option value="add">Add</option>
                <option value="sub">Substract</option>
                <option value="mul">Muliply</option>
            </select>
            <p>Result : {res} </p>
            <button onClick={compute} >Compute</button>
        </div>
    )
}