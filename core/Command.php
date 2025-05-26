<?php
interface Command {
    public function execute();
}

class AddStyleCommand implements Command {
    private $element, $style;

    public function __construct($element, $style) {
        $this->element = $element;
        $this->style = $style;
    }

    public function execute() {
        $this->element->styles[] = $this->style;
    }
}
