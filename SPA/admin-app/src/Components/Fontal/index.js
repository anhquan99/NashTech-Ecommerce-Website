import React, { Component } from 'react'
import { faPaperPlane } from "@fortawesome/free-solid-svg-icons";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
export default class index extends Component {
    render() {
        return (
            <div>
                <div>
                    <FontAwesomeIcon icon={faPaperPlane} />
                    With Coffee Checked, these companies always know their coffee is hot and ready!
  </div>
            </div>
        )
    }
}
