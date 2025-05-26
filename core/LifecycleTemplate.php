<?php
abstract class LifecycleTemplate {
    public function render() {
        $this->onCreated();
        $this->onInserted();
        $this->onStylesApplied();
        $this->onClassListApplied();
        $this->onTextRendered();
    }

    protected function onCreated() { echo "<!-- Element Created -->\n"; }
    protected function onInserted() { echo "<!-- Element Inserted -->\n"; }
    protected function onStylesApplied() {}
    protected function onClassListApplied() {}
    protected function onTextRendered() {}
}
