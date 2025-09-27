<script setup lang="ts">
import { ref } from "vue";
import type { waitlistInput } from "../../features/waitlist/types/waitlistInput";

const inputName = ref("");
const inputEmail = ref("");
const inputPhone = ref("");
const inputDescription = ref("");

const waitlistInput = ref<waitlistInput>;

function requiedFieldsFilledOut() {
  return (
    inputName.value.trim() !== "" &&
    inputDescription.value.trim() !== "" &&
    inputEmail.value.trim() !== "" &&
    validateEmail(inputEmail.value)
  );
}

function validateEmail(email: string) {
  const emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
  return emailPattern.test(email);
}

</script>

<template>
  <div class="form-container">
    <article class="contact-card">
      <div class="card-content">
        <row>
          <div class="title-section">
            <h2 class="title-main">TILMELD</h2>
            <h2 class="title-main">VENTELISTE</h2>
          </div>
        </row>
        <!-- Title Section - Now at top -->
        <row>
          <div class="form-section">
            <form class="form-fields">
              <div class="field-group">
                <input
                  type="text"
                  placeholder="FULDE NAVN"
                  class="form-input"
                  v-model="inputName"
                  required
                />
              </div>

              <div class="field-group">
                <input
                  type="email"
                  placeholder="EMAIL"
                  class="form-input"
                  v-model="inputEmail"
                  required
                />
              </div>

              <div class="field-group">
                <input
                  type="tel"
                  placeholder="TELEFON (VALGFRIT)"
                  class="form-input"
                  v-model="inputPhone"
                />
              </div>

              <div class="field-group">
                <textarea
                  placeholder="BESKRIVELSE AF DET PRODUKT DU ØNSKER"
                  rows="3"
                  class="form-input form-textarea"
                  v-model="inputDescription"
                />
              </div>

              <!-- Buttons -->
              <div class="button-group">
                <button type="button" class="btn-secondary">ANNULLER</button>
                <button
                  type="submit"
                  class="btn-primary"
                  :disabled="!requiedFieldsFilledOut()"
                >
                  TILMELD
                </button>
              </div>
            </form>
          </div>
        </row>
        <!-- Form Section - Below title -->

        <!-- Contact Info - Now at bottom -->
        <div class="contact-info">KONTAKT INFO • agnestha@atelier.dk</div>
      </div>
    </article>
  </div>
</template>
<style scoped>
.form-container {
  align-items: center;
  justify-content: center;
  min-width: 70vh;
}

.contact-card {
  background-color: var(--bg-secondary);
  border-radius: 16px;
  padding: 2rem;
  box-shadow: 0 20px 25px -5px rgba(0, 0, 0, 0.1);
}

.form-input {
  width: 100%;
  background: transparent;
  border: none;
  border-bottom: 1px solid var(--border, #999);
  padding: 0.6rem 0;
  font-size: 1rem;
  color: var(--fg-primary);
  transition: border-color 0.3s ease;
}

.form-input:focus {
  outline: none;
  border: none;
  border-bottom: 1px solid var(--border, #999);
  box-shadow: none;
}

.form-input::placeholder {
  color: var(--fg-primary, #666);
  font-weight: 500;
  letter-spacing: 0.05em;
  opacity: 0.7;
}
.form-textarea {
  resize: none;
}

.title-section {
  text-align: left;
}

.title-main {
  font-size: 2rem;
  font-weight: bold;
  color: var(--fg-primary);
  margin: 0;
  line-height: 0.9;
  margin-bottom: 0.2rem;
}

.button-group {
  display: flex;
  justify-content: flex-end;
  gap: 2rem;
  margin-top: 0.5rem;
}

.contact-info {
  font-size: 0.75rem;
  color: var(--fg-primary, #666);
  letter-spacing: 0.05em;
  opacity: 0.7;
  text-align: left;
}
</style>
