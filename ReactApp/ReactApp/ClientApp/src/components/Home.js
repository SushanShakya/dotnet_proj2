import React, { Component } from 'react';
import logo from "./sushan.JPG";

export class Home extends Component {
  static displayName = Home.name;

  render() {
    return (
      <div>
        <h1> I am Sushan </h1>
        <img alt='Me' src={logo} height={"600px"} width={"400px"} />
      </div>
    );
  }
}
